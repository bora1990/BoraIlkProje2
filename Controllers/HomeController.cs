using BoraIlkProje2.DataAccess;
using BoraIlkProje2.Models;
using BoraIlkProje2.Services;
using BoraIlkProje2.ViewModels;
using Identtity2.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BoraIlkProje2.Controllers
{

    public class HomeController : Controller
    {
        private UserManager<AppUser> _userManager { get; }   //dependency
        private readonly OrderDbContext _databasecontext;
        private SignInManager<AppUser> _signInManager;
        private readonly IEmailService _emailService;
        public HomeController(OrderDbContext orderDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailService emailService)
        {
            _signInManager = signInManager;
            _databasecontext = orderDbContext;
            _userManager = userManager;
            _emailService = emailService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp() //kaydolmak
        {
            return View();
        }
        [HttpPost]
        /*[ValidateAntiForgeryToken] */ //token gelmezse çalışmaz en üstteyse tüm post işlmelerinde geçerlidir.
        public async Task<IActionResult> SignUp(UserViewModel userViewModel) //kaydolmak
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();
                user.UserName = userViewModel.UserName;
                user.Email = userViewModel.Email;
                user.PhoneNumber = userViewModel.PhoneNumber;
                var result = await _userManager.CreateAsync(user, userViewModel.Password);


                if (result.Succeeded)
                {


                    return RedirectToAction("LogIn", "Home");
                }
                else
                {
                    foreach (IdentityError item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }

            }
            return View(userViewModel);
        }

        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> LogIn(LoginViewModel userlogin)
        {
            if (!ModelState.IsValid)
            {
                return View(userlogin);

            }

            var user = await _userManager.FindByEmailAsync(userlogin.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu email ile daha önce hesap oluşturulmamıştır.");
                return View(userlogin);

            }
            var result = await _signInManager.PasswordSignInAsync(user, userlogin.Password, false, false);  //tarayıcı kapandığı anda cookie silinir.
            if (result.Succeeded)
            {
                return RedirectToAction("Order", "Member");

            }

            return View(userlogin);
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


        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM request)
        {
            var userId = TempData["userId"];
            var token = TempData["token"];

            if (userId == null || token == null)
            {
                throw new Exception("Bir hata meydana geldi");
            }


            var hasUser = await _userManager.FindByIdAsync(userId!.ToString());

            if (hasUser == null)
            {
                ModelState.AddModelError(String.Empty, "Kullanıcı Bulunamamıştır");
                return View();
            }

            var result = await _userManager.ResetPasswordAsync(hasUser, token!.ToString(), request.Password);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Şifreniz başarıyla yenilenmiştir.";

            }
            else
            {
                //ModelState.AddModelErrorList(result.Errors.Select(x => x.Description).ToList());

            }
            return View();
        }

        public IActionResult ForgetPassword()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPassword)
        {

            var hasUser = await _userManager.FindByEmailAsync(forgetPassword.Email);

            if (hasUser == null)
            {
                ModelState.AddModelError(string.Empty, "Bu email adrsine sahip kullanıcı bulunamamıştır.");
                return View();
            }

            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(hasUser);

            var passwordResetLink = Url.Action("ResetPassword", "Home", new { userId = hasUser.Id, Token = passwordResetToken }, HttpContext.Request.Scheme);

            TempData["SuccessMessage"] = "Şifre yenileme linki , email adresinize gönderilmiştir.";

            await _emailService.SendResetPasswordEmail(passwordResetLink, hasUser.Email);


            return RedirectToAction(nameof(ForgetPassword));
        }

        public IActionResult Bilgi()
        {
            return View();
        }
        public IActionResult OrderWithApi()
        {
            return View();
        }
    }
}

