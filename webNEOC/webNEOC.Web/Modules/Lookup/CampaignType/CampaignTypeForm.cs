
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.CampaignType")]
    [BasedOnRow(typeof(Entities.CampaignTypeRow))]
    public class CampaignTypeForm
    {
        public String CampaignName { get; set; }
    }
}