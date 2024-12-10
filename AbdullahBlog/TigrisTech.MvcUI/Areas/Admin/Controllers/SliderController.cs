using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Text.Json;
using System.Threading.Tasks;
using TigrisTech.Entities.ComplexTypes;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Editor.Sliders;
using TigrisTech.MvcUI.Helpers.Abstract;
using TigrisTech.MvcUI.Models.Slider;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Extensions;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : BaseController
    {
        private readonly ISliderService _sliderService;
        private readonly IToastNotification _toastNotification;
        public SliderController(UserManager<User> userManager, IMapper mapper, IImageHelper imageHelpper,
            ISliderService sliderService,
            IToastNotification toastNotification) : base(userManager, mapper, imageHelpper)
        {
            _sliderService = sliderService;
            _toastNotification = toastNotification;
        }
        [Authorize(Roles = "SuperAdmin,Slider.Read")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.MenuOpenSlider = "menu-open";
            ViewBag.MenuActiveSlider = "active";
            ViewBag.SubActiveSlider = "active";
            var result = await _sliderService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = "SuperAdmin,Slider.Create")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return PartialView("_SliderAddPartial");
        }
        [Authorize(Roles = "SuperAdmin,Slider.Create")]
        [HttpPost]
        public async Task<IActionResult> Add(SliderAddDto sliderAddDto)
        {
            if (ModelState.IsValid)
            {
                var uploadedImageDtoResult = await ImageHelpper.UploadTask(sliderAddDto.Title, sliderAddDto.PictureFile, PictureType.Slider);
                sliderAddDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success
                                                                          ? uploadedImageDtoResult.Data.FullName
                                                                          : "sliderImage/defaultSlider.png";
                var result = await _sliderService.AddAsync(sliderAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var sliderAddAjaxModel = JsonSerializer.Serialize(new SliderAddAjaxViewModel
                    {
                        SliderDto = result.Data,
                        SliderAddPartial = await this.RenderViewToStringAsync("_SliderAddPartial", sliderAddDto)
                    });
                    return Json(sliderAddAjaxModel);
                }
            }
            var sliderAjaxErrrorModel = JsonSerializer.Serialize(new SliderAddAjaxViewModel
            {
                SliderAddPartial = await this.RenderViewToStringAsync("_SliderAddPartial", sliderAddDto)
            });
            return Json(sliderAjaxErrrorModel);
        }
        [Authorize(Roles = "SuperAdmin,Slider.Update")]
        [HttpGet]
        public async Task<IActionResult> Update(int sliderId)
        {
            var slider = await _sliderService.GetSliderUpdateDtoAsync(sliderId);
            if (slider.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_SliderUpdatePartial", slider.Data);
            }
            else
            {
                return NotFound();
            }

        }
        [Authorize(Roles = "SuperAdmin,Slider.Update")]
        [HttpPost]
        public async Task<IActionResult> Update(SliderUpdateDto sliderUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldSliders = await _sliderService.GetAsync(sliderUpdateDto.Id);
                var oldSliderPicture = oldSliders.Data.Slider.Picture;
                if (sliderUpdateDto.PictureFile != null)
                {
                    var uploadedImageDtoResult = await ImageHelpper.UploadTask(sliderUpdateDto.Title, sliderUpdateDto.PictureFile, PictureType.Slider);
                    sliderUpdateDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success
                                                                              ? uploadedImageDtoResult.Data.FullName
                                                                              : "sliderImage/defaultSlider.png";
                    if (oldSliderPicture != "sliderImage/defaultSlider.png")
                    {
                        isNewPictureUploaded = true;
                    }
                }
                var result = await _sliderService.UpdateAsync(sliderUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isNewPictureUploaded)
                    {
                        ImageHelpper.Delete(oldSliderPicture);
                    }
                    var sliderUpdateAjaxViewModel = JsonSerializer.Serialize(new SliderUpdateAjaxViewModel
                    {
                        SliderDto = result.Data,
                        SliderUpdatePartial = await this.RenderViewToStringAsync("_SliderUpdataPartial", sliderUpdateDto)
                    });
                    return Json(sliderUpdateAjaxViewModel);
                }
                else
                {
                    var sliderUpdateModalStateErrorViewModel = JsonSerializer.Serialize(new SliderUpdateAjaxViewModel
                    {
                        SliderUpdateDto = sliderUpdateDto,
                        SliderUpdatePartial = await this.RenderViewToStringAsync("_SliderUpdatePartial", sliderUpdateDto)
                    });
                    return Json(sliderUpdateModalStateErrorViewModel);

                }
            }
            else
            {
                var sliderUpdateModalStateErrorViewModel = JsonSerializer.Serialize(new SliderUpdateAjaxViewModel
                {
                    SliderUpdateDto = sliderUpdateDto,
                    SliderUpdatePartial = await this.RenderViewToStringAsync("_SliderUpdatePartial", sliderUpdateDto)
                });
                return Json(sliderUpdateModalStateErrorViewModel);
            }
        }
        [Authorize(Roles = "SuperAdmin,Slider.Delete")]
        [HttpPost]
        public async Task<JsonResult> HardDelete(int sliderId)
        {
            var slider = await _sliderService.GetAsync(sliderId);
            var result = await _sliderService.HardDeleteAsync(sliderId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                if (slider.Data.Slider.Picture != "sliderImages/defaultSlider.png")
                {
                    ImageHelpper.Delete(slider.Data.Slider.Picture);
                }
            }
            var hardDeletedArticleResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedArticleResult);
        }
        [Authorize(Roles = "SuperAdmin,Slider.Read")]
        [HttpGet]
        public async Task<IActionResult> DeletedSliders()
        {
            ViewBag.MenuOpenDeletedPatients = "menu-open";
            ViewBag.MenuActiveDeletedPatients = " active";
            ViewBag.SubActiveDeletedSliders = " active";
            var result = await _sliderService.GetAllByDeletedAsync();
            return View(result.Data);
        }
        [Authorize(Roles = "SuperAdmin,Slider.Read")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int sliderId)
        {
            var result = await _sliderService.UndoDeleteAsync(sliderId, LoggedInUser.UserName);
            var undoDeleteSliderResult = JsonSerializer.Serialize(result);
            return Json(undoDeleteSliderResult);
        }
    }
}
