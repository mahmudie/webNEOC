
namespace webNEOC.PostCampaign.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("PostCampaign.OutOfHouseSurvey")]
    [BasedOnRow(typeof(Entities.OutOfHouseSurveyRow))]
    public class OutOfHouseSurveyForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }
        public DateTime ReportDate { get; set; }

        [Category("vaccinated")]
        public Int16 T059m { get; set; }
        public Int16 Vac059m { get; set; }
        public Int16 FM059m { get; set; }
        public Int16 T059f { get; set; }
        public Int16 Vac059f { get; set; }
        public Int16 FM059f { get; set; }

        [Category("Missed")]
        public Int16 MissTmNotCome { get; set; }
        public Int16 MissAbsent { get; set; }
        public Int16 MissRefused { get; set; }
        public Int16 MissNewBornSick { get; set; }
    }
}