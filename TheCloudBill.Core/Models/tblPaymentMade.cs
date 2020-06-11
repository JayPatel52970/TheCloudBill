using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPaymentMade
    {
        [Key]
        [Required]
        public long paymentMadeID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string paymentMadeNo { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string paymentMadeDate { get; set; }
        public long paymentMadeMyBankID { get; set; }
        public long paymentMadeMyBankTrnID { get; set; }
        public long customerID { get; set; }
        public long paymentMadeAmount { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string paymentMadeNarration { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string docURL { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        public DateTime timeStemp { get; set; }
    }
}
