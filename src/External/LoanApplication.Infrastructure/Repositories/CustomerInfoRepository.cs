using LoanProcessingApp.Application.RepositoryContracts.CustomerInfo;
using LoanProcessingApp.Domain.Entities.Customer;
using LoanProcessingApp.Infrastructure.Context;

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
