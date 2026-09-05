using Educare.Data;
using Microsoft.EntityFrameworkCore; //2 new text lines added for Entity Framework Core
namespace Educare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<EducareDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("EducareConnection"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("EducareConnection")
        )
    )); //other 6 lines added for Entity Framework Core

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

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
            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
