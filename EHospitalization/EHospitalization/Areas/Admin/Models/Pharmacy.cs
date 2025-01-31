using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class Pharmacy
    {
        [Key]
        public int medicineNo { get; set; }
        public string medcnName { get; set; }
        public int charges { get; set; }
        public string status { get; set; }

    }
}