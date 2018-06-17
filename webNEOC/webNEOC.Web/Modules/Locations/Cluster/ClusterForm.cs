
namespace webNEOC.Locations.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Locations.Cluster")]
    [BasedOnRow(typeof(Entities.ClusterRow))]
    public class ClusterForm
    {
        [LookupEditor(typeof(Entities.ProvinceRow)),DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }

        [DisplayName("Code")]
        public String Ccode { get; set; }
        [DisplayName("Cluster")]
        public String Cname { get; set; }
        [DisplayName("Target Cases")]
        public Int32 Targetpop { get; set; }
    }
}