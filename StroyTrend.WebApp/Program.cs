using StroyTrend.Application;
using StroyTrend.Application.Configuration.AutoMapper;
using StroyTrend.WebApp.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(ApplicationProfile), typeof(PresentationProfile));
builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies([typeof(Program).Assembly, typeof(ApplicationAssembleReference).Assembly]); });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();