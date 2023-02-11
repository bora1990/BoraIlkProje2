using BoraIlkProje2.Extensions;
using BoraIlkProje2.Models;
using BoraIlkProje2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoraIlkProje2.Controllers
{
    public class RolesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        public RolesController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.Select(x => new RoleVM()
            {
                Id = x.Id,
                Name = x.Name!
            }).ToListAsync();

            return View(roles);
        }
        [Authorize(Roles = "admin")]
        public IActionResult RoleCreate()

        {
            return View();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleVM request)
        {
            var result = await _roleManager.CreateAsync(new AppRole()
            {

                Name = request.Name

            });
            if (!result.Succeeded)
            {
                ModelState.AddModelErrorList(result.Errors);  //
                return View();
            }
            TempData["Success"] = "Rol oluşturulmuştur.";

            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> RoleUpdate(string id)
        {
            var roleUpdate = await _roleManager.FindByIdAsync(id);

            return View(new RoleUpdateVM()
            {
                Id = (roleUpdate.Id).ToString(),
                Name = roleUpdate!.Name!
            });

        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> RoleUpdate(RoleUpdateVM request)
        {
            var roleToUpdate = await _roleManager.FindByIdAsync(request.Id);

            roleToUpdate.Name = request.Name;
            await _roleManager.UpdateAsync(roleToUpdate);

            ViewData["Success"] = "Rol bilgisi güncellenmiştir";

            return View();
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> RoleDelete(string id)
        {
            var roleDeleted = await _roleManager.FindByIdAsync(id);

            if (roleDeleted == null)
            {
                throw new Exception("Silinecek rol bulunamamıştır");
            }

            var result = await _roleManager.DeleteAsync(roleDeleted);

            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.Select(x => x.Description).First());
            }

            TempData["Success"] = "Rol silinmiştir.";

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> AsssignRoleToUser(string id)
        {
            var currentUser = (await _userManager.FindByIdAsync(id))!;

            ViewBag.userId = id;


            var roles = await _roleManager.Roles.ToListAsync();

            var userRoles = await _userManager.GetRolesAsync(currentUser);

            var roleViewModel = new List<RoleAssignVM>();





            foreach (var role in roles)
            {
                var assignRoleToUserViewModel = new RoleAssignVM()
                {
                    Id = role.Id,
                    Name = role.Name
                };

                if (userRoles.Contains(role.Name))
                {
                    assignRoleToUserViewModel.Exist = true;
                }

                roleViewModel.Add(assignRoleToUserViewModel);
            }


            return View(roleViewModel);


        }
        [HttpPost]
        public async Task<IActionResult> AsssignRoleToUser(string userId, List<RoleAssignVM> requestList)
        {
            var userToAssignRoles = await _userManager.FindByIdAsync(userId)!;

            foreach (var role in requestList)
            {

                if (role.Exist)
                {
                    await _userManager.AddToRoleAsync(userToAssignRoles, role.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(userToAssignRoles, role.Name);

                }
            }




            return RedirectToAction(nameof(AdminController.Users), "Admin");
        }
    }
}
