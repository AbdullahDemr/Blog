using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;
using TigrisTech.Entities.ComplexTypes;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Editor.Profils;
using TigrisTech.MvcUI.Helpers.Abstract;
using TigrisTech.MvcUI.Models.Profil;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Extensions;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfilController : BaseController
    {
        private readonly IProfilService _profilService;

        public ProfilController(UserManager<User> userManager, IMapper mapper, IImageHelper imageHelpper,
            IProfilService profilService) : base(userManager, mapper, imageHelpper)
        {
            _profilService = profilService;
        }
        [Authorize(Roles = "SuperAdmin,Profil.Read")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.MenuOpenSlider = "menu-open";
            ViewBag.MenuActiveSlider = "active";
            ViewBag.SubActiveProfil = "active";
            var profils = await _profilService.GetAllAsync();
            return View(profils.Data);
        }
        [Authorize(Roles = "SuperAdmin,Profil.Create")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return PartialView("_ProfilAddPartial");
        }
        [Authorize(Roles = "SuperAdmin,Profil.Create")]
        [HttpPost]
        public async Task<IActionResult> Add(ProfilAddDto profilAddDto)
        {
            if (ModelState.IsValid)
            {
                var uploadedImageDtoResult = await ImageHelpper.UploadTask(profilAddDto.FirstName, profilAddDto.PictureFile, PictureType.Profil);
                profilAddDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success
                                                                          ? uploadedImageDtoResult.Data.FullName
                                                                          : "profilImage/defaultProfil.png";
                var result = await _profilService.AddAsync(profilAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var sliderAddAjaxModel = JsonSerializer.Serialize(new ProfilAddAjaxViewModel
                    {
                        ProfilDto = result.Data,
                        ProfilAddPartial = await this.RenderViewToStringAsync("_ProfilAddPartial", profilAddDto)
                    });
                    return Json(sliderAddAjaxModel);
                }
            }
            var profilAjaxErrrorModel = JsonSerializer.Serialize(new ProfilAddAjaxViewModel
            {
                ProfilAddPartial = await this.RenderViewToStringAsync("_ProfilAddPartial", profilAddDto)
            });
            return Json(profilAjaxErrrorModel);
        }
        [Authorize(Roles = "SuperAdmin,Profil.Update")]
        [HttpGet]
        public async Task<IActionResult> Update(int profilId)
        {
            var profil = await _profilService.GetProfilUpdateDtoAsync(profilId);
            if (profil.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_ProfilUpdatePartial", profil.Data);
            }
            else
            {
                return NotFound();
            }

        }
        [Authorize(Roles = "SuperAdmin,Profil.Update")]
        [HttpPost]
        public async Task<IActionResult> Update(ProfilUpdateDto profilUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldProfils = await _profilService.GetAsync(profilUpdateDto.Id);
                var oldProfilPicture = oldProfils.Data.Profil.Picture;
                if (profilUpdateDto.PictureFile != null)
                {
                    var uploadedImageDtoResult = await ImageHelpper.UploadTask(profilUpdateDto.FirstName, profilUpdateDto.PictureFile, PictureType.Profil);
                    profilUpdateDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success
                                                                              ? uploadedImageDtoResult.Data.FullName
                                                                              : "profilImage/defaultProfil.png";
                    if (oldProfilPicture != "profilImage/defaultProfil.png")
                    {
                        isNewPictureUploaded = true;
                    }
                }
                var result = await _profilService.UpdateAsync(profilUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isNewPictureUploaded)
                    {
                        ImageHelpper.Delete(oldProfilPicture);
                    }
                    var sliderUpdateAjaxViewModel = JsonSerializer.Serialize(new ProfilUpdateAjaxViewModel
                    {
                        ProfilDto = result.Data,
                        ProfilUpdatePartial = await this.RenderViewToStringAsync("_ProfilUpdatePartial", profilUpdateDto)
                    });
                    return Json(sliderUpdateAjaxViewModel);
                }
                else
                {
                    var profilUpdateModalStateErrorViewModel = JsonSerializer.Serialize(new ProfilUpdateAjaxViewModel
                    {
                        ProfilUpdateDto = profilUpdateDto,
                        ProfilUpdatePartial = await this.RenderViewToStringAsync("_ProfilUpdatePartial", profilUpdateDto)
                    });
                    return Json(profilUpdateModalStateErrorViewModel);

                }
            }
            else
            {
                var profilUpdateModalStateErrorViewModel = JsonSerializer.Serialize(new ProfilUpdateAjaxViewModel
                {
                    ProfilUpdateDto = profilUpdateDto,
                    ProfilUpdatePartial = await this.RenderViewToStringAsync("_ProfilUpdatePartial", profilUpdateDto)
                });
                return Json(profilUpdateModalStateErrorViewModel);
            }
        }
        [Authorize(Roles = "SuperAdmin,Profil.Delete")]
        [HttpPost]
        public async Task<JsonResult> HardDelete(int profilId)
        {
            var profil = await _profilService.GetAsync(profilId);
            var result = await _profilService.HardDeleteAsync(profilId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                if (profil.Data.Profil.Picture != "profilImages/defaultProfil.png")
                {
                    ImageHelpper.Delete(profil.Data.Profil.Picture);
                }
            }
            var hardDeletedArticleResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedArticleResult);
        }
    }
}
