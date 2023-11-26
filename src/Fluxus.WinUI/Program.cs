using Fluxus.App.Services;
using Fluxus.Infra.Interfaces;
using Fluxus.Infra.Repositories;
using Fluxus.WinUI.View;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            var service = Services();

            using (var serviceProvider = service.BuildServiceProvider())
            {
                var loginForm = new frmLogin(serviceProvider);
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var mainForm = new frmMain(serviceProvider);
                    Application.Run(mainForm);
                }
                else
                {
                    Application.Exit();
                }
            }

        }


        private static ServiceCollection Services()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IBankBranchRepository, BankBranchRepository>();
            services.AddSingleton<IInvoiceRepository, InvoiceRepository>();
            services.AddSingleton<IProfessionalRepository, ProfessionalRepository>();
            services.AddSingleton<IProfileRepository, ProfileRepository>();
            services.AddSingleton<IServiceOrderRepository, ServiceOrderRepository>();
            services.AddSingleton<IServiceRepository, ServiceRepository>();

            services.AddScoped<BankBranchService>();
            services.AddScoped<InvoiceService>();
            services.AddScoped<ProfessionalService>();
            services.AddScoped<ProfileService>();
            services.AddScoped<ServiceOrderService>();
            services.AddScoped<ServiceService>();

            return services;
        }
    }
}