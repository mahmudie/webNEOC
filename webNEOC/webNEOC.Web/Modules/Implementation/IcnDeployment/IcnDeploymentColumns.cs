
namespace webNEOC.Implementation.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Implementation.IcnDeployment")]
    [BasedOnRow(typeof(Entities.IcnDeploymentRow))]
    public class IcnDeploymentColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 IcnDeploymentId { get; set; }
        public String DistrictDcode { get; set; }
        public Int32 PlannedIcn { get; set; }
        public Int32 RecruitedIcn { get; set; }
        public Int32 RecruitedMale { get; set; }
        public Int32 RecruitedFemale { get; set; }
        public String IcnType { get; set; }
        public String RecruitmentType { get; set; }
        public String MonthMonthshort { get; set; }
        public Int32 Year { get; set; }
        public Int32 TenantId { get; set; }
    }
}