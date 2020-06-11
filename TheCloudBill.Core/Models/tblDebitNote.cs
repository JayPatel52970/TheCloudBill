using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblDebitNote
    {
        [Key]
        [Required]
        public long dnID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string dnNo { get; set; }
        public long dnInvoiceID { get; set; }
        public long dnInvoiceFrom { get; set; }
        public long dnCustID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string dnDate { get; set; }
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
        [MinLength(0)]
        [StringLength(255)]
        public string docURL { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }

    }
}
