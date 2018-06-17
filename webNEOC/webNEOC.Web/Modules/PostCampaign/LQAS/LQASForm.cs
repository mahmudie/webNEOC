
namespace webNEOC.PostCampaign.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("PostCampaign.LQAS")]
    [BasedOnRow(typeof(Entities.LQASRow))]
    public class LQASForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }
           
        [Category("LQAS")]
        public Int16 LotNo { get; set; }

        public Int16 NoVaccChildren { get; set; }
        public String Comments { get; set; }
    }
}