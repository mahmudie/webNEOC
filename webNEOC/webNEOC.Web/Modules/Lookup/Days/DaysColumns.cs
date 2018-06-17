
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Days")]
    [BasedOnRow(typeof(Entities.DaysRow))]
    public class DaysColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 DayId { get; set; }
        [EditLink]
        public String DayName { get; set; }
    }
}