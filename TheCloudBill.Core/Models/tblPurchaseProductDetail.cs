using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPurchaseProductDetail
    {
        [Key]
        public long purInvoiceID { get; set; }
        public long customerID { get; set; }
        public long custFromtbl { get; set; }
        public long productID { get; set; }
        public long QTY { get; set; }
        public long Rate { get; set; }
        public long discountPer { get; set; }
        public long discount { get; set; }
        public long CGSTPer { get; set; }
        public long CGST { get; set; }
        public long SGSTPer { get; set; }
        public long SGST { get; set; }
        public long IGSTPer { get; set; }
        public long IGST { get; set; }
        public long lineTotal { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
