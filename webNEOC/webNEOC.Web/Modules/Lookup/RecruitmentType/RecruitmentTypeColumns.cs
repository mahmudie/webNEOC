
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.RecruitmentType")]
    [BasedOnRow(typeof(Entities.RecruitmentTypeRow))]
    public class RecruitmentTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 RecruitmentTypeId { get; set; }
        [EditLink]
        public String RecruitmentType { get; set; }
    }
}