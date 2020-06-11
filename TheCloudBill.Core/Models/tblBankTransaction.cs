using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblBankTransaction
    {
        [Required]
        [Key]
        public long bnkTrnID { get; set; }
        public long bankID { get; set; }
        public long fromAccountID { get; set; }
        public long fromAccountTypeID { get; set; }
        public long ToAccountID { get; set; }
        public long ToAccountTypeID { get; set; }
        public long Amount { get; set; }
        public DateTime trnDate { get; set; }
        [MinLength(0)]
        public string Narration { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
