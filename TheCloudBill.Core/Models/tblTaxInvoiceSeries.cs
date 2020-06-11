using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblTaxInvoiceSeries
    {
        [Key]
        [Required]
        public long taxSeriesID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string texInvoicePrefix { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string texInvoicePostfix { get; set; }
        public long printFormatID { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
