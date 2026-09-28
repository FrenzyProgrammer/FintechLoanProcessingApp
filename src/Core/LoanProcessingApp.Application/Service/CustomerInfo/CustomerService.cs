using AutoMapper;
using LoanProcessingApp.Application.Commands.CreateCustomer;
using LoanProcessingApp.Application.Contracts.CustomerInfo;
using LoanProcessingApp.Application.DTOs.Customer;
using MediatR;

namespace LoanProcessingApp.Application.Service.CustomerInfo
{
    public class CustomerService : ICustomerService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CustomerService(IMediator mediator,IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public Task SaveCustomer(PersonalInfoDto personalInfo, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<CreateCustomerCommand>(personalInfo);
            return _mediator.Send(personalInfo, cancellationToken);
        }
    }
}
