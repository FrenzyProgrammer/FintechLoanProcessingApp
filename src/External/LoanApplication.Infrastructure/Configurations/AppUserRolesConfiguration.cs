using LoanProcessingApp.Domain.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoanProcessingApp.Infrastructure.Configurations
{
    public class AppUserRolesConfiguration : IEntityTypeConfiguration<AppUserRoles>
    {
        public void Configure(EntityTypeBuilder<AppUserRoles> builder)
        {
            builder.ToTable("AppUserRoles");

            builder.HasKey(c => c.CustomerID);

            builder.HasOne(c => c.Roles)
            .WithMany(a => a.UserRoles)
            .HasForeignKey(a => a.RoleID);

            builder.HasOne(c => c.User)
            .WithMany(a => a.UserRoles)
            .HasForeignKey(a => a.RoleID);
        }
    }
}
