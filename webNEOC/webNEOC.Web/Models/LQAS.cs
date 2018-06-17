using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace webNEOC.Models
{
    [Table("whoLQAS")]
    public class LQAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Region { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Province { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string District { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Round { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Comments { get; set; }

        [Key]
        [Column(Order = 5)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 6)]

        public int Month { get; set; }

        public string MonthName { get; set; }
        public Int16? LotNo { get; set; }
    }

}