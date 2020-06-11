using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCompany
    {
        [Key]
        [Required]
        public long compID { get; set; }
        public long compLogoId { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBillAdd1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBillAdd2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBillCity { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBillPincode { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBillState { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBillNation { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBillPhoneNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compShipAdd1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compShipAdd2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compShipCity { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compShipPincode { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compShipState { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compShipNation { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compShipPhoneNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compGSTReg { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compGSTNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compEmail { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compPhone { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compWebsite { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compFacebook { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compInstagram { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }

    }
}
