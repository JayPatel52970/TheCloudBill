using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblClientVendor
    {
        [Required]
        [Key]
        public long cvID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvCompName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvCompLogoID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvPhone { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvEmail { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvFax { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvWebsite { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvCompType { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvGSTNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvPanNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvAadharNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvCreditLimit { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cvTermsPayment { get; set; }
        public long cvCategoryID { get; set; }
        public long clientVendor { get; set; }
        public long cvOpeningBalance { get; set; }
        public long crdr { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }

    }
}
