
namespace webNEOC.Implementation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Implementation.VitaminA")]
    [BasedOnRow(typeof(Entities.VitaminARow))]
    public class VitaminAForm
    {
        [Category("General")]
        public Int32 RoundId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }


        [DisplayName("Prepared by")]
        public String PemtremtManager { get; set; }

        [Category("Details")]
        [VitaminAVaccinationEditor]
        public List<Entities.VitaminAVaccinationsRow> VitaminAVaccinations { get; set; }
    }
}