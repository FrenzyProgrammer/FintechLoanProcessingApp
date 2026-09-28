using LoanProcessingApp.Domain.Entities.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoanProcessingApp.Infrastructure.Configurations
{
    public class CustomerLoginConfiguration : IEntityTypeConfiguration<CustomerLogin>
    {
        public void Configure(EntityTypeBuilder<CustomerLogin> builder)
        {
            builder.ToTable("CustomerLogin");

            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.UserName)
                   .HasMaxLength(50);

            builder.Property(c => c.PasswordHash)
                   .HasMaxLength(50);

            builder.Property(c => c.PasswordSalt)
                   .HasMaxLength(20);

            builder.Property(c => c.IsVerified)
                   .HasDefaultValue(false);

            builder.Property(c => c.TwoFactorVerified)
                   .HasDefaultValue(false);

            builder.Property(c => c.IsLocked)
                   .HasDefaultValue(false);

            builder.HasOne(c => c.PersonalInfo)
            .WithOne(a => a.User)
            .HasForeignKey<CustomerLogin>(c => c.CustomerId);

            builder.HasMany(c => c.UserRoles)
            .WithOne(a => a.User)
            .HasForeignKey(c => c.RoleID);
        }
    }
}
