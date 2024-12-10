using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Editor.References;
using TigrisTech.MvcUI.Helpers.Abstract;
using TigrisTech.Services.Abstract;

namespace TigrisTech.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : BaseController
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService,
            UserManager<User> userManager, IMapper mapper, IImageHelper imageHelpper) : base(userManager, mapper, imageHelpper)
        {
            _doctorService = doctorService;
        }
        public async Task<IActionResult> Index()
        {
            var doctor = await _doctorService.GetAllAsync();

            return View(doctor.Data);
        }
    }
}
