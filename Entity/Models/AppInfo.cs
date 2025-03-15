using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class AppInfo
    {
        [Key]
        public long AppID { get; set; }
        // Required Columns

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "AppName must be between 2 and 50 characters.")]
        public string AppName { get; set; }

        [Required]
        public string Logo { get; set; }
        
        [Required]
        public string Favicon { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        // Optional Columns

        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters.")]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ModifyDate { get; set; }

        public long? Modifier { get; set; }
    }
}
