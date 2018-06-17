
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.Months")]
    [BasedOnRow(typeof(Entities.MonthsRow))]
    public class MonthsForm
    {
        public String Monthshort { get; set; }
        public String Monthlong { get; set; }
    }
}