
namespace webNEOC.Implementation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Implementation.Implementation")]
    [BasedOnRow(typeof(Entities.IcnDeploymentRow))]
    public class IcnDeploymentForm
    {
        public Int16 DistrictId { get; set; }
        public Int32 PlannedIcn { get; set; }
        public Int32 RecruitedIcn { get; set; }
        public Int32 RecruitedMale { get; set; }
        public Int32 RecruitedFemale { get; set; }
        public Int16 IcnTypeId { get; set; }
        public Int16 RecruitmentTypeId { get; set; }
        public Int32 MonthId { get; set; }
        public Int32 Year { get; set; }
        public Int32 TenantId { get; set; }
    }
}