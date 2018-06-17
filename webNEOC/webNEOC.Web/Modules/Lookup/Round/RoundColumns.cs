
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Round")]
    [BasedOnRow(typeof(Entities.RoundRow))]
    public class RoundColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1),Width(40)]
        public Int16 RoundId { get; set; }
        [EditLink(ItemType = "Lookup.CampaignType", IdField = "CampaignTypeId"), Width(200)]
        [LookupEditor(typeof(Entities.CampaignTypeRow)), QuickFilter]
        [DisplayName("Campaign Type")]
        public String CampaignName { get; set; }
        [Width(150)]
        public DateTime DateFrom { get; set; }
        [Width(150)]
        public DateTime DateTo { get; set; }
        [Width(300)]
        public String RoundName { get; set; }
    }
}