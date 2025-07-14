// THESE USING STATEMENTS MUST BE AT THE VERY TOP OF THE FILE
using Microsoft.EntityFrameworkCore; // Required for UseSqlServer.
using CarInsurance.Data; // Required to reference your ApplicationDbContext.
using System; // Required for InvalidOperationException and other basic types.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Get the connection string from appsettings.json.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Register the ApplicationDbContext with the dependency injection container.
// This tells the application to use SQL Server with the specified connection string.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// The rest of your Program.cs file remains the same...
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
