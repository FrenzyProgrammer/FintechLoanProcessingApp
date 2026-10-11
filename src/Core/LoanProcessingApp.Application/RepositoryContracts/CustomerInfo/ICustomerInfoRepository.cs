using LoanProcessingApp.Domain.Entities.Customer;

namespace LoanProcessingApp.Application.RepositoryContracts.CustomerInfo
{
    public interface ICustomerInfoRepository
    {
        Task AddCustomer(PersonalInfo personalInfo, CancellationToken cancellationToken = default);
    }
}
