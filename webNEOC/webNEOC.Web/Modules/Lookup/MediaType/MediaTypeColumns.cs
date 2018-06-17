
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.MediaType")]
    [BasedOnRow(typeof(Entities.MediaTypeRow))]
    public class MediaTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 MediaTypeId { get; set; }
        [EditLink]
        public String MediaTypeName { get; set; }
    }
}