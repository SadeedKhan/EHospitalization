using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHospitalization.Areas.Admin.Models.Base
{
    public class BaseModel
    {
        public DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public DateTime modifiedDate { get; set; }
        public string modifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
    }
}