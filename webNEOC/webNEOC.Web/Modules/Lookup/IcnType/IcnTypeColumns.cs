
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.IcnType")]
    [BasedOnRow(typeof(Entities.IcnTypeRow))]
    public class IcnTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 IcnTypeId { get; set; }
        [EditLink]
        public String IcnType { get; set; }
    }
}