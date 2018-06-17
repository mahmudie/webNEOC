
namespace webNEOC.Implementation.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using webNEOC.Modules.Implementation;

    [ColumnsScript("Implementation.VitaminA")]
    [BasedOnRow(typeof(Entities.VitaminARow))]
    public class VitaminAColumns
    {
        [ModifyPermission(ImplementationPermissionKeys.VitaminA.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 VitaminADayId { get; set; }

        [EditLink(ItemType = "Implementation.VitaminA", IdField = "RoundId")]
        [DisplayName("Round")]
        public string RoundName { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        //[EditLink(ItemType = "Implementation.VitaminA", IdField = "ProvinceId")]
        [DisplayName("Province")]
        public string ProvincePname { get; set; }

        [DisplayName("District")]
        public string DistrictDname { get; set; }
        [DisplayName("Prepared by")]
        public String PemtremtManager { get; set; }
    }
}