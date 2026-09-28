using LoanProcessingApp.Domain.Entities.Authentication;
using LoanProcessingApp.Domain.Entities.Customer;

namespace LoanProcessingApp.Domain.Entities.Authorization
{
    public record AppUserRoles
    {
        public Guid? CustomerID { get; set; }
        public int RoleID { get; set; }

        public CustomerLogin User { get; set; }
        public AppRoles Roles { get; set; }
    }
}
