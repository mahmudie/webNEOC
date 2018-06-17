
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.DayPart")]
    [BasedOnRow(typeof(Entities.DayPartRow))]
    public class DayPartForm
    {
        public String Daypart { get; set; }
    }
}