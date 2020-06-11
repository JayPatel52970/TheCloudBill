using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblFiles
    {
        [Key]
        [Required]
        public long fileID { get; set; }
        public long fileGroupId { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string filePath { get; set; }
        [MinLength(0)]
        public string fileSecurityKey { get; set; }
        public long type { get; set; }
        public long userID { get; set; }
        public long compID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
