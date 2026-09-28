using LoanProcessingApp.Domain.Entities.Authentication;

namespace LoanProcessingApp.Application.DTOs.Customer
{
    public record PersonalInfoDto
    {
        public Guid? CustomerID { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerName { get => $"{CustomerFirstName} {CustomerMiddleName} {CustomerLastName}"; }
        public string CustomerDOB { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<AddressInfoDto> Addresses { get; set; }
            = new HashSet<AddressInfoDto>();
        //public CustomerLogin User { get; set; }
    }
}
