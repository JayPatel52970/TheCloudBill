using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblBillOfSupplySeries
    {
        [Required]
        [Key]
        public long billSeriesID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string billOfSupplyPrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string billOfSupplyPostfix { get; set; }
        public long printFormatID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string compID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string userID { get; set; }
    }
}
