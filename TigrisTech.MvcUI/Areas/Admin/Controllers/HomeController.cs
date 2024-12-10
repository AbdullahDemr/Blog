using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.MvcUI.Areas.Admin.Models;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,AdminArea.Home.Read")]
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        private readonly UserManager<User> _userManager;
        public HomeController(ICommentService commentService,
             ICategoryService categoryService,
             IArticleService articleService,
             UserManager<User> userManager)
        {
            _commentService = commentService;
            _articleService = articleService;
            _categoryService = categoryService;
            _userManager = userManager;
        }
        [Authorize(Roles = "SuperAdmin,AdminArea.Home.Read")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categoriesCountResult = await _categoryService.CountByNonDeletedAsync();
            var articlesCountResult = await _articleService.CountByNonDeletedAsync();
            var commentsCountResult = await _commentService.CountByNonDeletedAsync();
            var usersCount = await _userManager.Users.CountAsync();
            var articlesResult = await _articleService.GetAllAsync();

            if (categoriesCountResult.ResultStatus == ResultStatus.Success &&
               articlesCountResult.ResultStatus == ResultStatus.Success &&
               commentsCountResult.ResultStatus == ResultStatus.Success &&
               articlesResult.ResultStatus == ResultStatus.Success &&
               usersCount > -1)
            {
                return View(new DashboardViewModel
                {
                    CategoriesCount = categoriesCountResult.Data,
                    ArticlesCount = articlesCountResult.Data,
                    CommentCount = commentsCountResult.Data,
                    UserCount = usersCount,
                    Articles = articlesResult.Data
                });

            }
            return NotFound();
        }

        [Authorize(Roles = "SuperAdmin,AdminArea.Home.Read")]
        [HttpGet]
        public IActionResult ProtecedPage()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var roles = _userManager.GetRolesAsync(user).Result;
            if (user == null)
                return Content("Kullanıcı bulunamadı.");
            if (roles == null)
                return Content("Roller bulunamadı.");
            return View(new UserWithRolesViewModel
            {
                User = user,
                Roles = roles
            });

        }
    }
}
