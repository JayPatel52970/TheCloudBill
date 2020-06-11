using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblPUnits
    {
        [Key]
        public long pUnitID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string unit { get; set; }

    }
}
