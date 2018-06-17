
namespace webNEOC.Implementation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Implementation.Icn")]
    [BasedOnRow(typeof(Entities.IcnRow))]
    public class IcnForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }

        [LookupEditor(typeof(Locations.Entities.ClusterRow), CascadeFrom = "DistrictId", CascadeField = "DistrictId")]
        public Int64 ClusterId { get; set; }

        public String Area { get; set; }
        [Category("ICN Records")]
        public Int16 RegAbsent { get; set; }
        public Int16 VacAbsent { get; set; }
        public Int16 RegNss { get; set; }
        public Int16 VacNss { get; set; }
        public Int16 RegRefusal { get; set; }
        public Int16 VacRefusal { get; set; }
        public Int16 RegUnrecorded { get; set; }
        public Int16 VacUnrecorded { get; set; }
    }
}