using Microsoft.EntityFrameworkCore;
using NguyenHoangLongMVC.Application.Interfaces;
using NguyenHoangLongMVC.Application.Mappings;
using NguyenHoangLongMVC.Application.Services;
using NguyenHoangLongMVC.Data.Contexts;
using NguyenHoangLongMVC.Data.Repositories;

namespace NguyenHoangLongMVC.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<MyDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("MyCnn"));
            });

            //Register Repository and Service
            builder.Services.AddScoped<INewsArticleRepository, NewsArticleRepository>();
            builder.Services.AddScoped<INewsArticleService, NewsArticleService>();

            //Register AutoMapper
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Set startup page


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=NewsArticle}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
