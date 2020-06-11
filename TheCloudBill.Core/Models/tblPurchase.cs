using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPurchase
    {
        [Key]
        [Required]
        public long purInvoiceID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string purInvoiceNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string deliveryNoteNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string quotationNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string challanNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string orderNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string modeTermOfPayment { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pDate { get; set; }
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
        public string ewayBillNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string transporterName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string transporterGSTNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string transporterReceiptNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string VehiceNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pOtherField1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pOtherField2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pOtherField3 { get; set; }
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
