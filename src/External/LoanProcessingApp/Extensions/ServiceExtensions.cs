using LoanProcessingApp.Application.Contracts.CustomerInfo;
using LoanProcessingApp.Application.Service.CustomerInfo;

namespace LoanProcessingApp.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServiceExtensions(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}
