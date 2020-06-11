using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCounterSale
    {
        [Key]
        [Required]
        public long counterSaleID { get; set; }
        public long counterSaleSeriesID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string counterSaleNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string modeTermOfPayment { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cDate { get; set; }
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
        public string cOtherField1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cOtherField2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cOtherField3 { get; set; }
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
