
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using webNEOC.Locations.Entities;

    [FormScript("Lookup.TargetPop")]
    [BasedOnRow(typeof(Entities.TargetPopRow))]
    public class TargetPopForm
    {
        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }
        public Int32 YearId { get; set; }
        public Int64 Population { get; set; }
        public Int32 Target { get; set; }
        public String LpDs { get; set; }
        public String Comment { get; set; }
    }
}