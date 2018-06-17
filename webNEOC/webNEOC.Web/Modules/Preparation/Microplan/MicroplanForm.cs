
namespace webNEOC.Preparation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Preparation.Microplan")]
    [BasedOnRow(typeof(Entities.MicroplanRow))]
    public class MicroplanForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }
        public DateTime ReportDate { get; set; }
        public Int32 Sno { get; set; }
        public Int32 TotalPop { get; set; }
        public Int32 OpvTarget { get; set; }
        public Int32 MissedTarget { get; set; }
        public Int16 VitATarget { get; set; }

        [Category("Staff")]
        public Int16 Teams { get; set; }
        public Int16 NomadTeams { get; set; }
        public Int16 FixVacTeams { get; set; }
        public Int16 RemtpemTstaff { get; set; }
        public Int16 Coordinators { get; set; }
        public Int16 Pco { get; set; }
        public Int16 Dpodco { get; set; }
        public Int16 CcSs { get; set; }
        public Int16 SMs { get; set; }
        public Int16 Sup { get; set; }
        //public Int16 Volunteers { get; set; }
        public Int16 IntraNiDsMonitors { get; set; }
        public Int16 PcAmonotors { get; set; }

        [Category("Stock")]
        public Int16 OpvDoses { get; set; }
        //public Int16 OpvVials { get; set; }
        public Int16 AlbendazTablet { get; set; }
        public Int16 VitACapsules { get; set; }

        [Category("Equipment")]
        //public Int16 ColdBoxes { get; set; }
        //public Int16 Thermos { get; set; }
        //public Int16 IcePacks { get; set; }
        public Int16 Banner { get; set; }
        public Int16 Vehicle { get; set; }
        //public Int16 MotorBikes4Monitors { get; set; }
        public Int16 MotorBikes4Nomads { get; set; }
        //public Int16 Leflet { get; set; }
        public Int16 Scissors { get; set; }
        //public Int16 FingerMarkers { get; set; }

        //[Category("Plastic")]
        //public Int16 PlasticBagNo { get; set; }
        //public Int16 PlasticBagCost { get; set; }

        //[Category("Pen")]
        //public Int16 PenNo { get; set; }
        //public Int16 PenCost { get; set; }
        //[Category("Chalk")]
        //public Int16 ChalkNo { get; set; }
        //public Int16 ChalkCost { get; set; }

        [Category("Compilation Sheet")]
        public Int16 AlbenVitSheetCoordinator { get; set; }
        public Int16 AlbenVitSheetSupvervisor { get; set; }
        //public Int16 SheetNChildren { get; set; }
        //public Int16 Tallies { get; set; }
        //public Int16 NidMonChakList { get; set; }
        //public Int16 PrintMatNo { get; set; }
        //public Int16 PrintMatCost { get; set; }
        //public Int16 TotalCost { get; set; }
    }
}