
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.Part")]
    [BasedOnRow(typeof(Entities.PartRow))]
    public class PartForm
    {
        public String PartName { get; set; }
    }
}