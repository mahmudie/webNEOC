
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Status")]
    [BasedOnRow(typeof(Entities.StatusRow))]
    public class StatusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(1, descending: false)]
        public Int16 StatusId { get; set; }
        [EditLink]
        public String StatusName { get; set; }
    }
}