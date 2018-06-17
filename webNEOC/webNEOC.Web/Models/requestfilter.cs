using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webNEOC.Models
{
    public class requestfilter
    {
        [RequiredAttribute]
        [Display(Name = "Region")]
        public Int16 Region { get; set; }

        [RequiredAttribute]
        [Display(Name = "Province")]
        public Int16 Province { get; set; }

        [RequiredAttribute]
        [Display(Name = "District")]
        public Int16 District { get; set; }

        [RequiredAttribute]
        [Display(Name = "Round")]
        public Int16 Round { get; set; }

        [RequiredAttribute]
        [Display(Name = "Measure")]
        public string Measure { get; set; }

        [RequiredAttribute]
        [Display(Name = "Year")]
        public string Year { get; set; }

        [RequiredAttribute]
        [Display(Name = "Filter")]
        public string Filter { get; set; }
    }

    public class regionFilter
    {
        [RequiredAttribute]
        [Display(Name = "Region")]
        public Int16 Region { get; set; }

        [RequiredAttribute]
        [Display(Name = "Year")]
        public string Year { get; set; }

        [RequiredAttribute]
        [Display(Name = "Round")]
        public string Round { get; set; }

    }
}