using System;

namespace LoanProcessingApp.Domain.Entities.Customer
{
    public enum EmploymentType
    {
        Salaried,
        SelfEmployed,
        Business
    }

    public record EmploymentInfo
    {
        public Guid EmploymentID { get; set; }
        public Guid CustomerID { get; set; }

        public EmploymentType EmploymentType { get; set; }
        public string EmployerName { get; set; }
        public string Designation { get; set; }
        public int YearsWithCurrentEmployer { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public string Industry { get; set; }
        public string WorkLocation { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}