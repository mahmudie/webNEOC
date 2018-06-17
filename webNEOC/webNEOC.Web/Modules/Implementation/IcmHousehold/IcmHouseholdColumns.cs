
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

    [ColumnsScript("Implementation.IcmHousehold")]
    [BasedOnRow(typeof(Entities.IcmHouseholdRow))]
    public class IcmHouseholdColumns
    {
        [ModifyPermission(ImplementationPermissionKeys.IcmHousehold.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,descending:false)]
        public Int32 IcmHouseholdId { get; set; }
        [EditLink, Width(120)]
        [DisplayName("Round")]
        public string RoundName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [DisplayName("Province"),Width(100)]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow))]
        public string Province { get; set; }
        [DisplayName("District"),Width(80)]
        public string DistrictDname { get; set; }

        [DisplayName("Part"),Width(80)]
        public string PartPartName { get; set; }

        [DisplayName("Cluster"),Width(80)]
        public string Cname { get; set; }
        [Width(80)]
        public DateTime ReportDate { get; set; }
        public String Village { get; set; }
        public String Supervisor { get; set; }
        public Int16 NoHhVisited { get; set; }
        public Int16 NoChildrenInVisitedHh { get; set; }
        public Int16 NoVaccInRecall { get; set; }
        public Int16 MissedChildren { get; set; }
        public Int16 TeamNotCome { get; set; }
        public Int16 ChildrenAbsent { get; set; }
        public Int16 NewbornSsChildren { get; set; }
        public Int16 NoRefused { get; set; }
        public Int16 NoIgnoredbyTeam { get; set; }
        public Int16 TotUn5SeenByMonit { get; set; }
        public Int16 NoSeenWithFingerMark { get; set; }
        public Int16 NoCorrect { get; set; }
        public Int16 NoIncorrect { get; set; }
        public Int16 NoNotMarked { get; set; }
        public Int16 NoChildFoundMissedRecall { get; set; }
        public Int16 NoChildRecBackOfTally { get; set; }
    }
}