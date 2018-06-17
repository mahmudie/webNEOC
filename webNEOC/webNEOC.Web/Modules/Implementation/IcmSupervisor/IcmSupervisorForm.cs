
namespace webNEOC.Implementation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Implementation.IcmSupervisor")]
    [BasedOnRow(typeof(Entities.IcmSupervisorRow))]
    public class IcmSupervisorForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }

        public Int16 PartId { get; set; }

        [LookupEditor(typeof(Locations.Entities.ClusterRow), CascadeFrom = "DistrictId", CascadeField = "DistrictId")]
        public Int32 ClusterId { get; set; }
        public DateTime ReportDate { get; set; }

        [Category("Supervisor")]
        public String Supervisor { get; set; }
        public String MonitorName { get; set; }
        public Boolean IsSuperResidentOfArea { get; set; }
        public Boolean IsSuperTrained { get; set; }
        public Boolean IsSuperCarryOpv { get; set; }
        public Boolean IsSuperHasClearMap { get; set; }
        public Boolean IsSuperFillingHhChecklist { get; set; }
        public Boolean IsTransProviddToSuper { get; set; }
        public Int16 VehicletypeId { get; set; }
    }
}