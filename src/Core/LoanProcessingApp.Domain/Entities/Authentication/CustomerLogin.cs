using LoanProcessingApp.Domain.Entities.Authorization;
using LoanProcessingApp.Domain.Entities.Customer;

namespace LoanProcessingApp.Domain.Entities.Authentication
{
    public record CustomerLogin
    {
        public Guid? CustomerId { get; set; }
        public string UserName { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? LastLogin { get; set; } = DateTime.UtcNow;
        public bool IsVerified { get; set; }
        public bool TwoFactorVerified { get; set; }
        public bool IsLocked { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public virtual ICollection<AppUserRoles> UserRoles { get; set; }
           = new HashSet<AppUserRoles>();
    }
}
