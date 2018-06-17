
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Months")]
    [BasedOnRow(typeof(Entities.MonthsRow))]
    public class MonthsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MonthId { get; set; }
        [EditLink]
        public String Monthshort { get; set; }
        public String Monthlong { get; set; }
    }
}