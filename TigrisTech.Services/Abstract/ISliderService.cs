using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Dtos.Editor.Sliders;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.Services.Abstract
{
    public interface ISliderService
    {
        Task<IDataResult<SliderDto>> GetAsync(int sliderId);
        Task<IDataResult<SliderListDto>> GetAllAsync();
        Task<IDataResult<SliderDto>> AddAsync(SliderAddDto sliderAddDto, string createByName);
        Task<IDataResult<SliderDto>> UpdateAsync(SliderUpdateDto sliderUpdateDto, string modifiedByName);
        Task<IDataResult<SliderUpdateDto>> GetSliderUpdateDtoAsync(int sliderId);
        //Silinmiş tüm değerler listele
        Task<IDataResult<SliderListDto>> GetAllByDeletedAsync();
        Task<IResult> UndoDeleteAsync(int sliderId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int sliderId);
        Task<IDataResult<SliderListDto>> GetAllByNonDeletedAsync(); 
    }
}
