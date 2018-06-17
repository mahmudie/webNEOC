
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Part")]
    [BasedOnRow(typeof(Entities.PartRow))]
    public class PartColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(1, descending: true)]
        public Int16 PartId { get; set; }
        [EditLink]
        public String PartName { get; set; }
    }
}