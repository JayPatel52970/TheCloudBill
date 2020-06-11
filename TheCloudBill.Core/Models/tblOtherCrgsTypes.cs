using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblOtherCrgsTypes
    {
        [Key]
        [Required]
        public long otherCrgTypeID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string otherCrgName { get; set; }
        public long otherCrgTaxPer { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string narration { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
