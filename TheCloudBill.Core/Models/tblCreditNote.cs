using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCreditNote
    {
        [Key]
        [Required]
        public long cdID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cdNo { get; set; }
        public long cdInvoiceID { get; set; }
        public long cdInvoiceFrom { get; set; }
        public long cdCustID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cdDate { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string reason { get; set; }
        public long subTotal { get; set; }
        public long CGST { get; set; }
        public long SGST { get; set; }
        public long IGST { get; set; }
        public long otherCrgsPer { get; set; }
        public long otherCrgs { get; set; }
        public long roundUp { get; set; }
        public long finalTotal { get; set; }
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
