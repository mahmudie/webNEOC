
namespace webNEOC.Campaign.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Campaign.CampaignDay")]
    [BasedOnRow(typeof(Entities.CampaignDayRow))]
    public class CampaignDayForm
    {
        [Category("Campaign")]
        public Int16 RoundId { get; set; }
        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }

        public DateTime DateOfCampaign { get; set; }
        public String PemtremtManager { get; set; }

        [Category("Details")]
        [DailyVaccinationsEditor]
        public List<Entities.DailyVaccinationsRow> VaccinationList { get; set; }
    }
}