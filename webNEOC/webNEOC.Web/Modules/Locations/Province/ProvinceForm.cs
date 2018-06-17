
namespace webNEOC.Locations.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Locations.Province")]
    [BasedOnRow(typeof(Entities.ProvinceRow))]
    public class ProvinceForm
    {
        public String Pcode { get; set; }
        public Int16 RegionId { get; set; }
        public String Pname { get; set; }
        public String PAbrv { get; set; }
        public String Pcenter { get; set; }
        public Int32 AreaKmSqr { get; set; }
        public Int32 NoOfDistricts { get; set; }
    }
}