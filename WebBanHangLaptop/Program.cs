using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebBanHangLaptop.Data;
using WebBanHangLaptop.Models;
using WebBanHangLaptop.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebBanHangConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    // Cấu hình các tùy chọn Identity
})
 .AddDefaultUI()
.AddEntityFrameworkStores<ApplicationDbContext>() // Thay thế ApplicationDbContext bằng DbContext của bạn
.AddDefaultTokenProviders();

builder.Services.AddRazorPages();

// Đăng ký dịch vụ UserManager
builder.Services.AddScoped<UserManager<ApplicationUser>>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();

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

app.UseAuthorization();
app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
