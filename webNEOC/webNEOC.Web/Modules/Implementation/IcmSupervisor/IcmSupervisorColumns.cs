
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

    [ColumnsScript("Implementation.IcmSupervisor")]
    [BasedOnRow(typeof(Entities.IcmSupervisorRow))]
    public class IcmSupervisorColumns
    {
        [ModifyPermission(ImplementationPermissionKeys.IcmSupervisor.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,descending:false)]
        public Int32 IcmSupervisorId { get; set; }


        [EditLink, Width(120)]
        [DisplayName("Round")]
        public string RoundName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }


        [DisplayName("Province"),Width(100)]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow))]
        public string Province { get; set; }

        [EditLink(ItemType = "Implementation.IcmTeam", IdField = "IcmTeamId")]
        [DisplayName("District"),Width(100)]
        public string DistrictDname { get; set; }
        [DisplayName("Part"), Width(80)]
        public string PartPartName { get; set; }
        [Width(80)]
        public String Cname { get; set; }
        public DateTime ReportDate { get; set; }
        [Width(120)]
        public String Supervisor { get; set; }
        [Width(120)]
        public String MonitorName { get; set; }
        public Boolean IsSuperResidentOfArea { get; set; }
        public Boolean IsSuperTrained { get; set; }
        public Boolean IsSuperCarryOpv { get; set; }
        public Boolean IsSuperHasClearMap { get; set; }
        public Boolean IsSuperFillingHhChecklist { get; set; }
        public Boolean IsTransProviddToSuper { get; set; }
        [DisplayName("Vehicle")]
        public string VehicletypeTypename { get; set; }
    }
}