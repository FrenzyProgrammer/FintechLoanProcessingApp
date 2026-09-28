using LoanProcessingApp.Domain.Entities.Authentication;
using LoanProcessingApp.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoanProcessingApp.Infrastructure.Configurations
{
    public class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
    {
        public void Configure(EntityTypeBuilder<PersonalInfo> builder)
        {
            builder.ToTable("PersonalInfo");

            builder.HasKey(c => c.CustomerID);

            builder.Property(c => c.CustomerNumber)
                   .HasMaxLength(50);

            builder.Property(c => c.CustomerFirstName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.CustomerMiddleName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.CustomerLastName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.CustomerDOB)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.Property(c => c.CustomerEmail)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.CustomerPhone)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.IsActive)
                   .HasDefaultValue(true);

            builder.HasMany(c => c.Addresses)
            .WithOne(a => a.PersonalInfo)
            .HasForeignKey(a => a.CustomerID)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.User)
            .WithOne(a => a.PersonalInfo)
            .HasForeignKey<CustomerLogin>(c => c.CustomerId);
        }
    }
}
