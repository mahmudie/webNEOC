
namespace webNEOC.Preparation.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using webNEOC.Modules.Implementation;

    [ColumnsScript("Preparation.InAccessible")]
    [BasedOnRow(typeof(Entities.InAccessibleRow))]
    public class InAccessibleColumns
    {
        [ModifyPermission(ImplementationPermissionKeys.IcmTeam.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,descending:false)]
        public Int32 InAccessibleId { get; set; }
        [EditLink, Width(150)]
        [DisplayName("Round")]
        public string RoundName { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [DisplayName("Province"),Width(100)]
        public string Province { get; set; }
        [EditLink, Width(100)]
        [DisplayName("District")]
        public string DistrictDname { get; set; }
        [Width(130)]


        public DateTime ReportDate { get; set; }

        public Int32 Target { get; set; }
        public Int16 MissedClusters { get; set; }
        public Int16 MissedChildren { get; set; }
        public Int16 PartiallyMissed { get; set; }
        public String PartiallyMissedName { get; set; }
        public Int16 FullyMissed { get; set; }
        public String FullyMissedName { get; set; }
        [DisplayName("Reason for inaccessibility")]
        public string Description { get; set; }
        public String PlanToReduce { get; set; }
        public String Remarks { get; set; }
    }
}