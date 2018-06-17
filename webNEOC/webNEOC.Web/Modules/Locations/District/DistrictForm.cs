
namespace webNEOC.Locations.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Locations.District")]
    [BasedOnRow(typeof(Entities.DistrictRow))]
    public class DistrictForm
    {
        public String Dcode { get; set; }
        [LookupEditor(typeof(Entities.ProvinceRow))]
        public Int16 ProvinceId { get; set; }
        public String Dname { get; set; }
        public Int32 TotalPop { get; set; }
        public Int32 TargetPop { get; set; }
        public String Type { get; set; }
        public Int16 Priority { get; set; }
        public Int32 PopYear { get; set; }
    }
}