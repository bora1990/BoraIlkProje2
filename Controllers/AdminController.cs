using BoraIlkProje2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BoraIlkProje2.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;   //dependency
        private readonly RoleManager<AppRole> _roleManager;
        public AdminController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {

            var users = _userManager.Users.ToList();


            return View(users);
        }





    }
}

