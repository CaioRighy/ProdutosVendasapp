using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using ProdutosVendas.Application.Interfaces;
using ProdutosVendas.Application.Services;
using ProdutosVendas.Infrastructure.Data;
using ProdutosVendas.Infrastructure.Repositories;

namespace ProdutosVendas.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);


            using var host = CreateHostBuilder().Build();
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            System.Windows.Forms.Application.Run(services.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                var conn = context.Configuration.GetConnectionString("DefaultConnection")
                           ?? "Server=localhost;Database=ProdutosVendasDb;Trusted_Connection=True;TrustServerCertificate=True;";

                services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(conn));

                services.AddScoped<IProductRepository, ProductRepository>();

                services.AddScoped<IProductService, ProductService>();

                services.AddTransient<MainForm>();
            });
    }
}
