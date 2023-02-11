using BoraIlkProje2.DataAccess;
using BoraIlkProje2.Models;
using BoraIlkProje2.OptionsModel;
using BoraIlkProje2.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);  //daha saðlam

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
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); //5 dk sonra kullanýcý giriþ yapmaya devam edebilir.
    options.Lockout.AllowedForNewUsers = true;  //lockout aktif olmasý için

    //options.User.AllowedUserNameCharacters=""
    options.User.RequireUniqueEmail = false;
    options.SignIn.RequireConfirmedAccount = false;  //onaylanmýþ mail
    options.SignIn.RequireConfirmedPhoneNumber = false;


});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/home/logIn";  //uygulamya giriþ yapamyan kullanýcý olduðunda onu buraya gönder
    options.LogoutPath = "/home/logOut";
    options.AccessDeniedPath = "/home/accessdenied";  //login var ,yetkisi yok go sayfa
    options.SlidingExpiration = false;  //20 dk default, her istek yapýldýðýnda istediðin kadar istek yap 20 dkda 1  sýfýrlanýr.
    options.ExpireTimeSpan = TimeSpan.FromDays(365);  //def süresi 365 gün

    options.Cookie = new CookieBuilder
    {
        HttpOnly = false, //kötü niyet
        Name = "MyCookie",
        SameSite = SameSiteMode.Strict,

    };
});



var app = builder.Build();


app.UseDeveloperExceptionPage(); //sayfada hata alýndýðýnda açýklayýcý bilgiler sunar

app.UseStatusCodePages();  //boþ sayfa yerine status page

app.UseAuthentication();  //identity

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseMvcWithDefaultRoute();

app.Run();
