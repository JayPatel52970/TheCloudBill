using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblLedgers
    {
        [Key]
        [Required]
        public long legID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string legName { get; set; }
        public long legGroupID { get; set; }
        public long openingBalance { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string crDr { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string add1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string add2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string city { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pinCode { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string state { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string nation { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string phone { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string mobile { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string email { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string gstNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string lOther1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string lOther2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string lOther3 { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
