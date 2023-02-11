using BoraIlkProje2.DataAccess;
using BoraIlkProje2.Models;
using BoraIlkProje2.OptionsModel;
using BoraIlkProje2.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);  //daha sa�lam

builder.Services.AddDbContext<OrderDbContext>(options =>            //identity

    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon")));

builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<OrderDbContext>()
    .AddDefaultTokenProviders();      //identity

builder.Services.Configure<DataProtectionTokenProviderOptions>(opt =>
{
    opt.TokenLifespan = TimeSpan.FromHours(2);
});
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));  //email

builder.Services.AddScoped<IEmailService, Emailservice>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;

    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); //5 dk sonra kullan�c� giri� yapmaya devam edebilir.
    options.Lockout.AllowedForNewUsers = true;  //lockout aktif olmas� i�in

    //options.User.AllowedUserNameCharacters=""
    options.User.RequireUniqueEmail = false;
    options.SignIn.RequireConfirmedAccount = false;  //onaylanm�� mail
    options.SignIn.RequireConfirmedPhoneNumber = false;


});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/home/logIn";  //uygulamya giri� yapamyan kullan�c� oldu�unda onu buraya g�nder
    options.LogoutPath = "/home/logOut";
    options.AccessDeniedPath = "/home/accessdenied";  //login var ,yetkisi yok go sayfa
    options.SlidingExpiration = false;  //20 dk default, her istek yap�ld���nda istedi�in kadar istek yap 20 dkda 1  s�f�rlan�r.
    options.ExpireTimeSpan = TimeSpan.FromDays(365);  //def s�resi 365 g�n

    options.Cookie = new CookieBuilder
    {
        HttpOnly = false, //k�t� niyet
        Name = "MyCookie",
        SameSite = SameSiteMode.Strict,

    };
});



var app = builder.Build();


app.UseDeveloperExceptionPage(); //sayfada hata al�nd���nda a��klay�c� bilgiler sunar

app.UseStatusCodePages();  //bo� sayfa yerine status page

app.UseAuthentication();  //identity

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseMvcWithDefaultRoute();

app.Run();
