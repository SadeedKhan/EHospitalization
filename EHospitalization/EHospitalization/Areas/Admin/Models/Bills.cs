using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class Bills
    {
        [Key]
        public int billNo { get; set; }
        public int pNo { get; set; }
        public string particulars { get; set; }
        public int charges { get; set; }
        public int discount { get; set; }
        public DateTime date { get; set; }
        public string paymentMthd { get; set; }
        public DateTime admitDate  { get; set; }
        public DateTime dischargeDate { get; set; }

    }
}