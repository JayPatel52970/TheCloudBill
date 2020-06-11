using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCompPreference
    {
        [Key]
        [Required]
        public long compID { get; set; }
        [MinLength(0)]
        public string compTerms1 { get; set; }
        [MinLength(0)]
        public string compTerms2 { get; set; }
        [MinLength(0)]
        public string compTerms3 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compDateFormat { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compDecimal { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compOnlineAPI { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compOnlineUserName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compOnlinePassword { get; set; }
        public long nightMode { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userID { get; set; }

    }
}
