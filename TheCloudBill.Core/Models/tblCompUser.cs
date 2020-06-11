using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCompUser
    {
        [Key]
        [Required]
        public long userID { get; set; }
        public long compID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userPhone { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userEmail { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userFB { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userInsta { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userRole { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
