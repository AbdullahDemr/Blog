using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Dtos.Blog;
using TigrisTech.Entities.Dtos.Editor.References;

namespace TigrisTech.Services.AutoMapper.Profiles
{
    public class DoctorProfile:Profile
    {
        public DoctorProfile()
        {
            CreateMap<TeamAddDto, Doctor>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<TeamUpdateDto, Doctor>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Doctor, TeamUpdateDto>();
        }
    }
}
