
namespace webNEOC.Locations.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Locations.District")]
    [BasedOnRow(typeof(Entities.DistrictRow))]
    public class DistrictColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(1, descending: true)]
        public Int16 DistrictId { get; set; }
        [EditLink]
        [DisplayName("Code")]
        public String Dcode { get; set; }
        [DisplayName("District")]
        public String Dname { get; set; }
        [Width(120)]
        [DisplayName("Total population")]
        public Int32 TotalPop { get; set; }
        [Width(120)]
        [DisplayName("Target population")]
        public Int32 TargetPop { get; set; }
        public String Type { get; set; }
        public Int16 Priority { get; set; }
        [Width(120)]
        [DisplayName("Population year")]
        public Int32 PopYear { get; set; }

        [EditLink(ItemType = "Locations.Province", IdField = "ProvinceId"), Width(150)]
        [LookupEditor(typeof(Entities.ProvinceRow)), QuickFilter]
        [DisplayName("Province")]
        public string Pname { get; set; }
    }
}