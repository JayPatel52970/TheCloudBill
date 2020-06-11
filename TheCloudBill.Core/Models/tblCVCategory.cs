using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCVCategory
    {
        [Key]
        [Required]
        public long cvCategoryID { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvCategoryName { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string timeStemp { get; set; }
    }
}
