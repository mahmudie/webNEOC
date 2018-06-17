
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.Round")]
    [BasedOnRow(typeof(Entities.RoundRow))]
    public class RoundForm
    {
        public Int16 CampaignTypeId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public String RoundName { get; set; }
    }
}