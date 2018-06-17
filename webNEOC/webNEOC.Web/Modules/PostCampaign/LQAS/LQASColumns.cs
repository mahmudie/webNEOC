
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

    [ColumnsScript("PostCampaign.LQAS")]
    [BasedOnRow(typeof(Entities.LQASRow))]
    public class LQASColumns
    {
        [ModifyPermission(PostCampaignPermissionKeys.LQASS.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,SortOrder(1,descending:true)]
        public Int16 LqasId { get; set; }


        [EditLink, Width(150)]
        [DisplayName("Round")]
        public string RoundName { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [DisplayName("Province"),Width(100)]
        public string Province { get; set; }
        [EditLink, Width(100)]
        [DisplayName("District")]
        public string DistrictDname { get; set; }
        [Width(130)]

        public Int16 LotNo { get; set; }
        [Width(200)]
        public Int16 NoVaccChildren { get; set; }
        [Width(250)]
        public String Comments { get; set; }
    }
}