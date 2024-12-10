using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Editor.Emails;
using TigrisTech.Entities.Dtos.Users;
using TigrisTech.Services.Abstract;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{

    [Area("Admin")]
  
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMailService _mailService;
        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager,
            IMailService mailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailService = mailService;
        }
        [Route("sunkardesler")]
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [Route("sunkardesler")]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("ProtecedPage", "Home", new { Area = "Admin" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlış");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlış");
                    return View();
                }
            }
            else
            {
                return View();
            }

        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
        [Authorize]
        [HttpGet]
        public ViewResult AccessDenied()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            TempData["durum"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult ResetPassword(PasswordResetDto passwordResetDto)
        {
            if (TempData["durum"] == null)
            {
                User user = _userManager.FindByEmailAsync(passwordResetDto.Email).Result;

                if (user != null)

                {
                    string passwordResetToken = _userManager.GeneratePasswordResetTokenAsync(user).Result;
                    string passwordResetLink = Url.Action("ResetPasswordConfirm", "Auth", new
                    {
                        userId = user.Id,
                        token = passwordResetToken
                    }, HttpContext.Request.Scheme);

                    //  www.tigrissoft.com/Home/ResetPasswordConfirm?userId=sdjfsjf&token=dfjkdjfdjf

                    //Helper.PasswordReset.PasswordResetSendEmail(passwordResetLink, user.Email);
                    _mailService.SendLink(passwordResetDto, passwordResetLink);

                    ViewBag.status = "success";
                    TempData["durum"] = true.ToString();
                }
                else
                {
                    ModelState.AddModelError("", "Sistemde kayıtlı email adresi bulunamamıştır.");
                }
                return View(passwordResetDto);
            }
            else
            {
                return RedirectToAction("ResetPassword");
            }
        }
        public IActionResult ResetPasswordConfirm(string userId, string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPasswordConfirm([Bind("PasswordNew")] PasswordResetDto passwordResetDto)
        {
            string token = TempData["token"].ToString();
            string userId = TempData["userId"].ToString();
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                IdentityResult result = await _userManager.ResetPasswordAsync(user, token, passwordResetDto.PasswordNew);

                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);

                    ViewBag.status = "success";
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "hata meydana gelmiştir. Lütfen daha sonra tekrar deneyiniz.");
            }

            return View(passwordResetDto);
        }
    }
}
