using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Permissions
    {
        [Key]
        public int PermissionID { get; set; }

        // Required Columns
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string PermissionName { get; set; }

        // Optional Columns
        [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
        public string Description { get; set; }

        // Foreign Keys 
        [Required]
        [ForeignKey("Role")]
        public int RoleID { get; set; }

        // Navigation Property
        public virtual Roles Role { get; set; }
        public ICollection<RolePermissions> RolePermission { get; set; }
    }
}
