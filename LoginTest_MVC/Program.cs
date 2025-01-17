using LoginTest_MVC.Controllers;
using LoginTest_MVC.repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LoginTest_MVC.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LoginTest_MVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LoginTest_MVCContext") ?? throw new InvalidOperationException("Connection string 'LoginTest_MVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
// builder.Services.AddSingleton<IPersonRepository, PersonViewModelRepository>();
builder.Services.AddSingleton<IPersonRepository, PersonViewModelRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=ModelState}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();