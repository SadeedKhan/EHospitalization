using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class Department
    {
        [Key]
        public int dNo { get; set; }
        public string dName { get; set; }
        public string  incharge { get; set; }

    }
}