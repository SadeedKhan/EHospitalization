using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.XPath;

namespace EHospitalization.Areas.Admin.Models
{
    public class TestList
    {
        [Key]
        public int testNo { get; set; }
        public string testName  { get; set; }
        public int charges { get; set; }
        public DateTime rsltTime  { get; set; }
        public string status { get; set; }

    }
}