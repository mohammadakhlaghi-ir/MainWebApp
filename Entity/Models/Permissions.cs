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
        [StringLength(50, ErrorMessage = "Permission Name cannot exceed 50 characters.")]
        public string PermissionName { get; set; }

        // Optional Columns
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters.")]
        public string? Description { get; set; }

        // Navigation Property
        public virtual List<RolePermissions> RolePemission { get; set; }
    }
}
