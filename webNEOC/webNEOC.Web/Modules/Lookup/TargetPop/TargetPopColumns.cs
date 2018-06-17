
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.TargetPop")]
    [BasedOnRow(typeof(Entities.TargetPopRow))]
    public class TargetPopColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(1, descending: true)]
        public Int32 TargetId { get; set; }
        [Width(130), LookupEditor(typeof(Locations.Entities.ProvinceRow)), QuickFilter]
        [DisplayName("Province")]
        public string Province { get; set; }

        [Width(120)]
        [DisplayName("District")]
        public string DistrictDname { get; set; }
        public Int32 YearId { get; set; }
        public Int64 Population { get; set; }
        public Int32 Target { get; set; }
        [DisplayName("LPDs")]
        public String LpDs { get; set; }
        public String Comment { get; set; }
    }
}