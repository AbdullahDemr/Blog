using AutoMapper;
using System;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Entities.Dtos.Blog;

namespace TigrisTech.Services.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Article, ArticleUpdateDto>();
        }
    }
}
