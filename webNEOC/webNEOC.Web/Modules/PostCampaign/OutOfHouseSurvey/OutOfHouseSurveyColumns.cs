
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

    [ColumnsScript("PostCampaign.OutOfHouseSurvey")]
    [BasedOnRow(typeof(Entities.OutOfHouseSurveyRow))]
    public class OutOfHouseSurveyColumns
    {
        [ModifyPermission(PostCampaignPermissionKeys.OutOfHouseSurvey.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 OutOfHouseSurveyId { get; set; }

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
        [Width(80)]
        public DateTime ReportDate { get; set; }
        [Width(100)]
        public Int16 T059m { get; set; }
        [Width(120)]
        public Int16 Vac059m { get; set; }
        [Width(120)]
        public Int16 FM059m { get; set; }
        [Width(120)]
        public Int16 T059f { get; set; }
        [Width(120)]
        public Int16 Vac059f { get; set; }
        [Width(120)]
        public Int16 FM059f { get; set; }
        [Width(120)]
        public Int16 MissTmNotCome { get; set; }
        [Width(120)]
        public Int16 MissAbsent { get; set; }
        [Width(120)]
        public Int16 MissRefused { get; set; }
        [Width(120)]
        public Int16 MissNewBornSick { get; set; }
    }
}