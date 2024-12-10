using AutoMapper;
using System;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Dtos.Editor.Profils;

namespace TigrisTech.Services.AutoMapper.Profiles
{
    public class ProfilProfile : Profile
    {
        public ProfilProfile()
        {
            CreateMap<ProfilAddDto, Profil>()
               .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Profil, ProfilUpdateDto>();
            CreateMap<ProfilUpdateDto, Profil>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now)); ;
        }
    }
}
