using AutoShop_ASPNET.Repositories;
using Serilog;

namespace AutoShop_ASPNET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Information()
                        .WriteTo.Console()
                        .CreateLogger();

            builder.Host.UseSerilog();


            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IProductsRepository ,InMemoryProductsRepository>();
            builder.Services.AddSingleton<ICartRepository ,InMemoryCartRepository>();
            builder.Services.AddSingleton<IFavoriteRepository, InMemoryFavoriteRepository>();
            builder.Services.AddSingleton<ICompareRepository ,InMemoryCompareRepository>();
            builder.Services.AddSingleton<IOrderRepository ,InMemoryOrderRepository>();
            builder.Services.AddSingleton<IRoleRepository ,InMemoryRoleRepository>();

            var app = builder.Build();

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
