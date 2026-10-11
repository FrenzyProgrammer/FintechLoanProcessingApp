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
            CreateMap<PersonalInfoDto, PersonalInfo>()
                 .ForPath(
                    dest => dest.User.UserName,
                    opt => opt.MapFrom(src =>
                        src.CustomerLogin != null
                            ? src.CustomerLogin.UserName
                            : null))
                 .ForPath(
                    dest => dest.User.PasswordSalt,
                    opt => opt.MapFrom(src =>
                        src.CustomerLogin != null
                            ? src.CustomerLogin.PasswordSalt
                            : null))
                 .ForPath(
                    dest => dest.User.PasswordHash,
                    opt => opt.MapFrom(src =>
                        src.CustomerLogin != null
                            ? src.CustomerLogin.PasswordHash
                            : null));
            CreateMap<AddressInfo, AddressInfoDto>().ReverseMap();
            //CreateMap<PersonalInfoDto, CreateCustomerCommand>();
            //CreateMap<CreateCustomerCommand, PersonalInfo>();
        }
    }
}
