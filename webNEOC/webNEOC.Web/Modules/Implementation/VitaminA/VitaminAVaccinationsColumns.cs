
namespace webNEOC.Implementation.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Implementation.VitaminAVaccinations")]
    [BasedOnRow(typeof(Entities.VitaminAVaccinationsRow))]
    public class VitaminAVaccinationsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 VitaminAVaccinationsId { get; set; }
        //public Int32 VitaminADayId { get; set; }
        public string ClusterName { get; set; }
        public Int32 TargetU5Cases { get; set; }
        public Int16 d1VitADist { get; set; }
        public Int16 d1VitAUse { get; set; }
        public Int16 d1C611Months { get; set; }
        public Int16 d1C1259Months { get; set; }
        public Int16 d2VitADist { get; set; }
        public Int16 d2VitAUse { get; set; }
        public Int16 d2C611Months { get; set; }
        public Int16 d2C1259Months { get; set; }
        public Int16 d3VitADist { get; set; }
        public Int16 d3VitAUse { get; set; }
        public Int16 d3C611Months { get; set; }
        public Int16 d3C1259Months { get; set; }
        public Int16 d5VitADist { get; set; }
        public Int16 d5VitAUse { get; set; }
        public Int16 d5C611Months { get; set; }
        public Int16 d5C1259Months { get; set; }
    }
}