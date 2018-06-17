
namespace webNEOC.Campaign.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Campaign.DailyVaccinations")]
    [BasedOnRow(typeof(Entities.DailyVaccinationsRow))]
    public class DailyVaccinationsForm
    {
        //public Int32 CampaignDayId { get; set; }
        [Category("General")]
        //[LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        //public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.ClusterRow))]
        public Int64 ClusterId { get; set; }
        public string LDPTypes { get; set; }
        public Int32 TargetU5Case { get; set; }

        [Category("Day I:")]
        [AlignRight]
        public Int16 D1VialDist { get; set; }
        public Int16 D1VialUse { get; set; }
        public Int16 D1Vac011Months { get; set; }
        public Int16 D1Vac1259months { get; set; }
        public Int16 D1RecAbsChildren { get; set; }
        public Int16 D1VacAbsChildren { get; set; }
        public Int16 D1RecNewbornSsc { get; set; }
        public Int16 D1VacNewbornSsc { get; set; }
        public Int16 D1RecRefusedChildren { get; set; }
        public Int16 D1RevacRefusedChildren { get; set; }
        public Int16 D1AfpCase { get; set; }

        [Category("Day II:")]
        public Int16 D2VialDist { get; set; }
        public Int16 D2VialUse { get; set; }
        public Int16 D2Vac011Months { get; set; }
        public Int16 D2Vac1259months { get; set; }
        public Int16 D2RecAbsChildren { get; set; }
        public Int16 D2VacAbsChildren { get; set; }
        public Int16 D2RecNewbornSsc { get; set; }
        public Int16 D2VacNewbornSsc { get; set; }
        public Int16 D2RecRefusedChildren { get; set; }
        public Int16 D2RevacRefusedChildren { get; set; }
        public Int16 D2AfpCase { get; set; }

        [Category("Day III:")]
        public Int16 D3VialDist { get; set; }
        public Int16 D3VialUse { get; set; }
        public Int16 D3Vac011Months { get; set; }
        public Int16 D3Vac1259months { get; set; }
        public Int16 D3RecAbsChildren { get; set; }
        public Int16 D3VacAbsChildren { get; set; }
        public Int16 D3RecNewbornSsc { get; set; }
        public Int16 D3VacNewbornSsc { get; set; }
        public Int16 D3RecRefusedChildren { get; set; }
        public Int16 D3RevacRefusedChildren { get; set; }
        public Int16 D3AfpCase { get; set; }

        [Category("Day V:")]
        public Int16 D5VialDist { get; set; }
        public Int16 D5VialUse { get; set; }
        public Int16 D5Vac011Months { get; set; }
        public Int16 D5Vac1259months { get; set; }
        public Int16 D5RecAbsChildren { get; set; }
        public Int16 D5VacAbsChildren { get; set; }
        public Int16 D5RecNewbornSsc { get; set; }
        public Int16 D5VacNewbornSsc { get; set; }
        public Int16 D5RecRefusedChildren { get; set; }
        public Int16 D5RevacRefusedChildren { get; set; }
        public Int16 D5AfpCase { get; set; }
    }
}