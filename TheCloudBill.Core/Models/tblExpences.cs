using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblExpences
    {
        [Key]
        [Required]
        public long expID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string expNo { get; set; }
        public long expNameID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string expDate { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string expName { get; set; }
        public double expAmount { get; set; }
        public double expCGST { get; set; }
        public double expSGST { get; set; }
        public double expIGST { get; set; }
        public double expTotal { get; set; }
        [MinLength(0)]
        public string expNarration { get; set; }
        public long IsPaid { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string expMyBankID { get; set; }
        public long expMyBankTrnID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string eOther1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string eOther2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string eOther3 { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }



    }
}
