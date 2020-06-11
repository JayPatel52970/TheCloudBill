using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCVBanks
    {
        [Key]
        [Required]
        public long cvBankID { get; set; }
        public long cvID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string bankName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string bankAC { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string bankBranch { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string bankISFC { get; set; }
        public long isDefault { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }

    }
}
