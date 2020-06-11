using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCVaddress
    {
        [Key]
        [Required]
        public long cvAddID { get; set; }
        public long cvID { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvAddressName { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvAdd1 { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvAdd2 { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvCity { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvPincode { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvState { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvNation { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvAddressPhone { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string cvEmail { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string isDafault { get; set; }
        public long addType { get; set; }
        [MinLength(0)]
        public string narration { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [MaxLength(255)]
        public string timeStemp { get; set; }
    }
}
