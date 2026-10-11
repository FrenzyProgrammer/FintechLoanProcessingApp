using LoanProcessingApp.Application;
using LoanProcessingApp.Application.Commands.Transaction;
using LoanProcessingApp.Application.RepositoryContracts.CustomerInfo;
using LoanProcessingApp.Infrastructure.Context;
using LoanProcessingApp.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LoanProcessingApp.Infrastructure.Dependencies
{
    public static class InfrastructureExtensions
    {
        // Accept IConfiguration so callers can provide the connection string
        public static IServiceCollection AddInfrastructureExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            // Register DbContext
            services.AddDbContext<LoanAppContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LoanProcessingDb")));

            // Register repository implementations
            services.AddScoped<ICustomerInfoRepository, CustomerInfoRepository>();

            // Register UnitOfWork implementation.
            // The implementation currently lives in the LoanApplication.Database namespace and the class is named CustomerInfoRepository.
            // Fully-qualify the type to avoid ambiguous type resolution.
            services.AddScoped<IUnitOfWork, LoanProcessingApp.Database.CustomerInfoRepository>();

            services.AddMediatR(s =>
            {
                s.RegisterServicesFromAssembly(typeof(IUnitOfWork).Assembly);
            });

            services.AddScoped(typeof(IPipelineBehavior<,>),
                                       typeof(TransactionBehavior<,>));

            return services;
        }
    }
}
