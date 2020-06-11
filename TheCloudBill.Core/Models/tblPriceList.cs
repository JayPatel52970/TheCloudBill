using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPriceList
    {
        [Key]
        public long productID { get; set; }
        public double pMRP { get; set; }
        public double pRateA { get; set; }
        public double pRateB { get; set; }
        public double pRateC { get; set; }
        public double pDiscA { get; set; }
        public double pDiscB { get; set; }
        public double pDiscC { get; set; }
        public double purRate { get; set; }
        public long pGroupID { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
