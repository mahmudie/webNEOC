
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
    using webNEOC.Locations.Entities;

    [ColumnsScript("Implementation.MobileTeam")]
    [BasedOnRow(typeof(Entities.MobileTeamRow))]
    public class MobileTeamColumns
    {
        [ModifyPermission(ImplementationPermissionKeys.MobileTeam.Modify),Width(80),SortOrder(1,descending:false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MobileTeamId { get; set; }

        [EditLink,Width(120)]
        [DisplayName("Round"),QuickFilter]
        public string RoundName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [Width(80)]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow)),QuickFilter]
        public string Province { get; set; }

        [EditLink,Width(100)/*(ItemType = "Implementation.MobileTeam"/*, IdField = "DistrictId"*/]
        [DisplayName("District")]
        public string DistrictDname { get; set; }

        [Width(70)]
        public Int16 Nomads { get; set; }
        [Width(70)]
        public Int16 Gypsis { get; set; }
        [Width(70)]
        public Int16 BlueMosque { get; set; }
        [Width(70)]
        public Int16 IDPs { get; set; }
        [Width(70)]
        public Int16 Returnees { get; set; }
        [Width(70)]
        public Int16 Kindergarden { get; set; }
        [Width(70)]
        public Int16 Madrasa { get; set; }
        [Width(70)]
        public Int16 EPICenters { get; set; }
        [Width(70)]
        public Int16 BusStation { get; set; }
        [Width(70)]
        public Int16 Prison { get; set; }
        [Width(70)]
        public Int16 MobileTeams { get; set; }
        [Width(70)]
        public Int16 CheckPost { get; set; }
        [Width(100)]
        public Int16 PrivateClinics { get; set; }
        [Width(70)]
        public Int16 Daramsal { get; set; }
        [Width(120)]
        public Int16 HotelGuestHouses { get; set; }
        [Width(70)]
        public Int16 Crosborder { get; set; }
        [Width(70)]
        public Int16 School { get; set; }
        [Width(70)]
        public Int16 Others { get; set; }
    }
}