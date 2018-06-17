
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.InAcsCategory")]
    [BasedOnRow(typeof(Entities.InAcsCategoryRow))]
    public class InAcsCategoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 InAcsCategoryId { get; set; }
        [Width(550)]
        public String CategoryCode { get; set; }
        [Width(400)]
        public String Description { get; set; }
    }
}