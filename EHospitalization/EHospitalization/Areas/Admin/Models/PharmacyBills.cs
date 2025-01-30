using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class PharmacyBills
    {
        public int dNo { get; set; }
        public int pNo { get; set; }
        public int medicineNo { get; set; }
        public int tCharges { get; set; }
        public int arears { get; set; }
        public string status { get; set; }
    }
}