using LoanProcessingApp.Domain.Entities.Customer;

namespace LoanProcessingApp.Domain.RepositoryContracts.CustomerInfo
{
    public interface ICustomerInfoRepository
    {
        Task AddCustomer(PersonalInfo personalInfo, CancellationToken cancellationToken = default);
    }
}
