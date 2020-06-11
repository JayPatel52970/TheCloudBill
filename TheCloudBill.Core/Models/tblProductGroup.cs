using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblProductGroup
    {
        [Key]
        [Required]

        public long pGroupID { get; set; }

        [MinLength(0)]
        [StringLength(255)]
        public string pGroupName { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string pGroupColor { get; set; }
        public long pGroupDiscount { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        public DateTime timeStemp { get; set; }

    }
}
