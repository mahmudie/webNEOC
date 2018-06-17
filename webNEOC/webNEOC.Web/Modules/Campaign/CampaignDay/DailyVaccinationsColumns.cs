
namespace webNEOC.Campaign.Columns
{
    using webNEOC.Common;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Campaign.DailyVaccinations")]
    [BasedOnRow(typeof(Entities.DailyVaccinationsRow))]
    public class DailyVaccinationsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 DailyVaccinationsId { get; set; }
        [Sortable(true)]
        public Int16 ClusterId { get; set; }
        [Width(80)]
        public string LDPTypes { get; set; }

        [Width(100), DailyVaccinationsFormatter]
        public Int32 TargetU5Case { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1VialDist { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1VialUse { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1Vac011Months { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1Vac1259months { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1RecAbsChildren { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1VacAbsChildren { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1RecNewbornSsc { get; set; }
        [Width(150), DailyVaccinationsFormatter]
        public Int16 D1VacNewbornSsc { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D1RecRefusedChildren { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D1RevacRefusedChildren { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D1AfpCase { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2VialDist { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2VialUse { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2Vac011Months { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2Vac1259months { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2RecAbsChildren { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2VacAbsChildren { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2RecNewbornSsc { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2VacNewbornSsc { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2RecRefusedChildren { get; set; }
        [DailyVaccinationsFormatter]
        public Int16 D2RevacRefusedChildren { get; set; }
        public Int16 D2AfpCase { get; set; }
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