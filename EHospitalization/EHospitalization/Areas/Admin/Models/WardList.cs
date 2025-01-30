using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class WardList
    {
        [Key]
        public int wardNo { get; set; }
        public int dNo { get; set; }
        public string gender { get; set; }
        public int tBeds { get; set; }
        public int resBeds { get; set; }
    }
}