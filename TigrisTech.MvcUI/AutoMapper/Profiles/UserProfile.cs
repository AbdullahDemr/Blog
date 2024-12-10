using AutoMapper;
using TigrisTech.Entities.ComplexTypes;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Users;
using TigrisTech.MvcUI.Helpers.Abstract;

namespace TigrisTech.Mvc.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile(IImageHelper imageHelper)
        {
            CreateMap<UserAddDto, User>()
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(x => imageHelper.Upload(x.UserName, x.PictureFile, PictureType.User, null)));
            CreateMap<User, UserUpdateDto>().ReverseMap() //ReverseMap ile tersini de yapar;
                 .ForMember(dest => dest.Picture, opt => opt.MapFrom(x => imageHelper.Upload(x.UserName, x.PictureFile, PictureType.User, null)));
            CreateMap<UserUpdateDto, User>();


        }
    }
}
