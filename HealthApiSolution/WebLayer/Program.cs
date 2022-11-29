using DataLayer;
using ServiceLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor();
builder.Services.AddDataLayerRegistration(builder.Configuration);
builder.Services.AddServiceLayerRegistration(builder.Configuration);
// Add services to the container.

builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.AccessDeniedPath = "/Account/AccessDenied";
    opt.LoginPath = "/account/login";
    opt.LogoutPath = "/Home/Index";
    opt.Cookie = new CookieBuilder()
    {
        SameSite = SameSiteMode.Lax,
        SecurePolicy = CookieSecurePolicy.SameAsRequest,
        Name = "CaddeForm",
        HttpOnly = false,
    };
    opt.ExpireTimeSpan = TimeSpan.FromDays(15);
    opt.SlidingExpiration = true;
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
