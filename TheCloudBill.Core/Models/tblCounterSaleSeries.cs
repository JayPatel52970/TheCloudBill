using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblCounterSaleSeries
    {
        [Key]
        [Required]
        public long counterSeriesID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string counterPrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string counterPostfix { get; set; }
        public long printFormatID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
