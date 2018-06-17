
namespace webNEOC.Implementation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Implementation.MobileTeam")]
    [BasedOnRow(typeof(Entities.MobileTeamRow))]
    public class MobileTeamForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }

        [Category("Coverage")]
        public Int16 Nomads { get; set; }
        public Int16 Gypsis { get; set; }
        public Int16 BlueMosque { get; set; }
        public Int16 IDPs { get; set; }
        public Int16 Returnees { get; set; }
        public Int16 Kindergarden { get; set; }
        public Int16 Madrasa { get; set; }
        public Int16 EPICenters { get; set; }
        public Int16 BusStation { get; set; }
        public Int16 Prison { get; set; }
        public Int16 MobileTeams { get; set; }
        public Int16 CheckPost { get; set; }
        public Int16 PrivateClinics { get; set; }
        public Int16 Daramsal { get; set; }
        public Int16 HotelGuestHouses { get; set; }
        public Int16 Crosborder { get; set; }
        public Int16 School { get; set; }
        public Int16 Others { get; set; }
    }
}