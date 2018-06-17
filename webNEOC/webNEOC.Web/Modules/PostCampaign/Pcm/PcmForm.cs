
namespace webNEOC.PostCampaign.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("PostCampaign.Pcm")]
    [BasedOnRow(typeof(Entities.PcmRow))]
    public class PcmForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }

        [LookupEditor(typeof(Locations.Entities.ClusterRow), CascadeFrom = "DistrictId", CascadeField = "DistrictId")]
        public Int64 ClusterId { get; set; }

        public Int16 ClusterLevelId { get; set; }
        public Int16 CampaignTypeId { get; set; }
        public string ClusterCode { get; set; }
        public String Village { get; set; }

        [Category("Coverage")]
        public Int16 VistedHouses { get; set; }
        public Int16 T059m { get; set; }
        public Int16 V059m { get; set; }
        public Int16 T011Seen { get; set; }
        public Int16 Fm011HvFm { get; set; }
        public Int16 T1259Seen { get; set; }
        public Int16 Fm1259HvFm { get; set; }
        public Int16 TChildrenNoFm { get; set; }
        public Int16 R1TeamNoVisit { get; set; }

        [Category("Revisit (R)")]
        public Int16 R21 { get; set; }
        public Int16 R22 { get; set; }
        public Int16 R23 { get; set; }
        public Int16 R24 { get; set; }
        public Int16 R31 { get; set; }
        public Int16 R32 { get; set; }
        public Int16 R33 { get; set; }
        public Int16 R4NewBorn { get; set; }
        public Int16 R5Sleep { get; set; }
        public Int16 R6Sick { get; set; }
        public Int16 R7Other { get; set; }

        [Category("DM")]
        public Int16 DmCorrect { get; set; }
        public Int16 DmIncorrect { get; set; }
        public Int16 NoDm { get; set; }

        [Category("Heard")]
        public Int16 FmHeard { get; set; }
        public Int16 FmNotHeard { get; set; }

        [Category("Channel")]
        public Int16 Radio { get; set; }
        public Int16 Tv { get; set; }
        public Int16 MullahElders { get; set; }
        public Int16 Teacher { get; set; }
        public Int16 Chw { get; set; }
        public Int16 CElders { get; set; }
        public Int16 PbLeaflet { get; set; }
        public Int16 Sm { get; set; }
        public Int16 Other { get; set; }
        public Int16 ChVacByMonitor { get; set; }

        [Category("Percentage")]
        public Single RCallCoverage { get; set; }
        public Single Fm059Coverage { get; set; }
        public Single Fm011Coverage { get; set; }
        public Int16 InAcesChildren { get; set; }
    }
}