using LoanProcessingApp.Application.Commands.CreateCustomer;
using LoanProcessingApp.Application.DTOs.Customer;

namespace LoanProcessingApp.Application.Contracts.CustomerInfo
{
    public interface ICustomerService
    {
        Task SaveCustomer(PersonalInfoDto personalInfo, CancellationToken cancellationToken);
    }
}
