using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCompAddress
    {
        [Key]
        [Required]
        public long compAddID { get; set; }
        public long compID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string AddressName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string Add1 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string Add2 { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string City { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string Pincode { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string State { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string Nation { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string AddressPhone { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string Email { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string isDafault { get; set; }
        public long addType { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
