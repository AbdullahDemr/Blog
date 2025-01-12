﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Blog;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Results.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;
using TigrisTech.Shared.Utilities.Results.Concrete;
using TigrisTech.Services.Utilities;
using TigrisTech.Entities.ComplexTypes;
using TigrisTech.Shared.Entities.Concrete;

namespace TigrisTech.Services.Concrete

{
    public class ArticleManager : ManagerBase, IArticleService
    {
        private readonly UserManager<User> _userManager;
        public ArticleManager(UserManager<User> userManager,IUnitOfWork unitOfWork, IMapper mapper):base(unitOfWork,mapper)
        {
            _userManager = userManager;
        }
        public async Task<IResult> AddAsync(ArticleAddDto articleAddDto, string createByName,int userId)
        {
            var article = Mapper.Map<Article>(articleAddDto);
            article.CreateByName = createByName;
            article.ModifiedByName = createByName;
            article.UserId = userId;
            await UnitOfWork.Articles.AddSync(article)/*.ContinueWith(t => _unitOfWork.SaveAsync())*/;
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{articleAddDto.Title} başlıklı makale başarıyla eklenmiştir.");
        }
        public async Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            var oldArticle = await UnitOfWork.Articles.GetAsync(a => a.Id == articleUpdateDto.Id);

            var article = Mapper.Map<ArticleUpdateDto, Article>(articleUpdateDto,oldArticle);
            article.ModifiedByName = modifiedByName;
            await UnitOfWork.Articles.UpdateAsync(article);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{articleUpdateDto.Title} başlıklı makale başarıyla güncellenmiştir.");
        }
        public async Task<IResult> DeleteAsync(int articleId, string modifiedByName)
        {
            var result = await UnitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);
                article.IsDeleted = true;
                article.IsActive = false;
                article.ModifiedByName = modifiedByName;
                article.ModifiedDate = DateTime.Now;
                await UnitOfWork.Articles.UpdateAsync(article);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{article.Title} başlıklı makale başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir makale bulunamadı.");
        }
        public async Task<IResult> HardDeleteAsync(int articleId)
        {
            var result = await UnitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);
              
                await UnitOfWork.Articles.DeleteAsync(article);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{article.Title} başlıklı makale başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir makale bulunamadı.");
        }
        public async Task<IDataResult<ArticleDto>> GetAsync(int articleId)
        {
            var article = await UnitOfWork.Articles
                .GetAsync(a => a.Id == articleId, a => a.User, a => a.Category);            
            if (article != null)
            {
                article.Comments = await UnitOfWork.Comments
                    .GetAllAsync(c => c.ArticleId == articleId && !c.IsDeleted && c.IsActive);
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    Article = article,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleDto>
                (ResultStatus.Error, "Böyle bir makale bulunamadı.", null);
        }
        public async Task<IDataResult<ArticleListDto>> GetAllAsync()
        {
            var articles = await UnitOfWork.Articles
                .GetAllAsync(null, a => a.User, a => a.Category);
            if(articles != null)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Makaleler bulunamadı.", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAsync()
        {
            var articles = await UnitOfWork.Articles.GetAllAsync(a => !a.IsDeleted, ar => ar.User, ar => ar.Category);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Makaleler bulunamadı.", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var articles = await UnitOfWork.Articles.GetAllAsync(a => !a.IsDeleted && a.IsActive, ar => ar.User, ar => ar.Category);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(true), null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllCategoryAsync(int categoryId)
        {
            var result = await UnitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var articles = await UnitOfWork.Articles.GetAllAsync(a => a.CategoryId == categoryId && !a.IsDeleted && a.IsActive, ar => ar.User, ar => ar.Category);
                if (articles.Count > -1)
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                    {
                        Articles = articles,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, "Makaleler bulunamadı.", null);
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var articlesCount = await UnitOfWork.Articles.CountAsync();
            if (articlesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, articlesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var articlesCount = await UnitOfWork.Articles.CountAsync(a=>!a.IsDeleted);
            if (articlesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, articlesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }

        public async Task<IDataResult<ArticleUpdateDto>> GetArticleUpdateDtoAsync(int articleId)
        {
            var result = await UnitOfWork.Articles.AnyAsync(c => c.Id == articleId);
            if (result)
            {
                var article = await UnitOfWork.Articles.GetAsync(c => c.Id == articleId);
                var articleUpdateDto = Mapper.Map<ArticleUpdateDto>(article);
                return new DataResult<ArticleUpdateDto>(ResultStatus.Success, articleUpdateDto);
            }
            else
            {
                return new DataResult<ArticleUpdateDto>(ResultStatus.Error, "   ", null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByDeletedAsync()
        {
            var articles = await UnitOfWork.Articles.GetAllAsync(a => a.IsDeleted,  ar => ar.User, ar => ar.Category);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(true), null);
        }

        public async Task<IResult> UndoDeleteAsync(int articleId, string modifiedByName)
        {
            var result = await UnitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);
                article.IsDeleted = false;
                article.IsActive = true;
                article.ModifiedByName = modifiedByName;
                article.ModifiedDate = DateTime.Now;
                await UnitOfWork.Articles.UpdateAsync(article);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success,Messages.Article.UndoDelete(article.Title));
            }
            return new Result(ResultStatus.Error, Messages.Article.NotFound(false));
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByViewCountAsync(bool isAccending, int? takeSize)
        {
            var articles = 
                await UnitOfWork.Articles.GetAllAsync(a => a.IsActive && !a.IsDeleted, a => a.Category, a => a.User);
            var sortedArticles = isAccending 
                ? articles.OrderBy(a => a.ViewsCount) 
                : articles.OrderByDescending(a => a.ViewsCount);
            return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
            {
                Articles = takeSize == null
                ? sortedArticles.ToList()
                : sortedArticles.Take(takeSize.Value).ToList()
            });

        }

        public async Task<IDataResult<ArticleListDto>> GetAllByPagingAsync(int? categoryId, 
            int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var articles = categoryId == null
                ? await UnitOfWork.Articles.GetAllAsync(a => a.IsActive && !a.IsDeleted, a => a.Category, a => a.User)
                : await UnitOfWork.Articles.GetAllAsync(a => a.IsActive && !a.IsDeleted && a.CategoryId == categoryId, a => a.Category, a => a.User);
            var sortedArticles = isAscending
                ? articles.OrderBy(a => a.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : articles.OrderByDescending(a => a.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
            {
                Articles = sortedArticles,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = articles.Count,
                IsAscending = isAscending
            });

        }

        public async Task<IDataResult<ArticleListDto>> SearchAsync(string keyword, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            if (string.IsNullOrWhiteSpace(keyword))
            {              
                var articles = await UnitOfWork.Articles.GetAllAsync(a => a.IsActive && !a.IsDeleted, a => a.Category, a => a.User);                   
                var sortedArticles = isAscending
                    ? articles.OrderBy(a => a.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                    : articles.OrderByDescending(a => a.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = sortedArticles,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalCount = articles.Count,
                    IsAscending = isAscending
                });
            }
            var searchedArticles = await UnitOfWork.Articles.SearchAsync(new List<Expression<Func<Article, bool>>>
            {
                (a)=>a.Title.Contains(keyword),
                (a)=>a.Category.Name.Contains(keyword),
                (a)=>a.SeoDescription.Contains(keyword),
                (a)=>a.SeoTags.Contains(keyword)
            },a=>a.Category,a=>a.User);
            var searcedAndSortedArticles = isAscending
                  ? searchedArticles.OrderBy(a => a.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                  : searchedArticles.OrderByDescending(a => a.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
            {
                Articles = searcedAndSortedArticles,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = searchedArticles.Count,
                IsAscending = isAscending
            });
        }

        public async Task<IResult> IncreaseViewCountAsync(int articleId)
        {
            var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);
            if(article == null)
            {
                return new Result(ResultStatus.Error, Messages.Article.NotFound(false));
            }
            article.ViewsCount += 1;
            await UnitOfWork.Articles.UpdateAsync(article);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Article.IncreaseViewCount(article.Title));
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByUserIdOnFilter(
            int userId, FilterBy filterBy, OrderBy orderBy, bool isAscending, 
            int takeSize, int categoryId, DateTime startAt, DateTime endAt,
            int minViewCount, int maxViewCount, int minCommentCount, int maxCommentCount)
        {
            var anyUser = await _userManager.Users.AnyAsync(u => u.Id == userId);
            if (!anyUser)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, 
                    $"{userId} numaralı kullanıcı bulunamadı.", null);

            }
            var userArticles = await UnitOfWork.Articles.GetAllAsync(a => a.IsActive && !a.IsDeleted && a.UserId == userId);
            List<Article> sortedArticles = new List<Article>();
            switch (filterBy)
            {
                case FilterBy.Category:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                            sortedArticles = isAscending
                                ? userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize).OrderBy(a => a.Date).ToList()
                                : userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize).OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize).OrderBy(a => a.ViewsCount).ToList()
                               : userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize).OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize).OrderBy(a => a.CommentCount).ToList()
                               : userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize).OrderByDescending(a => a.CommentCount).ToList();
                            break;
                    }
                    break;
                case FilterBy.Date:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                            sortedArticles = isAscending
                                ? userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize).OrderBy(a => a.Date).ToList()
                                : userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize).OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize).OrderBy(a => a.ViewsCount).ToList()
                               : userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize).OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize).OrderBy(a => a.CommentCount).ToList()
                               : userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize).OrderByDescending(a => a.CommentCount).ToList();
                            break;
                    }
                    break;
                case FilterBy.ViewCount:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                            sortedArticles = isAscending
                                ? userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize).OrderBy(a => a.Date).ToList()
                                : userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize).OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize).OrderBy(a => a.ViewsCount).ToList()
                               : userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize).OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize).OrderBy(a => a.CommentCount).ToList()
                               : userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize).OrderByDescending(a => a.CommentCount).ToList();
                            break;
                    }
                    break;
                case FilterBy.CommentCount:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                            sortedArticles = isAscending
                                ? userArticles.Where(a => a.CommentCount >= minCommentCount && a.CommentCount <= maxCommentCount).Take(takeSize).OrderBy(a => a.Date).ToList()
                                : userArticles.Where(a => a.CommentCount >= minCommentCount && a.CommentCount <= maxCommentCount).Take(takeSize).OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.CommentCount >= minCommentCount && a.CommentCount <= maxCommentCount).Take(takeSize).OrderBy(a => a.ViewsCount).ToList()
                               : userArticles.Where(a => a.CommentCount >= minCommentCount && a.CommentCount <= maxCommentCount).Take(takeSize).OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending
                               ? userArticles.Where(a => a.CommentCount >= minCommentCount && a.CommentCount <= maxCommentCount).Take(takeSize).OrderBy(a => a.CommentCount).ToList()
                               : userArticles.Where(a => a.CommentCount >= minCommentCount && a.CommentCount <= maxCommentCount).Take(takeSize).OrderByDescending(a => a.CommentCount).ToList();
                            break;
                    }
                    break;
            }
            return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
            {
                Articles = sortedArticles
            });
        }

        public async Task<IDataResult<ArticleDto>> GetByIdAsync(int articleId, bool includeCategory, bool includeComments, bool includeUser)
        {
            List<Expression<Func<Article, bool>>> predicates = new List<Expression<Func<Article, bool>>>();
            List<Expression<Func<Article, object>>> includes = new List<Expression<Func<Article, object>>>();
            if (includeCategory) includes.Add(a => a.Category);
            if (includeComments) includes.Add(a => a.Comments);
            if (includeUser) includes.Add(a => a.User);
            predicates.Add(a => a.Id == articleId);
            var article = await UnitOfWork.Articles.GetAllAsyncV2(predicates, includes);
            if (article == null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Warning, Messages.General.ValidationError(),
                    null, new List<ValidationError>
                    {
                        new ValidationError
                        {
                            PropertyName = "articleId",
                            Message=Messages.Article.NotFoundById(articleId)
                        }
                    });
                
            }
            return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
            {
                Article = (Article)article
            });
        }

        public async Task<IDataResult<ArticleListDto>> GetAllAsyncV2(int? categoryId, int? userId, 
            bool? isActive, bool? isDeleted, int currentPage, int pageSize, OrderByGeneral orderBy,
            bool isAscending, bool includeCategory, bool includeComments, bool includeUser)
        {
            List<Expression<Func<Article, bool>>> predicates = new List<Expression<Func<Article, bool>>>();
            List<Expression<Func<Article, object>>> includes = new List<Expression<Func<Article, object>>>();
            //predicate
            if (categoryId.HasValue)
            {
                if(!await UnitOfWork.Categories.AnyAsync(c => c.Id == categoryId.Value))
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Warning, Messages.General.ValidationError(),
                   null, new List<ValidationError>
                   {
                        new ValidationError
                        {
                            PropertyName = "categoryId",
                            Message=Messages.Category.NotFoundById(categoryId.Value)
                        }
                   });
                }
                predicates.Add(a=>a.CategoryId==categoryId.Value);
            }
            if (userId.HasValue)
            {
                if (!await _userManager.Users.AnyAsync(u=>u.Id==userId.Value))
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Warning, Messages.General.ValidationError(),
                   null, new List<ValidationError>
                   {
                        new ValidationError
                        {
                            PropertyName = "userId",
                            Message=Messages.User.NotFoundById(userId.Value)
                        }
                   });
                }
                predicates.Add(a => a.UserId == userId.Value);
            }
            if(isActive.HasValue)predicates.Add(a=>a.IsActive==isActive.Value);
            if (isDeleted.HasValue) predicates.Add(a => a.IsDeleted == isDeleted.Value);
            //includes
            if (includeCategory) includes.Add(a => a.Category);
            if (includeComments) includes.Add(a => a.Comments);
            if (includeUser) includes.Add(a => a.User);

            var articles = await UnitOfWork.Articles.GetAllAsyncV2(predicates, includes);
            IOrderedEnumerable<Article> sortedArticles;

            switch (orderBy)
            {
                case OrderByGeneral.Id:
                    sortedArticles = isAscending? articles.OrderBy(a => a.Id): articles.OrderByDescending(a => a.Id);
                    break;
                case OrderByGeneral.Az:
                    sortedArticles = isAscending ? articles.OrderBy(a => a.Title) : articles.OrderByDescending(a => a.Title);
                    break;
                //Default CreatedDate
                default:
                    sortedArticles = isAscending ? articles.OrderBy(a => a.CreateDate) : articles.OrderByDescending(a => a.CreateDate);
                    break;
            }
            return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
            {
                Articles = sortedArticles.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList(),
                CategoryId = categoryId.HasValue ? categoryId.Value : null,
                CurrentPage = currentPage,
                PageSize = pageSize,
                IsAscending = isAscending,
                TotalCount = articles.Count,
                ResultStatus = ResultStatus.Success
            });

        }
    }
}
