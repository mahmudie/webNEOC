
namespace webNEOC.Preparation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Preparation.InAccessible")]
    [BasedOnRow(typeof(Entities.InAccessibleRow))]
    public class InAccessibleForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }

        public DateTime ReportDate { get; set; }

        [Category("Inaccessibility Report")]
        public Int32 Target { get; set; }
        public Int16 MissedClusters { get; set; }
        public Int32 MissedChildren { get; set; }
        public Int16 PartiallyMissed { get; set; }
        public String PartiallyMissedName { get; set; }
        public Int16 FullyMissed { get; set; }
        public String FullyMissedName { get; set; }

        [LookupEditor(typeof(Lookup.Entities.InAcsCategoryRow)), DisplayName("Reason")]
        public Int16 InAcsCategoryId { get; set; }
        public String PlanToReduce { get; set; }
        public String Remarks { get; set; }
    }
}