
namespace webNEOC.Locations.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Locations.Province")]
    [BasedOnRow(typeof(Entities.ProvinceRow))]
    public class ProvinceColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 ProvinceId { get; set; }
        [EditLink]
        [DisplayName("Code")]
        public String Pcode { get; set; }
        [EditLink]
        [DisplayName("Province")]
        public String Pname { get; set; }
        [DisplayName("P Abr")]
        public String PAbrv { get; set; }
        public String Pcenter { get; set; }
        [Width(200)]
        [DisplayName("Area")]
        public Int32 AreaKmSqr { get; set; }
        [Width(200)]
        [DisplayName("No of districts")]
        public Int32 NoOfDistricts { get; set; }
        [EditLink(ItemType = "Locations.Region", IdField = "RegionId"), Width(150)]
        [LookupEditor(typeof(Entities.RegionRow)), QuickFilter]
        [DisplayName("Region")]
        public String Rname { get; set; }
    }
}