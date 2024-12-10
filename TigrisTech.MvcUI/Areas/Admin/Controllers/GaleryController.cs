using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;
using TigrisTech.Entities.ComplexTypes;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Editor.Galeries;
using TigrisTech.MvcUI.Areas.Admin.Controllers;
using TigrisTech.MvcUI.Helpers.Abstract;
using TigrisTech.MvcUI.Models.Galery;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Extensions;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GaleryController : BaseController
    {
        private readonly IGaleryService _galeryService;

        public GaleryController(UserManager<User> userManager, IMapper mapper, IImageHelper imageHelpper,
            IGaleryService galeryService) : base(userManager, mapper, imageHelpper)
        {
            _galeryService = galeryService;
        }
        [Authorize(Roles = "SuperAdmin,Galery.Read")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.MenuOpenSlider = "menu-open";
            ViewBag.MenuActiveSlider = "active";
            ViewBag.SubActiveGalery = "active";
            var sliders = await _galeryService.GetAllAsync();
            return View(sliders.Data);
        }
        [Authorize(Roles = "SuperAdmin,Galery.Create")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return PartialView("_GaleryAddPartial");
        }
        [Authorize(Roles = "SuperAdmin,Galery.Create")]
        [HttpPost]
        public async Task<IActionResult> Add(GaleryAddDto galeryAddDto)
        {
            if (ModelState.IsValid)
            {
                var uploadedImageDtoResult = await ImageHelpper.UploadTask(galeryAddDto.Title, galeryAddDto.PictureFile, PictureType.Galery);
                galeryAddDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success
                                                                          ? uploadedImageDtoResult.Data.FullName
                                                                          : "galeryImage/defaultGalery.png";
                var result = await _galeryService.AddAsync(galeryAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var sliderAddAjaxModel = JsonSerializer.Serialize(new GaleryAddAjaxViewModel
                    {
                        GaleryDto = result.Data,
                        GaleryAddPartial = await this.RenderViewToStringAsync("_GaleryAddPartial", galeryAddDto)
                    });
                    return Json(sliderAddAjaxModel);
                }
            }
            var sliderAjaxErrrorModel = JsonSerializer.Serialize(new GaleryAddAjaxViewModel
            {
                GaleryAddPartial = await this.RenderViewToStringAsync("_GaleryAddPartial", galeryAddDto)
            });
            return Json(sliderAjaxErrrorModel);
        }
        [Authorize(Roles = "SuperAdmin,Galery.Update")]
        [HttpGet]
        public async Task<IActionResult> Update(int galeryId)
        {
            var galery = await _galeryService.GetGaleryUpdateDtoAsync(galeryId);
            if (galery.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_GaleryUpdatePartial", galery.Data);
            }
            else
            {
                return NotFound();
            }

        }
        [Authorize(Roles = "SuperAdmin,Galery.Update")]
        [HttpPost]
        public async Task<IActionResult> Update(GaleryUpdateDto galeryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldGalerys = await _galeryService.GetAsync(galeryUpdateDto.Id);
                var oldSliderPicture = oldGalerys.Data.Galery.Picture;
                if (galeryUpdateDto.PictureFile != null)
                {
                    var uploadedImageDtoResult = await ImageHelpper.UploadTask(galeryUpdateDto.Title, galeryUpdateDto.PictureFile, PictureType.Galery);
                    galeryUpdateDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success
                                                                              ? uploadedImageDtoResult.Data.FullName
                                                                              : "galeryImage/defaultGalery.png";
                    if (oldSliderPicture != "galeryImage/defaultGalery.png")
                    {
                        isNewPictureUploaded = true;
                    }
                }
                var result = await _galeryService.UpdateAsync(galeryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isNewPictureUploaded)
                    {
                        ImageHelpper.Delete(oldSliderPicture);
                    }
                    var sliderUpdateAjaxViewModel = JsonSerializer.Serialize(new GaleryUpdateAjaxViewModel
                    {
                        GaleryDto = result.Data,
                        GaleryUpdatePartial = await this.RenderViewToStringAsync("_GaleryUpdatePartial", galeryUpdateDto)
                    });
                    return Json(sliderUpdateAjaxViewModel);
                }
                else
                {
                    var sliderUpdateModalStateErrorViewModel = JsonSerializer.Serialize(new GaleryUpdateAjaxViewModel
                    {
                        GaleryUpdateDto = galeryUpdateDto,
                        GaleryUpdatePartial = await this.RenderViewToStringAsync("_GaleryUpdatePartial", galeryUpdateDto)
                    });
                    return Json(sliderUpdateModalStateErrorViewModel);

                }
            }
            else
            {
                var sliderUpdateModalStateErrorViewModel = JsonSerializer.Serialize(new GaleryUpdateAjaxViewModel
                {
                    GaleryUpdateDto = galeryUpdateDto,
                    GaleryUpdatePartial = await this.RenderViewToStringAsync("_GaleryUpdatePartial", galeryUpdateDto)
                });
                return Json(sliderUpdateModalStateErrorViewModel);
            }
        }
        [Authorize(Roles = "SuperAdmin,Galery.Delete")]
        [HttpPost]
        public async Task<JsonResult> HardDelete(int galeryId)
        {
            var galery = await _galeryService.GetAsync(galeryId);
            var result = await _galeryService.HardDeleteAsync(galeryId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                if (galery.Data.Galery.Picture != "galeryImages/defaultGalery.png")
                {
                    ImageHelpper.Delete(galery.Data.Galery.Picture);
                }
            }
            var hardDeletedArticleResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedArticleResult);
        }
    }
}

