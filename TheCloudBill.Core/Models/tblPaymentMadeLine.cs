using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPaymentMadeLine
    {
        [Key]
        [Required]
        public long paymentMadeLineID { get; set; }
        public long paymentMadeID { get; set; }
        public long paymentMadeBillID { get; set; }
        public long paymentMadeBillTypeID { get; set; }
        public double paymentMadeAmount { get; set; }
        public long paymentBankID { get; set; }
        public long paymenrBankTrnID { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        public DateTime timeStemp { get; set; }

    }
}
