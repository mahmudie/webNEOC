
namespace webNEOC.Locations.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Locations.Region")]
    [BasedOnRow(typeof(Entities.RegionRow))]
    public class RegionForm
    {
        public String Rname { get; set; }
        public String RAbrv { get; set; }
    }
}