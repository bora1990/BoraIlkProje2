using BoraIlkProje2.DataAccess;
using BoraIlkProje2.Extensions;
using BoraIlkProje2.Models;
using BoraIlkProje2.ViewModels;
using Identtity2.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BoraIlkProje2.Controllers
{
    [Authorize]
    public class MemberController : Controller
    {
        private UserManager<AppUser> _userManager { get; }   //parola sıfırlama,kullanıcı oluşturma,login 
        private readonly OrderDbContext _databasecontext;

        private SignInManager<AppUser> _signInManager;

        public MemberController(UserManager<AppUser> userManager, OrderDbContext databasecontext, SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            _databasecontext = databasecontext;
            _userManager = userManager;
        }
        public IActionResult UserInformation()
        {

            AppUser user = _userManager.FindByNameAsync(User.Identity!.Name).Result;

            UserViewModel userViewModel = new UserViewModel
            {
                Email = user!.Email,
                UserName = user!.UserName,
                PhoneNumber = user.PhoneNumber
            };

            return View(userViewModel);

        }

        public IActionResult Order()
        {
            List<Product> pr = _databasecontext.Products.ToList();


            return View(pr);
        }
        [HttpPost]

        public IActionResult Order(List<Product> products)
        {

            return View(products);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");

        }
        public IActionResult PasswordChange()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PasswordChange(ResetPasswordVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var currentUser = await _userManager.FindByNameAsync(User.Identity!.Name!);

            var checkOldPass = await _userManager.CheckPasswordAsync(currentUser, request.PasswordOld);

            if (!checkOldPass)
            {
                ModelState.AddModelError(string.Empty, "Eski şifreniz yanlış");
                return View();
            }
            var resultChangePass = await _userManager.ChangePasswordAsync(currentUser, request.PasswordOld, request.PasswordConfirm);

            if (!resultChangePass.Succeeded)
            {
                ModelState.AddModelErrorList(resultChangePass.Errors);
                return View();
            }

            await _userManager.UpdateSecurityStampAsync(currentUser);

            await _signInManager.SignOutAsync();
            await _signInManager.PasswordSignInAsync(currentUser, request.PasswordConfirm, true, false);

            TempData["Success"] = "Şifreniz başarıyla değiştirilmiştir.";


            return View();
        }

        public IActionResult UserEdit()
        {
            AppUser userEditVM = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var userEdit = new UserEditVM()
            {
                UserName = userEditVM.UserName,
                Email = userEditVM.Email,
                PhoneNumber = userEditVM.PhoneNumber,
            };


            return View(userEdit);
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserEditVM userEditVM)
        {
            if (ModelState.IsValid)  //password u cshtml de sildiğimiz için boş geldi ve onaylanmadı
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                user.UserName = userEditVM.UserName;
                user.Email = userEditVM.Email;
                user.PhoneNumber = userEditVM.PhoneNumber;


                IdentityResult result = await _userManager.UpdateAsync(user); //update yaparken karşılaşılan hataları IdentityResultın error propertysinden gelir.

                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user); //bunu yazmazsak kullanıcı eski şifreyle dolaşmaya devam eder.

                    await _signInManager.SignOutAsync();  //kullanıcıya backendd çıkış ve giriş yaptırdık
                    await _signInManager.SignInAsync(user, true);
                    //cookie güncellemiş olduk.



                    ViewBag.success = "true";

                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(userEditVM);
        }




        [HttpPost]
        public IActionResult AjaxIlePost(Order siparis)
        {
            _databasecontext.Orders.Add(siparis);

            int sonuc = _databasecontext.SaveChanges();
            if (sonuc > 0)
            {
                return Ok();
            }
            else
            {
                return Problem();
            }
        }


    }
}
