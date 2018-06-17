
namespace webNEOC.ImportGate.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ImportGate.TempVitaminA")]
    [BasedOnRow(typeof(Entities.TempVitaminARow))]
    public class TempVitaminAColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 TempVitaminAId { get; set; }
        [Width(100)]
        public string RoundName { get; set; }
        [Width(100)]
        public string ProvinceName { get; set; }
        [Width(100)]
        public string DistrictName { get; set; }
        [Width(100)]
        public string ClusterName { get; set; }
        public String PemtremtManager { get; set; }
        public Int32 TargetU5Cases { get; set; }
        public Int16 D1VitADist { get; set; }
        public Int16 D1VitAUse { get; set; }
        public Int16 D1C611Months { get; set; }
        public Int16 D1C1259Months { get; set; }
        public Int16 D2VitADist { get; set; }
        public Int16 D2VitAUse { get; set; }
        public Int16 D2C611Months { get; set; }
        public Int16 D2C1259Months { get; set; }
        public Int16 D3VitADist { get; set; }
        public Int16 D3VitAUse { get; set; }
        public Int16 D3C611Months { get; set; }
        public Int16 D3C1259Months { get; set; }
        public Int16 D5VitADist { get; set; }
        public Int16 D5VitAUse { get; set; }
        public Int16 D5C611Months { get; set; }
        public Int16 D5C1259Months { get; set; }
        public Int32 TenantId { get; set; }
    }
}