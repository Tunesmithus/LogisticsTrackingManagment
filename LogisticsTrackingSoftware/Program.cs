using LogisticsManagement.AppLogic.Configurations;
using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.AppLogic.Repositories;
using LogisticsManagement.Data;
using LogisticsManagement.Data.Data;
using LogisticsTrackingSoftware.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



// Add services to the container.
var builder = WebApplication.CreateBuilder(args); 

//This code runs the application
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
    options.SignIn.RequireConfirmedAccount = true;
    
    
}).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId = "975242062915-3trdbv8c3ipjpoq75di4ef536jrunohh.apps.googleusercontent.com";
    options.ClientSecret = "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";
});

builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.AppId = "800134724694180";
    options.AppSecret = "c7ae5190125cc18a65871f4dd6c4150";
});




builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

//seed database
//AppDbInitializer.Seed(app);

app.Run();
