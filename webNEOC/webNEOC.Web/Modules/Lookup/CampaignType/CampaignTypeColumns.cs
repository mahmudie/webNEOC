
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.CampaignType")]
    [BasedOnRow(typeof(Entities.CampaignTypeRow))]
    public class CampaignTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(1, descending: false)]
        public Int16 CampaignTypeId { get; set; }
        [EditLink]
        public String CampaignName { get; set; }
    }
}