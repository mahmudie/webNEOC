
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

    [ColumnsScript("Implementation.Icn")]
    [BasedOnRow(typeof(Entities.IcnRow))]
    public class IcnColumns
    {
        [ModifyPermission(ImplementationPermissionKeys.ICN.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid IcnId { get; set; }
        [Width(100)]
        public string RoundName { get; set; }
        [Width(80)]
        public DateTime DateFrom { get; set; }
        [Width(80)]
        public DateTime DateTo { get; set; }
        [Width(100)]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public string Province { get; set; }
        [Width(100),DisplayName("District")]
        public string DistrictDname { get; set; }
        [Width(100)]
        public String Area { get; set; }
        [Width(100)]
        public string Cname { get; set; }
        [Width(120)]
        public Int16 RegAbsent { get; set; }
        [Width(120)]
        public Int16 VacAbsent { get; set; }
        [Width(120)]
        public Int16 RegNss { get; set; }
        [Width(120)]
        public Int16 VacNss { get; set; }
        [Width(120)]
        public Int16 RegRefusal { get; set; }
        [Width(120)]
        public Int16 VacRefusal { get; set; }
        [Width(120)]
        public Int16 RegUnrecorded { get; set; }
        [Width(120)]
        public Int16 VacUnrecorded { get; set; }
    }
}