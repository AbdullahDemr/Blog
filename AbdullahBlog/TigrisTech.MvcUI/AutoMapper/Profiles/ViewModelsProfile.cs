using AutoMapper;
using TigrisTech.Entities.Concrete.JsonTable;
using TigrisTech.Entities.Dtos.Blog;
using TigrisTech.MvcUI.Areas.Admin.Models;
using TigrisTech.MvcUI.Areas.Admin.Models.Blogs;
using TigrisTech.MvcUI.Helpers.Abstract;

namespace TigrisTech.Mvc.AutoMapper.Profiles
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile(IImageHelper imageHelper)
        {
            CreateMap<ArticleAddViewModel, ArticleAddDto>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleUpdateViewModel>().ReverseMap();
            CreateMap<ArticleRightSideBarWidgetOptions, ArticleRightSideBarWidgetOptionsViewModel>();
        }
    }
}
