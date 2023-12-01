using Fluxus.App.Services;
using Fluxus.Infra.Repositories;
using Fluxus.Infra.Repositories.Contracts;
using Fluxus.WinUI.View;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = CreateServiceCollection();


            using (var serviceProvider = services.BuildServiceProvider())
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


        private static ServiceCollection CreateServiceCollection()
        {
            var services = new ServiceCollection();

            services.AddScoped<IBankBranchRepository, BankBranchRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IProfessionalRepository, ProfessionalRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IConnection, RestConnection>();

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