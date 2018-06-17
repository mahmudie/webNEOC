
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.IcnType")]
    [BasedOnRow(typeof(Entities.IcnTypeRow))]
    public class IcnTypeForm
    {
        public String IcnType { get; set; }
    }
}