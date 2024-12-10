using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.ComplexTypes;
using TigrisTech.Entities.Dtos.Blog;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> GetAsync(int articleId);
        Task<IDataResult<ArticleDto>> GetByIdAsync(int articleId,bool includeCategory,bool includeComments,bool includeUser);
        Task<IDataResult<ArticleUpdateDto>> GetArticleUpdateDtoAsync(int articleId);
        Task<IDataResult<ArticleListDto>> GetAllAsync();
        Task<IDataResult<ArticleListDto>> GetAllAsyncV2(int? categoryId, int? userId,bool? isActive,
            bool? isDeleted,int currentPage,int pageSize,OrderByGeneral orderBy,bool isAscending,
            bool includeCategory, bool includeComments, bool includeUser);
        //Silinmemiş tüm kategorileri bana getir.
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAsync();
        //Hem silinmemiş hemde aktif Articler listelenecek
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<ArticleListDto>> GetAllCategoryAsync(int categoryId);
        Task<IDataResult<ArticleListDto>> GetAllByDeletedAsync();
        Task<IDataResult<ArticleListDto>> GetAllByViewCountAsync(bool isAccending, int? takeSize);
        Task<IDataResult<ArticleListDto>> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 5, bool isAscending = false);
        //Dto Veri Transfer Objesi
        Task<IDataResult<ArticleListDto>> GetAllByUserIdOnFilter(int userId, 
            FilterBy filterBy, OrderBy orderBy, bool isAscending, 
            int takeSize, int category, DateTime startAt, 
            DateTime endAt, int minViewCount, int maxViewCount, 
            int minCommentCount, int maxCommentCount);
        Task<IDataResult<ArticleListDto>> SearchAsync(string keyword, int currentPage = 1, int pageSize = 5, bool isAscending = false);
        Task<IResult> IncreaseViewCountAsync(int articleId);
        Task<IResult> AddAsync(ArticleAddDto articleAddDto, string createByName, int userId);
        Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int articleyId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int articleId);
        Task<IResult> UndoDeleteAsync(int articleId, string modifiedByName);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
