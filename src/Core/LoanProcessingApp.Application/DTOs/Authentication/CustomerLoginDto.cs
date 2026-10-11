namespace LoanProcessingApp.Application.DTOs.Authentication
{
    public record CustomerLoginDto
    {
        public Guid CustomerID { get; set; }
        public string UserName { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? LastLogin { get; set; } = DateTime.UtcNow;
        public bool IsVerified { get; set; }
        public bool TwoFactorVerified { get; set; }
        public bool IsLocked { get; set; }
    }
}
