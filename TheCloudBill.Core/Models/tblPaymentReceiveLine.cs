using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPaymentReceiveLine
    {
        [Key]
        public long paymentReceiveID { get; set; }
        public long paymentReceiveInvoiceID { get; set; }
        public long paymentReceiveInvoiceTypeID { get; set; }
        public double paymentReceiveAmount { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        public DateTime timeStemp { get; set; }
    }
}
