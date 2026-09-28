using System;

namespace LoanProcessingApp.Domain.Entities.Customer
{
    public enum IncomeFrequency
    {
        Monthly,
        Quarterly,
        SemiAnnually,
        Annually
    }

    public record IncomeInfo
    {
        public Guid IncomeID { get; set; }
        public Guid CustomerID { get; set; }

        // Gross income (both monthly and annual)
        public decimal GrossMonthlyIncome { get; set; }
        public decimal GrossAnnualIncome { get; set; }

        public decimal NetMonthlyIncome { get; set; }
        public decimal OtherIncome { get; set; }
        public decimal ExistingEmisObligations { get; set; }

        public IncomeFrequency IncomeFrequency { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}