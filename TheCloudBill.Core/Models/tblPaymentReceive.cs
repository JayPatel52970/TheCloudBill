using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPaymentReceive
    {
        [Key]
        [Required]
        public long receiveID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string receiveDate { get; set; }
        public long receiveMyBankID { get; set; }
        public long receiveBankTrnID { get; set; }
        public long customerID { get; set; }
        public double amount { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string receiveNarration { get; set; }
        public long receiveBankID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string docURL { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        public DateTime timeStemp { get; set; }

    }
}
