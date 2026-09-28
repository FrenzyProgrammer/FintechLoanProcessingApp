using LoanProcessingApp.Domain.Entities.Authentication;
using LoanProcessingApp.Domain.Entities.Authorization;

namespace LoanProcessingApp.Domain.Entities.Customer
{
    public record PersonalInfo
    {
        public Guid CustomerID { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerName { get => $"{CustomerFirstName} {CustomerMiddleName} {CustomerLastName}"; }
        public string CustomerDOB { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPAN { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<AddressInfo> Addresses { get; set; }
            = new HashSet<AddressInfo>();
        public CustomerLogin User { get; set; }
    }
}
