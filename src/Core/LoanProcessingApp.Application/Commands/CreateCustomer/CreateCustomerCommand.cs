using LoanProcessingApp.Application.DTOs.Customer;
using MediatR;

namespace LoanProcessingApp.Application.Commands.CreateCustomer
{
    public class CreateCustomerCommand:IRequest<PersonalInfoDto>
    {
    }
}
