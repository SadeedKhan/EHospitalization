using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class Reports
    {
        [Key]
        public int pNo { get; set; }
        public int dNo { get; set; }
        public int testNo { get; set; }
        public DateTime Date1 { get; set; }
        public string results { get; set; }
        public string status { get; set; }

    }
}