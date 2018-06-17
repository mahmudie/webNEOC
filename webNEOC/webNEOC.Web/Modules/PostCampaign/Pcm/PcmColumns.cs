
namespace webNEOC.PostCampaign.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using webNEOC.Modules.PostCampaign;

    [ColumnsScript("PostCampaign.Pcm")]
    [BasedOnRow(typeof(Entities.PcmRow))]
    public class PcmColumns
    {
        [ModifyPermission(PostCampaignPermissionKeys.Pcm.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(1, descending: true)]
        public Int32 PcmId { get; set; }

        [EditLink,Width(120)]
        [DisplayName("Round")]
        public string RoundName { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [DisplayName("Province"),Width(100)]
        public string Province { get; set; }

        [EditLink,Width(100)]
        [DisplayName("District")]
        public string DistrictDname { get; set; }
        [Width(130)]
        public string CampaignTypeName { get; set; }
        [Width(100)]
        public string ClusterName { get; set; }
        [Width(120)]
        public string LevelName { get; set; }
        [Width(100)]
        public string ClusterCode { get; set; }
        public String Village { get; set; }

        [Width(80)]
        public Int16 VistedHouses { get; set; }
        [Width(60)]
        public Int16 T059m { get; set; }
        public Int16 V059m { get; set; }
        public Int16 T011Seen { get; set; }
        public Int16 Fm011HvFm { get; set; }
        public Int16 T1259Seen { get; set; }
        public Int16 Fm1259HvFm { get; set; }
        public Int16 TChildrenNoFm { get; set; }
        public Int16 R1TeamNoVisit { get; set; }
        public Int16 R21 { get; set; }
        public Int16 R22 { get; set; }
        public Int16 R23 { get; set; }
        public Int16 R24 { get; set; }
        public Int16 R31 { get; set; }
        public Int16 R33 { get; set; }
        public Int16 R4NewBorn { get; set; }
        public Int16 R5Sleep { get; set; }
        public Int16 R6Sick { get; set; }
        public Int16 R7Other { get; set; }
        public Int16 DmCorrect { get; set; }
        public Int16 DmIncorrect { get; set; }
        public Int16 NoDm { get; set; }
        public Int16 FmHeard { get; set; }
        public Int16 FmNotHeard { get; set; }
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
        public Single RCallCoverage { get; set; }
        public Single Fm059Coverage { get; set; }
        public Single Fm011Coverage { get; set; }
        //public Int16 InAcesChildren { get; set; }
    }
}