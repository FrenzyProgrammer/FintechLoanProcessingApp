using LoanProcessingApp.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoanProcessingApp.Infrastructure.Configurations
{
    public class addressInfoConfiguration : IEntityTypeConfiguration<AddressInfo>
    {
        public void Configure(EntityTypeBuilder<AddressInfo> builder)
        {
            builder.ToTable("AddressInfo");

            builder.HasKey(c => c.AddressID);

            builder.Property(c => c.HouseNo)
                   .HasMaxLength(10);

            builder.Property(c => c.Street)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.Street)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.Area)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.City)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.State)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.Property(c => c.Country)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.IsActive).HasDefaultValue(true);

            builder.HasOne(c => c.PersonalInfo)
            .WithMany(a => a.Addresses)
            .HasForeignKey(a => a.CustomerID);
        }
    }
}
