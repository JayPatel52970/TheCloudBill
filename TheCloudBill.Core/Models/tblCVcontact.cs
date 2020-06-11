using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCVcontact
    {
        [Key]
        [Required]
        public long cvContID { get; set; }
        public long cvID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string salutation { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string fName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string mName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string lName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string position { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string email { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string phone { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string mobile { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cAdd1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cAdd2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cCity { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cPincode { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cState { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string cNation { get; set; }
        public long isDefault { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStamp { get; set; }
    }
}
