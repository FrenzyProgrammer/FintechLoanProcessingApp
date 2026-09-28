using LoanProcessingApp.Domain.Entities.Authentication;
using LoanProcessingApp.Domain.Entities.Authorization;
using LoanProcessingApp.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoanProcessingApp.Infrastructure.Configurations
{
    public class AppRolesConfiguration : IEntityTypeConfiguration<AppRoles>
    {
        public void Configure(EntityTypeBuilder<AppRoles> builder)
        {
            builder.ToTable("AppRoles");

            builder.HasKey(c => c.RoleID);

            builder.Property(c => c.RoleID)
                   .UseIdentityColumn();

            builder.Property(c => c.RoleName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(c => c.IsActive).HasDefaultValue(true);

            builder.HasMany(c => c.UserRoles)
            .WithOne(a => a.Roles)
            .HasForeignKey(a => a.RoleID);

        }
    }
}
