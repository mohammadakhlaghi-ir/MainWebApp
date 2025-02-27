using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class RolePermissions
    {
        [Key]
        public int RolePermissionID { get; set; }

        // Required Columns
        [Required]
        [ForeignKey("Role")]
        public int RoleID { get; set; }
        [Required]
        [ForeignKey("Permission")]
        public int PermissionID { get; set; }

        // Relations
        public virtual Roles Role { get; set; }
        public virtual Permissions Permission { get; set; }
    }
}
