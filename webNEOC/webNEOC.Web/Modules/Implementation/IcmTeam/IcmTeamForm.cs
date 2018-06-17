
namespace webNEOC.Implementation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Implementation.IcmTeam")]
    [BasedOnRow(typeof(Entities.IcmTeamRow))]
    public class IcmTeamForm
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


        [Category("Monitor")]
        public String MonitorName { get; set; }
        public String TeamMemberName { get; set; }
        public string TeamNo { get; set; }
        public DateTime ReportDate { get; set; }
        public string MonitVisitTime { get; set; }

        [Category("Readiness")]
        public Boolean IsTeamResident { get; set; }
        public Boolean BothTrained { get; set; }
        public Boolean HaveClearMap { get; set; }
        public Boolean AbleKnowArea { get; set; }
        public Boolean TeamGHtoH { get; set; }
        public Boolean OpvVialsKeptDry { get; set; }
        public Boolean UsingOpvStage3or4 { get; set; }
        public Boolean AskingAbout011C { get; set; }
        public Boolean AskingforGnssc { get; set; }
        public Boolean RecNameOfAbsentRefC { get; set; }
        public Boolean AskingAfpCases { get; set; }
        public Boolean VistedBySupervisor { get; set; }
        public Boolean TeamHasAchw { get; set; }
        public Boolean TeamHasFemale { get; set; }
        public Boolean SocMobAccompanyTeam { get; set; }
    }
}