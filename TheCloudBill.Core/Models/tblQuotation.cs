using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblQuotation
    {
        [Key]
        [Required]
        public long quotationID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string quotationNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string orderNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string modeTermOfPayment { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string qDate { get; set; }
        public long customerID { get; set; }
        public long custFromtbl { get; set; }
        public long subTotal { get; set; }
        public long otherCrgID { get; set; }
        public long CGST { get; set; }
        public long SGST { get; set; }
        public long IGST { get; set; }
        public long Discount { get; set; }
        public long roundUp { get; set; }
        public long FinalTotal { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string qOtherField1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string qOtherField2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string qOtherField3 { get; set; }
        [MinLength(0)]
        public string note { get; set; }
        [MinLength(0)]
        public string privateNote { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
