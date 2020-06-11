﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCloudBill.Core.Models
{
    public class tblLedgerGroup
    {
        [Key]
        [Required]
        public long lgID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string lgName { get; set; }
        [MinLength(0)]
        public string narration { get; set; }
        public long compID { get; set; }
        public long userID { get; set; }
        [MinLength(0)]
        [StringLength(255)]
        public string timeStemp { get; set; }
    }
}
