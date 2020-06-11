using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCompanyBank
    {
        [Key]
        [Required]
        public long compBankID { get; set; }
        public long compID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBankName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBankIFSC { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBankAC { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBankBranch { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compBankOPBal { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string isPrimaryBank { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
