
namespace webNEOC.Implementation.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using webNEOC.Administration.Entities;
    using webNEOC.Lookup.Entities;

    [ColumnsScript("Implementation.Communication")]
    [BasedOnRow(typeof(Entities.CommunicationRow))]
    public class CommunicationColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,descending:false)]
        public Int32 CommunicationId { get; set; }
        [Width(120)]
        [QuickFilter,LookupEditor(typeof(LangRow))]
        public String LanguageLanguageName { get; set; }
        [Width(120)]
        [QuickFilter,LookupEditor(typeof(MediaTypeRow))]
        public String MediaTypeMediaTypeName { get; set; }
        [Width(200)]
        [QuickFilter,LookupEditor(typeof(MediaRow))]
        public String MediaMediaName { get; set; }
        [Width(120)]
        public DateTime BroadCastDate { get; set; }
        [Width(150)]
        public TimeSpan BroadCastTime { get; set; }
        [Width(150)]
        public Int32 Duration { get; set; }
        [Width(120)]
        [QuickFilter,LookupEditor(typeof(DayPartRow))]
        public String Daypart { get; set; }
        [Width(200),EditLink]
        public String Source { get; set; }
    }
}