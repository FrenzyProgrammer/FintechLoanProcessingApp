using LoanProcessingApp.Domain.Entities.Authentication;
using LoanProcessingApp.Domain.Entities.Customer;

namespace LoanProcessingApp.Application.DTOs.Authorization
{
    public record AppUserRolesDto
    {
        public Guid CustomerID { get; set; }
        public int RoleID { get; set; }
        public AppRolesDto Roles { get; set; }
    }
}
