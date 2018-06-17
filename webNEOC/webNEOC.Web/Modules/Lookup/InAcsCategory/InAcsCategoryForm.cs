
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.InAcsCategory")]
    [BasedOnRow(typeof(Entities.InAcsCategoryRow))]
    public class InAcsCategoryForm
    {
        public String CategoryCode { get; set; }
        public String Description { get; set; }
    }
}