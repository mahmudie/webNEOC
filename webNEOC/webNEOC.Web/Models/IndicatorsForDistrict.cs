using webNEOC.Controllers.Testkeys;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace webNEOC.Models
{
    [Table("vDistrict")]
    public class IndicatorsForDistrict
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
        public DateTime DateFrom { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DateTo { get; set; }

        [Key]
        [Column(Order = 5)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 6)]

        public string Month { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string Round { get; set; }

        public string ShortName { get; set; }

        public string Indicator { get; set; }
        public string Form { get; set; }
        public string Measure { get; set; }

        public double? Numerator { get; set; }

        public double? Denominator { get; set; }

        [Key]
        [Column(Order = 8)]
        public Int16 RegionId { get; set; }

        [Key]
        [Column(Order = 9)]
        public Int16 ProvinceId { get; set; }

        [Key]
        [Column(Order = 10)]
        public Int16 DistrictId { get; set; }

        public Int16 RoundId { get; set; }

        public string CampaignType { get; set; }
    }
    [Table("Region")]
    public class Region
    {

        [Key]
        public Int16 RegionId { get; set; }

        [Column(Order = 1)]
        [StringLength(30)]
        public string Rname { get; set; }

        [Column(Order = 2)]
        [StringLength(30)]
        public string RAbrv { get; set; }

    }

    [Table("Province")]
    public class Province
    {
        [Key]
        [Column(Order = 0)]
        public Int16 ProvinceId { get; set; }

        [Column(Order = 1)]
        public Int16 RegionId { get; set; }

        [Column(Order = 2)]
        [StringLength(30)]
        public string Pname { get; set; }

    }

    [Table("District")]
    public class District
    {
        [Key]
        [Column(Order = 0)]
        public Int16 DistrictId { get; set; }

        [Column(Order = 1)]
        public Int16 ProvinceId { get; set; }

        [Column(Order = 2)]
        [StringLength(30)]
        public string Dname { get; set; }
    }

    [Table("vRound")]
    public class Round
    {
        [Key]
        [Column(Order = 0)]
        public Int16 RoundId { get; set; }

        [Column("ReportRoundName",Order =1)]
        [StringLength(50)]
        public string ReportRoundName { get; set; }
    }

    [Table("vProvince")]
    public class IndicatorsForProvince
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
        [Column(Order = 3)]
        public DateTime DateFrom { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DateTo { get; set; }

        [Key]
        [Column(Order = 5)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 6)]

        public int Month { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string Round { get; set; }

        public string ShortName { get; set; }

        public string Indicator { get; set; }
        public string Form { get; set; }
        public string Measure { get; set; }

        public double? Numerator { get; set; }

        public double? Denominator { get; set; }

        [Key]
        [Column(Order = 8)]
        public Int16 RegionId { get; set; }

        [Key]
        [Column(Order = 9)]
        public Int16 ProvinceId { get; set; }

        public Int16 RoundId { get; set; }
    }

}