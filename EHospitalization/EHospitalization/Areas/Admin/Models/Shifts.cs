using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class Shifts
    {
        [Key]
        public int shiftNo { get; set; }
        public string shiftName { get; set; }
    }
}