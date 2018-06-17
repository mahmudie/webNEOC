
namespace webNEOC.Implementation.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using webNEOC.Modules.Implementation;

    [ColumnsScript("Implementation.IcmTeam")]
    [BasedOnRow(typeof(Entities.IcmTeamRow))]
    public class IcmTeamColumns
    {
        [ModifyPermission(ImplementationPermissionKeys.IcmTeam.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,descending:false)]
        public Int32 IcmTeamId { get; set; }

        [EditLink, Width(120)]
        [DisplayName("Round")]
        public string RoundName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

     
        [DisplayName("Province"),Width(100)]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow))]
        public string Province { get; set; }

        [EditLink(ItemType = "Implementation.IcmTeam", IdField = "IcmTeamId")]
        [DisplayName("District"),Width(80)]
        public string DistrictDname { get; set; }
        [Width(80)]
        public string PartName { get; set; }
        [Width(80)]
        public string Cname { get; set; }
        public String MonitorName { get; set; }
        public String TeamMemberName { get; set; }
        [Width(40)]
        public string TeamNo { get; set; }
        public DateTime ReportDate { get; set; }
        public string MonitVisitTime { get; set; }
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