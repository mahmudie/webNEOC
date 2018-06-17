
namespace webNEOC.Campaign.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Campaign.CampaignDay")]
    [BasedOnRow(typeof(Entities.CampaignDayRow))]
    public class CampaignDayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CampaignDayId { get; set; }
        [EditLink(ItemType = "Lookup.Round", IdField = "RoundId"),Width(200)]
        [DisplayName("Round")]
        public string RoundName { get; set; }

        [DisplayName("Province")]
        public string ProvincePname { get; set; }
        [DisplayName("District")]
        public string DistrictDname { get; set; }
        public DateTime DateOfCampaign { get; set; }
        [EditLink]
        public String PemtremtManager { get; set; }
    }
}