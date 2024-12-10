using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NToastNotify;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.JsonTable;
using TigrisTech.MvcUI.Areas.Admin.Models;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Helpers.Abstract;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OptionsController : Controller
    {
        private readonly AboutUsPageInfo _aboutUsPageInfo;
        private readonly WebsiteInfo _websiteInfo;
        private readonly ContactPageInfo _contactPageInfo;
        private readonly SmtpSetting _smtpSettings;
        private readonly ArticleRightSideBarWidgetOptions _articleRightSideBarWidgetOptions;

        private readonly IWritableOptions<ContactPageInfo> _contactPageInfoWriter;
        private readonly IWritableOptions<AboutUsPageInfo> _aboutUsPageInfoWriter;
        private readonly IWritableOptions<WebsiteInfo> _websiteInfoWriter;
        private readonly IWritableOptions<SmtpSetting> _smtpSettingsWriter;
        private readonly IWritableOptions<ArticleRightSideBarWidgetOptions> _articleRightSideBarWidgetOptionsWriter;

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;

        public OptionsController(IOptionsSnapshot<AboutUsPageInfo> aboutUsPageInfo,
            IOptionsSnapshot<ContactPageInfo> contactPageInfo,
            IWritableOptions<AboutUsPageInfo> aboutUsPageInfoWriter,
            IWritableOptions<ContactPageInfo> contactPageInfoWriter,
            IToastNotification toastNotification,
            IOptionsSnapshot<WebsiteInfo> websiteInfo,
            IWritableOptions<WebsiteInfo> websiteInfoWriter,
            IOptionsSnapshot<SmtpSetting> smtpSettings,
            IWritableOptions<SmtpSetting> smtpSettingsWriter,
            IOptionsSnapshot<ArticleRightSideBarWidgetOptions> articleRightSideBarWidgetOptions,
            IWritableOptions<ArticleRightSideBarWidgetOptions> articleRightSideBarWidgetOptionsWriter,
            ICategoryService categoryService,
            IMapper mapper
            )
        {
            _contactPageInfoWriter = contactPageInfoWriter;
            _aboutUsPageInfoWriter = aboutUsPageInfoWriter;
            _toastNotification = toastNotification;
            _websiteInfoWriter = websiteInfoWriter;
            _smtpSettingsWriter = smtpSettingsWriter;
            _articleRightSideBarWidgetOptionsWriter = articleRightSideBarWidgetOptionsWriter;
            _categoryService = categoryService;
            _mapper = mapper;
            _articleRightSideBarWidgetOptions = articleRightSideBarWidgetOptions.Value;
            _smtpSettings = smtpSettings.Value;
            _websiteInfo = websiteInfo.Value;
            _aboutUsPageInfo = aboutUsPageInfo.Value;
            _contactPageInfo = contactPageInfo.Value;
        }
        [HttpGet]
        public IActionResult About()
        {
            ViewBag.MenuOpenSlider = "menu-open";
            ViewBag.MenuActiveSlider = "active";
            ViewBag.SubActiveAbout = "active";
            return View(_aboutUsPageInfo);
        }
        [HttpPost]
        public IActionResult About(AboutUsPageInfo aboutUsPageInfo)
        {
            ViewBag.MenuOpenSlider = "menu-open";
            ViewBag.MenuActiveSlider = "active";
            ViewBag.SubActiveAbout = "active";
            if (ModelState.IsValid)
            {
                _aboutUsPageInfoWriter.Update(x =>
                {
                    x.Header = aboutUsPageInfo.Header;
                    x.Content = aboutUsPageInfo.Content;
                    x.SeoAuthor = aboutUsPageInfo.SeoAuthor;
                    x.SeoDescription = aboutUsPageInfo.SeoDescription;
                    x.SeoTags = aboutUsPageInfo.SeoTags;
                });
                _toastNotification.AddSuccessToastMessage("Hakkımızda Sayfa İçerikleri başarıyla güncellenmiştir.", new ToastrOptions
                {
                    Title = "Başarılı işlem"
                });
                return View(aboutUsPageInfo);
            }
            return View(aboutUsPageInfo);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            ViewBag.MenuOpenSlider = "menu-open";
            ViewBag.MenuActiveSlider = "active";
            ViewBag.SubActiveContact = "active";
            return View(_contactPageInfo);
        }
        [HttpPost]
        public IActionResult Contact(ContactPageInfo contactPageInfo)
        {
            ViewBag.MenuOpenSlider = "menu-open";
            ViewBag.MenuActiveSlider = "active";
            ViewBag.SubActiveContact = "active";
            if (ModelState.IsValid)
            {
                _contactPageInfoWriter.Update(x =>
                {
                    x.PhoneNumber = contactPageInfo.PhoneNumber;
                    x.Address = contactPageInfo.Address;
                    x.About = contactPageInfo.About;
                    x.MapArea = contactPageInfo.MapArea;
                    x.Email = contactPageInfo.Email;
                    x.TwitterLink = contactPageInfo.TwitterLink;
                    x.FacebookLink = contactPageInfo.FacebookLink;
                    x.InstagramLink = contactPageInfo.InstagramLink;
                    x.LinkedInLink = contactPageInfo.LinkedInLink;
                    x.YoutubeLink = contactPageInfo.YoutubeLink;
                    x.GitHubLink = contactPageInfo.GitHubLink;
                    x.WebsiteLink = contactPageInfo.WebsiteLink;
                });
                _toastNotification.AddSuccessToastMessage("İletişim Sayfa İçeriği başarıyla güncellenmiştir.", new ToastrOptions
                {
                    Title = "Başarılı işlem"
                });
                return View(contactPageInfo);
            }
            return View(contactPageInfo);
        }
        [HttpGet]
        public IActionResult GeneralSettings()
        {
            ViewBag.MenuOpenGeneralSettings = "menu-open";
            ViewBag.MenuActiveGeneralSettings = "active";
            ViewBag.SubActiveGeneralSettings = "active";
            return View(_websiteInfo);
        }
        [HttpPost]
        public IActionResult GeneralSettings(WebsiteInfo websitemInfo)
        {
            ViewBag.MenuOpenGeneralSettings = "menu-open";
            ViewBag.MenuActiveGeneralSettings = "active";
            ViewBag.SubActiveGeneralSettings = "active";
            if (ModelState.IsValid)
            {
                _websiteInfoWriter.Update(x =>
                {
                    x.Title = websitemInfo.Title;
                    x.MenuTitle = websitemInfo.MenuTitle;
                    x.SeoAuthor = websitemInfo.SeoAuthor;
                    x.SeoDescription = websitemInfo.SeoDescription;
                    x.SeoTags = websitemInfo.SeoTags;
                });
                _toastNotification.AddSuccessToastMessage("Sitenizin genel ayarları başarıyla güncellenmiştir.", new ToastrOptions
                {
                    Title = "Başarılı işlem"
                });
                return View(websitemInfo);
            }
            return View(websitemInfo);
        }
        [HttpGet]
        public IActionResult EmailSettings()
        {
            ViewBag.MenuOpenUser = "menu-open";
            ViewBag.MenuActiveUser = "active";
            ViewBag.SubActiveEmailSettings = "active";
            return View(_smtpSettings);
        }
        [HttpPost]
        public IActionResult EmailSettings(SmtpSetting smtpSetting)
        {
            ViewBag.MenuOpenUser = "menu-open";
            ViewBag.MenuActiveUser = "active";
            ViewBag.SubActiveEmailSettings = "active";
            if (ModelState.IsValid)
            {
                _smtpSettingsWriter.Update(x =>
                {
                    x.Server = smtpSetting.Server;
                    x.Port = smtpSetting.Port;
                    x.SenderName = smtpSetting.SenderName;
                    x.SenderEmail = smtpSetting.SenderEmail;
                    x.UserName = smtpSetting.UserName;
                    x.Password = smtpSetting.Password;
                });
                _toastNotification.AddSuccessToastMessage("Sitenizin e-posta ayarları başarıyla güncellenmiştir.", new ToastrOptions
                {
                    Title = "Başarılı işlem"
                });
                return View(smtpSetting);
            }
            return View(smtpSetting);
        }
        [HttpGet]
        public async Task<IActionResult> ArticleRighSideBarWidgetSettings()
        {
            ViewBag.MenuOpenGeneralSettings = "menu-open";
            ViewBag.MenuActiveGeneralSettings = "active";
            ViewBag.SubActiveArticleRighSideBarWidgetSettings = "active";
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            var articleRightSideBarWidgetOptionsViewModel = _mapper.Map<ArticleRightSideBarWidgetOptionsViewModel>(_articleRightSideBarWidgetOptions);
            articleRightSideBarWidgetOptionsViewModel.Categories = categoriesResult.Data.Categories;
            return View(articleRightSideBarWidgetOptionsViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ArticleRighSideBarWidgetSettings(ArticleRightSideBarWidgetOptionsViewModel articleRightSideBarWidgetOptionsViewModel)
        {
            ViewBag.MenuOpenGeneralSettings = "menu-open";
            ViewBag.MenuActiveGeneralSettings = "active";
            ViewBag.SubActiveArticleRighSideBarWidgetSettings = "active";
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            articleRightSideBarWidgetOptionsViewModel.Categories = categoriesResult.Data.Categories;
            if (ModelState.IsValid)
            {
                _articleRightSideBarWidgetOptionsWriter.Update(x =>
                {
                    x.Header = articleRightSideBarWidgetOptionsViewModel.Header;
                    x.TakeSize = articleRightSideBarWidgetOptionsViewModel.TakeSize;
                    x.CategoryId = articleRightSideBarWidgetOptionsViewModel.CategoryId;
                    x.FilterBy = articleRightSideBarWidgetOptionsViewModel.FilterBy;
                    x.OrderBy = articleRightSideBarWidgetOptionsViewModel.OrderBy;
                    x.IsAscending = articleRightSideBarWidgetOptionsViewModel.IsAscending;
                    x.StartAt = articleRightSideBarWidgetOptionsViewModel.StartAt;
                    x.EndAt = articleRightSideBarWidgetOptionsViewModel.EndAt;
                    x.MaxViewCount = articleRightSideBarWidgetOptionsViewModel.MaxViewCount;
                    x.MinViewCount = articleRightSideBarWidgetOptionsViewModel.MinViewCount;
                    x.MaxCommentCount = articleRightSideBarWidgetOptionsViewModel.MaxCommentCount;
                    x.MinCommentCount = articleRightSideBarWidgetOptionsViewModel.MinCommentCount;
                });
                _toastNotification.AddSuccessToastMessage("Makale sayfalarımızın widget ayarları başarıyla güncellenmiştir.", new ToastrOptions
                {
                    Title = "Başarılı işlem"
                });
                return View(articleRightSideBarWidgetOptionsViewModel);
            }
            return View(articleRightSideBarWidgetOptionsViewModel);
        }
    }
}
