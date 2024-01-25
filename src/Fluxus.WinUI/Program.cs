using Fluxus.Core.Contracts.Databases;
using Fluxus.WinUI.View;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Infra.Databases.Api;
using Fluxus.UseCases;

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

            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IProfessionalRepository, ProfessionalRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddSingleton<IConnection, HttpConnection>();

            services.AddScoped<BranchUseCases>();
            services.AddScoped<InvoiceUseCases>();
            services.AddScoped<ProfessionalUseCases>();
            services.AddScoped<ProfileUseCases>();
            services.AddScoped<OrderUseCases>();
            services.AddScoped<ServiceUseCases>();
            services.AddScoped<UserUseCases>();

            return services;
        }
    }
}