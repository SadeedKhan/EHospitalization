using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models
{
    public class OperationTheater
    {
        public int dNo { get; set; }
        public int userNo { get; set; }
        public int pNo { get; set; }
        public string surjery { get; set; }
        public string status { get; set; }
    }
}