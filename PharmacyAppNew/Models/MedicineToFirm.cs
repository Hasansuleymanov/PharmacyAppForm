﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppNew.Models
{
    public class MedicineToFirm
    {
        public int Id { get; set; }
        public int MedicineId { get; set; }
        public int FirmId { get; set;}
        public virtual Firm Firm { get; set; }
    }
}
