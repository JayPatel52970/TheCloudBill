using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCompAccountSetup
    {
        [Key]
        [Required]
        public long compSetupID { get; set; }
        public long compID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string creditNotePrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string creditNotePostfix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string debitNotePrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string debitNotePostfix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string purchasePrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string purchasePostfix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string receiptPrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string receiptPostfix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string paymentPrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string paymentPostfix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string quotationPrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string quotationPostfix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string deliveryChallanPrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string deliveryChallanPostfix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string tempPurchasePrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string tempPurchasePostfix { get; set; }

    }
}
