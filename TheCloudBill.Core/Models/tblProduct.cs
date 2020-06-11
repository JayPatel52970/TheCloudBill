using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblProduct
    {
        [Key]
        [Required]
        public long productID { get; set; }
        public long pImageGroupId { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pDetail { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pHSNNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pUnit { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pCode { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pBarcode { get; set; }
        public double CGSTper { get; set; }
        public double SGSTPer { get; set; }
        public double IGSTPer { get; set; }
        public double pMinQTY { get; set; }
        public double pMaxQTY { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pNegative { get; set; }
        public double pOpeningStockQTY { get; set; }
        public double pOpeningStockRs { get; set; }
        public long pGroupID { get; set; }
        public long pCategoryID { get; set; }
        public long pShowInPoster { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pNameOnPoster { get; set; }
        [MinLength(0)]
        public string pDescriptionPoster { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
