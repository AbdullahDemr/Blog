using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.MvcUI.Helpers.Abstract;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected UserManager<User> UserManager { get; }
        protected IMapper Mapper { get; }
        protected IImageHelper ImageHelpper { get; }
        protected User LoggedInUser => UserManager.GetUserAsync(HttpContext.User).Result;
        public BaseController(
            UserManager<User> userManager,
            IMapper mapper,
            IImageHelper imageHelpper)
        {
            UserManager = userManager;
            Mapper = mapper;
            ImageHelpper = imageHelpper;
        }
    }
}
