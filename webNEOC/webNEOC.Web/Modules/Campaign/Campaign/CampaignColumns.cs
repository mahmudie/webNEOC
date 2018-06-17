
namespace webNEOC.Campaign.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Campaign.Campaign")]
    [BasedOnRow(typeof(Entities.CampaignRow))]
    public class CampaignColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CampaignId { get; set; }
        [EditLink]
        public String CampgaignName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Int16 RoundId { get; set; }
        public DateTime DateCreated { get; set; }
        public String Comment { get; set; }
        public Boolean Status { get; set; }
    }
}