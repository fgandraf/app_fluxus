using Fluxus.App;
using Fluxus.Domain.Interfaces;
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
                var loginForm = serviceProvider.GetRequiredService<frmLogin>();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var mainForm = serviceProvider.GetRequiredService<frmMain>();
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


            services.AddScoped<frmLogin>();
            services.AddScoped<frmMain>();
            services.AddScoped<uctProfile>();
            services.AddScoped<ProfileService>();
            //TO DO: Add all scoped and inject
            
            return services;
        }
    }
}