
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.DayPart")]
    [BasedOnRow(typeof(Entities.DayPartRow))]
    public class DayPartColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 DaypartId { get; set; }
        public String Daypart { get; set; }
    }
}