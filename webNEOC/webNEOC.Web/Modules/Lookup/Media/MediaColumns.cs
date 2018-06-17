
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Media")]
    [BasedOnRow(typeof(Entities.MediaRow))]
    public class MediaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MediaId { get; set; }
        [EditLink]
        public String MediaName { get; set; }
    }
}