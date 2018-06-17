
namespace webNEOC.CVA.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("CVA.PTTS")]
    [BasedOnRow(typeof(Entities.PTTSRow))]
    public class PTTSColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1)]
        public Int64 PttsId { get; set; }

        [Width(130), LookupEditor(typeof(Locations.Entities.ProvinceRow)), QuickFilter]
        [DisplayName("Province")]
        public string ProvName { get; set; }

        [Width(120), LookupEditor(typeof(Locations.Entities.DistrictRow))]
        [QuickFilter, QuickFilterOption("cascadeFrom", "ProvinceId")]
        [DisplayName("District")]
        public string DistrictDname { get; set; }

        public Int32 Year { get; set; }
        public String MonthName { get; set; }
        [Width(80)]
        public String Type { get; set; }
        public String Subtype { get; set; }
        public Int16 NoOfTeam { get; set; }
        [Width(200)]
        public String TeamName { get; set; }
        public Int32 Boys011 { get; set; }
        public Int32 Girls011 { get; set; }
        public Int32 Boys1259 { get; set; }
        public Int32 Girls1259 { get; set; }
        public String Remarks { get; set; }
    }
}