using LoanProcessingApp.Application;
using LoanProcessingApp.Domain.Entities.Customer;
using LoanProcessingApp.Domain.RepositoryContracts.CustomerInfo;
using LoanProcessingApp.Infrastructure.Context;
using System;

namespace LoanProcessingApp.Infrastructure.Repositories
{
    public class CustomerInfoRepository: ICustomerInfoRepository
    {
        private readonly LoanAppContext _context;
        public CustomerInfoRepository(LoanAppContext context)
        {
            _context = context;
        }

        public async Task AddCustomer(PersonalInfo personalInfo, CancellationToken cancellationToken = default)
        {
           await _context.PersonalInfo.AddAsync(personalInfo,cancellationToken);
        }
    }
}
