
namespace webNEOC.Preparation.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Preparation.Microplan")]
    [BasedOnRow(typeof(Entities.MicroplanRow))]
    public class MicroplanColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MicroplanId { get; set; }
        [EditLink, Width(150)]
        [DisplayName("Round")]
        public string RoundName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [DisplayName("Province"),Width(100)]
        public string Province { get; set; }
        [EditLink, Width(100)]
        [DisplayName("District")]
        public string DistrictDname { get; set; }
        public DateTime ReportDate { get; set; }
        public Int32 Sno { get; set; }
        public Int32 TotalPop { get; set; }
        public Int32 OpvTarget { get; set; }
        public Int32 MissedTarget { get; set; }
        public Int16 VitATarget { get; set; }
        [DisplayName("Teams")]
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
        public Int16 NoOfTeams { get; set; }
        public Int16 Volunteers { get; set; }
        public Int16 IntraNiDsMonitors { get; set; }
        public Int16 PcAmonotors { get; set; }
        public Int16 OpvDoses { get; set; }
        public Int16 OpvVials { get; set; }
        public Int16 AlbendazTablet { get; set; }
        public Int16 VitACapsules { get; set; }
        public Int16 ColdBoxes { get; set; }
        public Int16 Thermos { get; set; }
        public Int16 IcePacks { get; set; }
        public Int16 Banner { get; set; }
        public Int16 Vehicle { get; set; }
        public Int16 MotorBikes4Monitors { get; set; }
        public Int16 MotorBikes4Nomads { get; set; }
        public Int16 Leflet { get; set; }
        public Int16 Scissors { get; set; }
        public Int16 FingerMarkers { get; set; }
        public Int16 PlasticBagNo { get; set; }
        //public Int16 PlasticBagCost { get; set; }
        public Int16 PenNo { get; set; }
        //public Int16 PenCost { get; set; }
        public Int16 ChalkNo { get; set; }
        //public Int16 ChalkCost { get; set; }
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