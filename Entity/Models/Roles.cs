﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }

        // Required Columns
        [Required]
        [StringLength(50, ErrorMessage = "Role name cannot exceed 50 characters.")]
        public string RoleName { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        // Optional Columns
        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters.")]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ModifyDate { get; set; }

        public long? Modifier { get; set; }

        // Relations
        public ICollection<Users> User { get; set; }
        public virtual List<RolePermissions> RolePemission { get; set; }
    }
}
