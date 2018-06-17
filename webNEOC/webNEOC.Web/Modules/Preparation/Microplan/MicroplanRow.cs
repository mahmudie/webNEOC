
namespace webNEOC.Preparation.Entities
{
    using Serenity;
    using Modules.Preparation;
    using MultiTenancy;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Microplan]"), DisplayName("Microplan"), InstanceName("Microplan"), TwoLevelCached]
    [ReadPermission(PrepPermissionKeys.Microplan.View)]
    [ModifyPermission(PrepPermissionKeys.Microplan.Update)]
    [InsertPermission(PrepPermissionKeys.Microplan.Insert)]
    [DeletePermission(PrepPermissionKeys.Microplan.Delete)]
    public sealed class MicroplanRow : Row, IIdRow,IMultiTenantRow
    {
        [DisplayName("ID"), Identity]
        public Int32? MicroplanId
        {
            get { return Fields.MicroplanId[this]; }
            set { Fields.MicroplanId[this] = value; }
        }

        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow)),Required]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow)),Required]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Date"), NotNull]
        public DateTime? ReportDate
        {
            get { return Fields.ReportDate[this]; }
            set { Fields.ReportDate[this] = value; }
        }

        [DisplayName("Sno"), NotNull]
        public Int32? Sno
        {
            get { return Fields.Sno[this]; }
            set { Fields.Sno[this] = value; }
        }

        [DisplayName("Total population"), NotNull]
        public Int32? TotalPop
        {
            get { return Fields.TotalPop[this]; }
            set { Fields.TotalPop[this] = value; }
        }

        [DisplayName("OPV target "), Column("OPVTarget"), Expression("(t0.[TotalPop] *20/100)"), NotNull]
        public Int32? OpvTarget
        {
            get { return Fields.OpvTarget[this]; }
            set { Fields.OpvTarget[this] = value; }
        }

        [DisplayName("Missed target"), NotNull]
        public Int32? MissedTarget
        {
            get { return Fields.MissedTarget[this]; }
            set { Fields.MissedTarget[this] = value; }
        }

        [DisplayName("Target pop for VitA 06-59 months"), NotNull]
        public Int16? VitATarget
        {
            get { return Fields.VitATarget[this]; }
            set { Fields.VitATarget[this] = value; }
        }

        [DisplayName("# of teams"), NotNull]
        public Int16? Teams
        {
            get { return Fields.Teams[this]; }
            set { Fields.Teams[this] = value; }
        }

        [DisplayName("# of nomads teames"), NotNull]
        public Int16? NomadTeams
        {
            get { return Fields.NomadTeams[this]; }
            set { Fields.NomadTeams[this] = value; }
        }

        [DisplayName("Fix vaccinators teams"), NotNull]
        public Int16? FixVacTeams
        {
            get { return Fields.FixVacTeams[this]; }
            set { Fields.FixVacTeams[this] = value; }
        }

        [DisplayName("REMT/PEMT staff"), Column("REMTPEMTstaff"), NotNull]
        public Int16? RemtpemTstaff
        {
            get { return Fields.RemtpemTstaff[this]; }
            set { Fields.RemtpemTstaff[this] = value; }
        }

        [DisplayName("# of coordinators"), NotNull]
        public Int16? Coordinators
        {
            get { return Fields.Coordinators[this]; }
            set { Fields.Coordinators[this] = value; }
        }

        [DisplayName("PCO"), Column("PCO"), NotNull]
        public Int16? Pco
        {
            get { return Fields.Pco[this]; }
            set { Fields.Pco[this] = value; }
        }

        [DisplayName("DPO/DCO"), Column("DPODCO"), NotNull]
        public Int16? Dpodco
        {
            get { return Fields.Dpodco[this]; }
            set { Fields.Dpodco[this] = value; }
        }

        [DisplayName("CCSs"), Column("CCSs"), NotNull]
        public Int16? CcSs
        {
            get { return Fields.CcSs[this]; }
            set { Fields.CcSs[this] = value; }
        }

        [DisplayName("SMs"), NotNull]
        public Int16? SMs
        {
            get { return Fields.SMs[this]; }
            set { Fields.SMs[this] = value; }
        }

        [DisplayName("Sup"), NotNull]
        public Int16? Sup
        {
            get { return Fields.Sup[this]; }
            set { Fields.Sup[this] = value; }
        }
        [DisplayName("# of teams"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[FixVacTeams])"), ReadOnly(true)]
        public Int16? NoOfTeams
        {
            get { return Fields.NoOfTeams[this]; }
            set { Fields.NoOfTeams[this] = value; }
        }

        [DisplayName("Volunteers"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[FixVacTeams]) * 2"), ReadOnly(true)]
        public Int16? Volunteers
        {
            get { return Fields.Volunteers[this]; }
            set { Fields.Volunteers[this] = value; }
        }

        [DisplayName("Intra NIDs monitors"), Column("IntraNIDsMonitors"), NotNull]
        public Int16? IntraNiDsMonitors
        {
            get { return Fields.IntraNiDsMonitors[this]; }
            set { Fields.IntraNiDsMonitors[this] = value; }
        }

        [DisplayName("PCA monotors"), Column("PCAmonotors"), NotNull]
        public Int16? PcAmonotors
        {
            get { return Fields.PcAmonotors[this]; }
            set { Fields.PcAmonotors[this] = value; }
        }

        [DisplayName("OPV doses"), Column("OPVDoses"),NotNull]
        public Int16? OpvDoses
        {
            get { return Fields.OpvDoses[this]; }
            set { Fields.OpvDoses[this] = value; }
        }

        [DisplayName("OPV vials"), Expression("(t0.[OPVDoses]/20)"), ReadOnly(true)]
        public Int16? OpvVials
        {
            get { return Fields.OpvVials[this]; }
            set { Fields.OpvVials[this] = value; }
        }

        [DisplayName("Albendazole tablet"), NotNull]
        public Int16? AlbendazTablet
        {
            get { return Fields.AlbendazTablet[this]; }
            set { Fields.AlbendazTablet[this] = value; }
        }

        [DisplayName("Vitamin A capsules"), NotNull]
        public Int16? VitACapsules
        {
            get { return Fields.VitACapsules[this]; }
            set { Fields.VitACapsules[this] = value; }
        }

        [DisplayName("Cold boxes"), Expression("(t0.[Coordinators]+t0.[Sup])"), ReadOnly(true)]
        public Int16? ColdBoxes
        {
            get { return Fields.ColdBoxes[this]; }
            set { Fields.ColdBoxes[this] = value; }
        }

        [DisplayName("Thermos/Vaccine carrier"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[REMTPEMTstaff]+t0.[IntraNiDsMonitors])"), ReadOnly(true)]
        public Int16? Thermos
        {
            get { return Fields.Thermos[this]; }
            set { Fields.Thermos[this] = value; }
        }

        [DisplayName("Ice packs"), Expression("(t0.[Coordinators]+t0.[Sup])*12 +(t0.[Teams] + t0.[NomadTeams] + t0.[REMTPEMTstaff]+t0.[IntraNiDsMonitors]) * 6")]
        public Int16? IcePacks
        {
            get { return Fields.IcePacks[this]; }
            set { Fields.IcePacks[this] = value; }
        }

        [DisplayName("Banner"), NotNull]
        public Int16? Banner
        {
            get { return Fields.Banner[this]; }
            set { Fields.Banner[this] = value; }
        }

        [DisplayName("Vehicle"), NotNull]
        public Int16? Vehicle
        {
            get { return Fields.Vehicle[this]; }
            set { Fields.Vehicle[this] = value; }
        }

        [DisplayName("Motor bike for monitors and super"), Expression("(t0.[IntraNiDsMonitors]+t0.[Sup])"),ReadOnly(true)]
        public Int16? MotorBikes4Monitors
        {
            get { return Fields.MotorBikes4Monitors[this]; }
            set { Fields.MotorBikes4Monitors[this] = value; }
        }

        [DisplayName("Motor bikes for nomads"), NotNull]
        public Int16? MotorBikes4Nomads
        {
            get { return Fields.MotorBikes4Nomads[this]; }
            set { Fields.MotorBikes4Nomads[this] = value; }
        }

        [DisplayName("Leflet"), Column("leflet"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[FixVacTeams])*85"),ReadOnly(true)]
        public Int16? Leflet
        {
            get { return Fields.Leflet[this]; }
            set { Fields.Leflet[this] = value; }
        }

        [DisplayName("Scissors"), NotNull]
        public Int16? Scissors
        {
            get { return Fields.Scissors[this]; }
            set { Fields.Scissors[this] = value; }
        }

        [DisplayName("Finger Markers"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[FixVacTeams]+ t0.[REMTPEMTstaff]+t0.[Coordinators]+t0.[Sup]+t0.[IntraNiDsMonitors])"),ReadOnly(true)]
        public Int16? FingerMarkers
        {
            get { return Fields.FingerMarkers[this]; }
            set { Fields.FingerMarkers[this] = value; }
        }

        [DisplayName("Plastic Bag No"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[FixVacTeams])*3*2"), ReadOnly(true)]
        public Int16? PlasticBagNo
        {
            get { return Fields.PlasticBagNo[this]; }
            set { Fields.PlasticBagNo[this] = value; }
        }

        //[DisplayName("Cost (each)"), NotNull]
        //public Int16? PlasticBagCost
        //{
        //    get { return Fields.PlasticBagCost[this]; }
        //    set { Fields.PlasticBagCost[this] = value; }
        //}

        [DisplayName("Pen No"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[FixVacTeams]+ t0.[REMTPEMTstaff]+t0.[Coordinators]+t0.[Sup]+t0.[IntraNiDsMonitors])"), ReadOnly(true)]
        public Int16? PenNo
        {
            get { return Fields.PenNo[this]; }
            set { Fields.PenNo[this] = value; }
        }

        //[DisplayName("Cost"), NotNull]
        //public Int16? PenCost
        //{
        //    get { return Fields.PenCost[this]; }
        //    set { Fields.PenCost[this] = value; }
        //}

        [DisplayName("Chalk No"), Expression("(t0.[Teams] + t0.[NomadTeams] + t0.[FixVacTeams])*7"), ReadOnly(true)]
        public Int16? ChalkNo
        {
            get { return Fields.ChalkNo[this]; }
            set { Fields.ChalkNo[this] = value; }
        }

        //[DisplayName("Cost"), NotNull]
        //public Int16? ChalkCost
        //{
        //    get { return Fields.ChalkCost[this]; }
        //    set { Fields.ChalkCost[this] = value; }
        //}

        [DisplayName("Sheets for coordinator"), NotNull]
        public Int16? AlbenVitSheetCoordinator
        {
            get { return Fields.AlbenVitSheetCoordinator[this]; }
            set { Fields.AlbenVitSheetCoordinator[this] = value; }
        }

        [DisplayName("Sheets for supervisor"), NotNull]
        public Int16? AlbenVitSheetSupvervisor
        {
            get { return Fields.AlbenVitSheetSupvervisor[this]; }
            set { Fields.AlbenVitSheetSupvervisor[this] = value; }
        }

        //[DisplayName("Compliation Sheet NA children"), NotNull]
        //public Int16? SheetNChildren
        //{
        //    get { return Fields.SheetNChildren[this]; }
        //    set { Fields.SheetNChildren[this] = value; }
        //}

        //[DisplayName("Tally=1Team*4"), NotNull]
        //public Int16? Tallies
        //{
        //    get { return Fields.Tallies[this]; }
        //    set { Fields.Tallies[this] = value; }
        //}

        //[DisplayName("Nid Mon Chak List"), Column("NIDMonChakList"), NotNull]
        //public Int16? NidMonChakList
        //{
        //    get { return Fields.NidMonChakList[this]; }
        //    set { Fields.NidMonChakList[this] = value; }
        //}

        //[DisplayName("Print Mat No"), NotNull]
        //public Int16? PrintMatNo
        //{
        //    get { return Fields.PrintMatNo[this]; }
        //    set { Fields.PrintMatNo[this] = value; }
        //}

        //[DisplayName("Print Mat Cost"), NotNull]
        //public Int16? PrintMatCost
        //{
        //    get { return Fields.PrintMatCost[this]; }
        //    set { Fields.PrintMatCost[this] = value; }
        //}

        //[DisplayName("Total Cost"), NotNull]
        //public Int16? TotalCost
        //{
        //    get { return Fields.TotalCost[this]; }
        //    set { Fields.TotalCost[this] = value; }
        //}

        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [DisplayName("Province Id"), Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("p")]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [Expression("p.[Pname]")]
        public string Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }

        [DisplayName("District Dname"), Expression("jDistrict.[Dname]")]
        public String DistrictDname
        {
            get { return Fields.DistrictDname[this]; }
            set { Fields.DistrictDname[this] = value; }
        }

        [DisplayName("District Total Pop"), Expression("jDistrict.[TotalPop]")]
        public Int32? DistrictTotalPop
        {
            get { return Fields.DistrictTotalPop[this]; }
            set { Fields.DistrictTotalPop[this] = value; }
        }

        [DisplayName("District Target Pop"), Expression("jDistrict.[TargetPop]")]
        public Int32? DistrictTargetPop
        {
            get { return Fields.DistrictTargetPop[this]; }
            set { Fields.DistrictTargetPop[this] = value; }
        }

        [DisplayName("District Type"), Expression("jDistrict.[Type]")]
        public String DistrictType
        {
            get { return Fields.DistrictType[this]; }
            set { Fields.DistrictType[this] = value; }
        }

        [DisplayName("District Priority"), Expression("jDistrict.[Priority]")]
        public Int16? DistrictPriority
        {
            get { return Fields.DistrictPriority[this]; }
            set { Fields.DistrictPriority[this] = value; }
        }

        [DisplayName("District Pop Year"), Expression("jDistrict.[PopYear]")]
        public Int32? DistrictPopYear
        {
            get { return Fields.DistrictPopYear[this]; }
            set { Fields.DistrictPopYear[this] = value; }
        }
        [DisplayName("Round"), Expression("jRound.[RoundName]")]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }

        [DisplayName("Date From"), Expression("jRound.[DateFrom]"), ReadOnly(true)]
        public DateTime? DateFrom
        {
            get { return Fields.DateFrom[this]; }
            set { Fields.DateFrom[this] = value; }
        }

        [DisplayName("Date To"), Expression("jRound.[DateTo]"), ReadOnly(true)]
        public DateTime? DateTo
        {
            get { return Fields.DateTo[this]; }
            set { Fields.DateTo[this] = value; }
        }

        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }
        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.MicroplanId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MicroplanRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MicroplanId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public DateTimeField ReportDate;
            public Int32Field Sno;
            public Int32Field TotalPop;
            public readonly Int32Field OpvTarget;
            public Int32Field MissedTarget;
            public Int16Field VitATarget;
            public Int16Field Teams;
            public Int16Field NomadTeams;
            public Int16Field FixVacTeams;
            public Int16Field RemtpemTstaff;
            public Int16Field Coordinators;
            public Int16Field Pco;
            public Int16Field Dpodco;
            public Int16Field CcSs;
            public Int16Field SMs;
            public Int16Field Sup;
            public Int16Field NoOfTeams;
            public Int16Field Volunteers;
            public Int16Field IntraNiDsMonitors;
            public Int16Field PcAmonotors;
            public Int16Field OpvDoses;
            public Int16Field OpvVials;
            public Int16Field AlbendazTablet;
            public Int16Field VitACapsules;
            public Int16Field ColdBoxes;
            public Int16Field Thermos;
            public Int16Field IcePacks;
            public Int16Field Banner;
            public Int16Field Vehicle;
            public Int16Field MotorBikes4Monitors;
            public Int16Field MotorBikes4Nomads;
            public Int16Field Leflet;
            public Int16Field Scissors;
            public Int16Field FingerMarkers;
            public Int16Field PlasticBagNo;
            //public Int16Field PlasticBagCost;
            public Int16Field PenNo;
            //public Int16Field PenCost;
            public Int16Field ChalkNo;
            //public Int16Field ChalkCost;
            public Int16Field AlbenVitSheetCoordinator;
            public Int16Field AlbenVitSheetSupvervisor;
            //public Int16Field SheetNChildren;
            //public Int16Field Tallies;
            //public Int16Field NidMonChakList;
            //public Int16Field PrintMatNo;
            //public Int16Field PrintMatCost;
            //public Int16Field TotalCost;

            public StringField RoundName;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public Int32Field TenantId;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField Province;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Preparation.Microplan";
            }
        }
    }
}
