using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webNEOC.Models
{
    public class Formsubmission
    {
        [Key]
        public Int32 FormsubmissionId { get; set; }
        public String Form { get; set; }
        public Int64? TotalRecorded { get; set; }
        public Int32? TotalUnapproved { get; set; }
        public String Url { get; set; }
        public Boolean Active { get; set; }
    }
}