using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace webNEOC.Models.TreeGrid
{
    public class TreeGridFilter
    {

    }

    [Table("vRegions")]
    public class Regions
    {
        [Key]
        [Column("Region", Order = 0)]
        [StringLength(50)]
        public string RegionName { get; set; }
    }
}