
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.MediaType")]
    [BasedOnRow(typeof(Entities.MediaTypeRow))]
    public class MediaTypeForm
    {
        public String MediaTypeName { get; set; }
    }
}