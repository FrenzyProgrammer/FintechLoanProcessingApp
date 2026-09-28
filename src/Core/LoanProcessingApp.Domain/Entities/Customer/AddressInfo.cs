namespace LoanProcessingApp.Domain.Entities.Customer
{
    public record AddressInfo
    {
        public Guid AddressID { get; set; }
        public Guid CustomerID { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Address { get => $"#{HouseNo}-{Street}-{Area}-{City}-{State}-{Country}-{PostalCode}"; }
        public bool IsActive { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}
