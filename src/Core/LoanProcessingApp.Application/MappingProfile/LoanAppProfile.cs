using AutoMapper;
using LoanProcessingApp.Application.Commands.CreateCustomer;
using LoanProcessingApp.Application.DTOs.Customer;
using LoanProcessingApp.Domain.Entities.Customer;

namespace LoanProcessingApp.Application.MappingProfile
{
    public class LoanAppProfile : Profile
    {
        public LoanAppProfile()
        {
            CreateMap<PersonalInfoDto, PersonalInfo>();
            CreateMap<AddressInfo, AddressInfoDto>().ReverseMap();
            CreateMap<PersonalInfoDto, CreateCustomerCommand>();
        }
    }
}
