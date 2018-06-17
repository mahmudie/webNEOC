
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.RecruitmentType")]
    [BasedOnRow(typeof(Entities.RecruitmentTypeRow))]
    public class RecruitmentTypeForm
    {
        public String RecruitmentType { get; set; }
    }
}