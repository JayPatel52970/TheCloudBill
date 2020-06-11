using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblDeliveryChallanProductDetail
    {
        [Key]
        public long delChallanID { get; set; }
        public long customerID { get; set; }
        public long custFromtbl { get; set; }
        public long productID { get; set; }
        public long QTY { get; set; }
        public long Rate { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
