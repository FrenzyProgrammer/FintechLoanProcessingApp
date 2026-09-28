using LoanProcessingApp.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;

namespace LoanProcessingApp.Infrastructure.Context
{
    public class LoanAppContext:DbContext
    {
        public LoanAppContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<PersonalInfo> PersonalInfo { get; set; }
        public DbSet<AddressInfo> Customers => Set<AddressInfo>();
        //public DbSet<AddressInfo> AddressInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LoanAppContext).Assembly);
        }
    }
}
