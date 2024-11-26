using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Presentation;
using BusinessLogic.Repositories;
using BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BusinessLogic
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = AddServices().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        public static IServiceProvider ServiceProvider { get; private set; } = default!;
        static IHostBuilder AddServices()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //DbContext
                    services.AddScoped<AppDbContext>();

                    //Services
                    services.AddScoped<IUnitOfWork, UnitOfWork>();

                    //Repositories
                    services.AddScoped<IRepository<Company>, CompanyRepository>();
                    services.AddScoped<IRepository<Product>, ProductRepository>();
                    services.AddScoped<IRepository<Resource>, ResourceRepository>();
                    services.AddScoped<IRepository<Shop>, ShopRepository>();
                    services.AddScoped<IRepository<Warehouse>, WarehouseRepository>();
                    services.AddScoped<IProductResourceRepository, ProductResourceRepository>();
                    services.AddScoped<IProductWarehouseRepository, ProductWarehouseRepository>();
                    services.AddScoped<IDistanceRepository, DistanceRepository>();

                    //Forms
                    services.AddTransient<MainForm>();
                });
        }
    }
}