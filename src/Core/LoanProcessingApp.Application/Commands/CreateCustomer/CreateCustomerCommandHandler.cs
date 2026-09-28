using AutoMapper;
using LoanProcessingApp.Application.DTOs.Customer;
using LoanProcessingApp.Domain.Entities.Customer;
using LoanProcessingApp.Domain.RepositoryContracts.CustomerInfo;
using MediatR;

namespace LoanProcessingApp.Application.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, PersonalInfoDto>
    {
        private readonly ICustomerInfoRepository _customerRepository;
        private readonly IMapper _mapper;
        public CreateCustomerCommandHandler(IMapper mapper, ICustomerInfoRepository customerInfoRepository)
        {
            _mapper = mapper;
            _customerRepository = customerInfoRepository;
        }

        public async Task<PersonalInfoDto> Handle(CreateCustomerCommand createCustomerCommand, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<PersonalInfo>(createCustomerCommand);
            await _customerRepository.AddCustomer(entity, cancellationToken);
            return _mapper.Map<PersonalInfoDto>(entity);
        }
    }
}
