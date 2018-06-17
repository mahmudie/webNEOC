
namespace webNEOC.Implementation.Forms
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

    [FormScript("Implementation.Communication")]
    [BasedOnRow(typeof(Entities.CommunicationRow))]
    public class CommunicationForm
    {
        [LookupEditor(typeof(LangRow))]
        public Int32 LanguageId { get; set; }
        [LookupEditor(typeof(MediaTypeRow))]
        public Int16 MediaTypeId { get; set; }
        [LookupEditor(typeof(MediaRow))]
        public Int32 MediaId { get; set; }
        public DateTime BroadCastDate { get; set; }
        [Required]
        public TimeSpan BroadCastTime { get; set; }
        public Int32 Duration { get; set; }
        [LookupEditor(typeof(DayPartRow))]
        public Int16 DaypartId { get; set; }
        public String Source { get; set; }
    }
}