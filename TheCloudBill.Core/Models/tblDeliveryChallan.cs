using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblDeliveryChallan
    {
        [Key]
        [Required]
        public long delChallanID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string delChallanNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string orderNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string dcDate { get; set; }
        public long customerID { get; set; }
        public long custFromtbl { get; set; }
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
        public string dcOtherField1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string dcOtherField2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string dcOtherField3 { get; set; }
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
