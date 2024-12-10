using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Dtos.Editor.Galeries;

namespace TigrisTech.Services.AutoMapper.Profiles
{
    public class GaleryProfile : Profile
    {
        public GaleryProfile()
        {
            CreateMap<GaleryAddDto, Galery>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Galery, GaleryUpdateDto>();
            CreateMap<GaleryUpdateDto, Galery>()
                .ForMember(dest=>dest.ModifiedDate, opt=>opt.MapFrom(x => DateTime.Now));   
        }
    }
}
