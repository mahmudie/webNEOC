
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.Days")]
    [BasedOnRow(typeof(Entities.DaysRow))]
    public class DaysForm
    {
        public String DayName { get; set; }
    }
}