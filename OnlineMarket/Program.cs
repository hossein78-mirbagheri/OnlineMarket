using OnlineMarket.Repository;
using OnlineMarket.Data;
using OnlineMarket.Migrations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IMarketDbContext, MarketDbContext>();
builder.Services.AddTransient<IAdminRepository, AdminRepository>();
//builder.Services.AddTransient<IUsersRepository, UsersRepository>();
//builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();

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
