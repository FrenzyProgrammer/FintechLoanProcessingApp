using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcessingApp.Domain.Entities.Authorization
{
    public record AppRoles
    {
        public int RoleID { get; set; }
        public int RoleName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public ICollection<AppUserRoles> UserRoles { get; set; }
        = new HashSet<AppUserRoles>();
    }
}
