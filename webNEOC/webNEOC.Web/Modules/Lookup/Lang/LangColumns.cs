
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Lang")]
    [BasedOnRow(typeof(Entities.LangRow))]
    public class LangColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,descending:false)]
        public Int32 LanguageId { get; set; }
        [EditLink]
        public String LanguageName { get; set; }
    }
}