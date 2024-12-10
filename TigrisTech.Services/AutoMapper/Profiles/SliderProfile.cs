using AutoMapper;
using System;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Dtos.Editor.Sliders;

namespace TigrisTech.Services.AutoMapper.Profiles
{
    public class SliderProfile : Profile
    {
        public SliderProfile()
        {
            CreateMap<SliderAddDto, Slider>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Slider, SliderUpdateDto>();
            CreateMap<SliderUpdateDto, Slider>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
