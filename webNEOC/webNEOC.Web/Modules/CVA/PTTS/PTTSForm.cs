
namespace webNEOC.CVA.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Locations.Entities;
    using webNEOC.Administration.Entities;

    [FormScript("CVA.PTTS")]
    [BasedOnRow(typeof(Entities.PTTSRow))]
    public class PTTSForm
    {
        [LookupEditor(typeof(ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }
        [LookupEditor(typeof(DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }
        public Int32 Year { get; set; }
        public Int32 MonthId { get; set; }
        public String Type { get; set; }
        public String Subtype { get; set; }
        public Int16 NoOfTeam { get; set; }
        public String TeamName { get; set; }
        public Int32 Boys011 { get; set; }
        public Int32 Girls011 { get; set; }
        public Int32 Boys1259 { get; set; }
        public Int32 Girls1259 { get; set; }
        public String Remarks { get; set; }
        [Visible(false),Updatable(true),Insertable(true)]
        public Int32 TenantId { get; set; }
    }
}