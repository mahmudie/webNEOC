
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.Media")]
    [BasedOnRow(typeof(Entities.MediaRow))]
    public class MediaForm
    {
        public String MediaName { get; set; }
    }
}