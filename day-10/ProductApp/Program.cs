using Microsoft.EntityFrameworkCore;
using ProductApp.Extensions;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.RegisterRepositories();
builder.Services.RegisterServices();

builder.Services.ConfigureIdentity();
builder.Services.ConfigureApplicationCookie();



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

app.UseEndpoints(endpoints=>
{
    endpoints.MapAreaControllerRoute(
        name:"Admin",
        areaName:"Admin",
        pattern:"Admin/{controller=Home}/{action=Index}/{id?}"
        );

    endpoints.MapControllerRoute(
        name:"default",
        pattern:"{controller=Home}/{action=Index}/{id?}"
        );
});

app.Run();
