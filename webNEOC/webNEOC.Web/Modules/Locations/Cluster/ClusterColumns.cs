
namespace webNEOC.Locations.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Locations.Cluster")]
    [BasedOnRow(typeof(Entities.ClusterRow))]
    public class ClusterColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        [SortOrder(1,descending:false)]
        public Int32 ClusterId { get; set; }
        [EditLink]
        [DisplayName("Code")]
        public String Ccode { get; set; }
        [DisplayName("Cluster")]
        public String Cname { get; set; }
        [Width(120)]
        public Int32 Targetpop { get; set; }

        [Width(130), LookupEditor(typeof(Locations.Entities.ProvinceRow)), QuickFilter]
        [DisplayName("Province")]
        public string Province { get; set; }

        [Width(120), LookupEditor(typeof(Locations.Entities.DistrictRow))]
        [QuickFilter,QuickFilterOption("cascadeFrom", "ProvinceId")]
        [DisplayName("District")]
        public string Dname { get; set; }

    }
}