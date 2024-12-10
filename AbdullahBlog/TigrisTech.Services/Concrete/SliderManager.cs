using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Dtos.Editor.Sliders;
using TigrisTech.Services.Abstract;
using TigrisTech.Services.Utilities;
using TigrisTech.Shared.Utilities.Results.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;
using TigrisTech.Shared.Utilities.Results.Concrete;

namespace TigrisTech.Services.Concrete
{
    public class SliderManager :ManagerBase, ISliderService
    {
        public SliderManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<IDataResult<SliderDto>> GetAsync(int sliderId)
        {
            var slider = await UnitOfWork.Sliders.GetAsync(s => s.Id == sliderId);
            if(slider != null)
            {
                return new DataResult<SliderDto>(ResultStatus.Success, new SliderDto
                {
                    Slider = slider,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SliderDto>(ResultStatus.Error, "Böyle bir slider bulunamadı.", null);

        }
        public async Task<IDataResult<SliderListDto>> GetAllAsync()
        {
            var sliders = await UnitOfWork.Sliders.GetAllAsync();
            if(sliders != null)
            {
                return new DataResult<SliderListDto>(ResultStatus.Success, new SliderListDto
                {
                    Sliders = sliders,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SliderListDto>(ResultStatus.Error, "Herhangi bir slider bulunamadı.", null);
        }
        public async Task<IDataResult<SliderDto>> AddAsync(SliderAddDto sliderAddDto, string createByName)
        {
            var slider = Mapper.Map<Slider>(sliderAddDto);
            slider.CreateByName = createByName;
            slider.ModifiedByName = createByName;
            var addedSlider = await UnitOfWork.Sliders.AddSync(slider);
            await UnitOfWork.SaveAsync();
            return new DataResult<SliderDto>(ResultStatus.Success, Messages.Slider.Add(addedSlider.Title), new SliderDto
            {
                Slider = addedSlider,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Slider.Add(addedSlider.Title)
            });
        }
        public async Task<IResult> HardDeleteAsync(int sliderId)
        {
            var slider = await UnitOfWork.Sliders.GetAsync(c => c.Id == sliderId);
            if(slider != null)
            {
                await UnitOfWork.Sliders.DeleteAsync(slider);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Slider.HardDelete(slider.Title));
            }
            return new Result(ResultStatus.Success, Messages.Slider.NotFound(isPlural: true));
        }
        public async Task<IDataResult<SliderDto>> UpdateAsync(SliderUpdateDto sliderUpdateDto, string modifiedByName)
        {
            var oldSlider = await UnitOfWork.Sliders.GetAsync(s => s.Id == sliderUpdateDto.Id);
     
            var slider = Mapper.Map<SliderUpdateDto, Slider>(sliderUpdateDto, oldSlider);
            slider.ModifiedByName = modifiedByName;
            var updateSlider= await UnitOfWork.Sliders.UpdateAsync(slider);
            await UnitOfWork.SaveAsync();
            return new DataResult<SliderDto>(ResultStatus.Success, Messages.Slider.Update(updateSlider.Title), new SliderDto
            {
                Slider = updateSlider,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Slider.Update(updateSlider.Title)
            }); 
        }

        public async Task<IDataResult<SliderUpdateDto>> GetSliderUpdateDtoAsync(int sliderId)
        {
            var result = await UnitOfWork.Sliders.AnyAsync(s => s.Id == sliderId);
            if (result)
            {
                var slider = await UnitOfWork.Sliders.GetAsync(c => c.Id == sliderId);
                var sliderUpdateDto = Mapper.Map<SliderUpdateDto>(slider);
                return new DataResult<SliderUpdateDto>(ResultStatus.Success, sliderUpdateDto);
            }
            else
            {
                return new DataResult<SliderUpdateDto>(ResultStatus.Error, Messages.Slider.NotFound(isPlural: false), null);
            }
        }

        public async Task<IDataResult<SliderListDto>> GetAllByDeletedAsync()
        {
            var sliders = await UnitOfWork.Sliders.GetAllAsync(s=>s.IsDeleted);
            if (sliders.Count > -1)
            {
                return new DataResult<SliderListDto>(ResultStatus.Success, new SliderListDto
                {
                    Sliders = sliders,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SliderListDto>(ResultStatus.Error, Messages.Slider.NotFound(isPlural: false), new SliderListDto
            {
                Sliders = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Slider.NotFound(isPlural: false)
            });
        }
        public async Task<IResult> UndoDeleteAsync(int sliderId, string modifiedByName)
        {
            var result = await UnitOfWork.Sliders.AnyAsync(a => a.Id == sliderId);
            if (result)
            {
                var slider = await UnitOfWork.Sliders.GetAsync(a => a.Id == sliderId);
                slider.IsDeleted = false;
                slider.IsActive = true;
                slider.ModifiedByName = modifiedByName;
                slider.ModifiedDate = DateTime.Now;
                await UnitOfWork.Sliders.UpdateAsync(slider);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Slider.UndoDelete(slider.Title));
            }
            return new Result(ResultStatus.Error, Messages.Article.NotFound(false));
        }
        public async Task<IDataResult<SliderListDto>> GetAllByNonDeletedAsync()
        {
            var articles = await UnitOfWork.Sliders.GetAllAsync(a => !a.IsDeleted);
            if (articles.Count > -1)
            {
                return new DataResult<SliderListDto>(ResultStatus.Success, new SliderListDto
                {
                    Sliders = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SliderListDto>(ResultStatus.Error, "Makaleler bulunamadı.", null);
        }
    }
}
