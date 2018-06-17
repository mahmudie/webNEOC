
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.Lang")]
    [BasedOnRow(typeof(Entities.LangRow))]
    public class LangForm
    {
        public String LanguageName { get; set; }
    }
}