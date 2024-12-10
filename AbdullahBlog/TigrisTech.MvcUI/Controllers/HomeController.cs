
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NToastNotify;
using System;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete;
using TigrisTech.Entities.Concrete.JsonTable;
using TigrisTech.Entities.Dtos.Editor.Emails;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Helpers.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

namespace TigrisTech.MvcUI.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly AboutUsPageInfo _aboutUsPageInfo;
        private readonly IWritableOptions<AboutUsPageInfo> _aboutUsPageInWriter;
        private readonly ContactPageInfo _contactPageInfo;
        private readonly IWritableOptions<ContactPageInfo> _contactPageInWriter;

        private readonly IMailService _mailService;
        private readonly IToastNotification _toastNotification;
        
        private readonly ISliderService _sliderService;
        private readonly IProfilService _profilService;
        private readonly IGaleryService _galeryService;
        public HomeController(IArticleService articleService,
            IOptionsSnapshot<AboutUsPageInfo> aboutUsPageInfo,
            IOptionsSnapshot<ContactPageInfo> contactPageInfo,
            IMailService mailService,
            IToastNotification toastNotification,
            IWritableOptions<AboutUsPageInfo> aboutUsPageInWriter,
            
            IWritableOptions<ContactPageInfo> contactPageInWriter,
            ISliderService sliderService,
            IProfilService profilService,
            IGaleryService galeryService)
        {
            _contactPageInfo = contactPageInfo.Value;
            _contactPageInWriter = contactPageInWriter;
            _articleService = articleService;
            _aboutUsPageInfo = aboutUsPageInfo.Value;
            _mailService = mailService;
            _toastNotification = toastNotification;
            _aboutUsPageInWriter = aboutUsPageInWriter;

            _sliderService = sliderService;
            _profilService = profilService;
            _galeryService = galeryService;
        }
        [Route("index")]
        [Route("anasayfa")]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.HomeActive = "active";
            ViewBag.Video = _contactPageInfo.GitHubLink;
            var sliders = await _sliderService.GetAllAsync();
            return View(sliders.Data);
        }
        [Route("hakkimizda-bilgi")]
        [Route("hakkinda")]
        [HttpGet]
        public IActionResult About()
        {
            ViewBag.AboutActive = "active";
            return View(_aboutUsPageInfo);
        }
        [Route("galeri-bilgi")]
        [HttpGet]
        public async Task<IActionResult> Galery()
        {
            ViewBag.GaleryActive = "active";
            var galerys = await _galeryService.GetAllAsync();
            return View(galerys.Data);
        }
        [Route("Doktorlar-bilgi")]
        [HttpGet]
        public async Task<IActionResult> Profil()
        {
            ViewBag.ProfilActive = "active";
            var profils = await _profilService.GetAllAsync();
            return View(profils.Data);
        }
        [Route("blog-bilgi")]
        [HttpGet]
        public async Task<IActionResult> Blog(int? categoryId,
            int currentPage = 1, int pageSize = 5, bool isAccending = false)
        {
            ViewBag.BlogActive = "active";
            var articleResult = await (categoryId == null
                ? _articleService.GetAllByPagingAsync(null, currentPage, pageSize, isAccending)
                : _articleService.GetAllByPagingAsync(categoryId.Value, currentPage, pageSize, isAccending));
            return View(articleResult.Data);
        }
   
        [Route("iletişim-bilgi")]
        [HttpGet]
        public IActionResult Contact()
        {
            ViewBag.ContactActive = "active";
            ViewBag.Contact = _contactPageInfo;
            return View();
        }
 
        [Route("iletişim-bilgi")]
        [HttpPost]
        public  IActionResult ContactSend(EmailSendDto emailSendDto)
        {
            ViewBag.ContactActive = "active";
            if (ModelState.IsValid)
            {
                
                var result = _mailService.SendContactEmail(emailSendDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage("Mesajınız başarıyla iletildi", new ToastrOptions
                    {
                        Title = "Başarılı işlem!"
                    });
                    ViewBag.Contact = _contactPageInfo;
                    return View("Contact");
                }
                else
                {
                    _toastNotification.AddAlertToastMessage("Mesajınız iletilemedi!", new ToastrOptions
                    {
                        Title = "Başarız işlem!"
                    });
                    return View("Contact");
                }        
   
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Hata oluştu!", new ToastrOptions
                {
                    Title = "Başarısız işlem!"
                });
                return RedirectToAction("Contact");
            }
            
        }
       
    }
}
