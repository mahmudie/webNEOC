
namespace webNEOC.Implementation.Entities
{
    using Serenity;
    using Modules.Implementation;
    using MultiTenancy;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[ICMTeam]"), DisplayName("ICM Team"), InstanceName("ICM Team"), TwoLevelCached]
    [ReadPermission(ImplementationPermissionKeys.IcmTeam.View)]
    [ModifyPermission(ImplementationPermissionKeys.IcmTeam.Update)]
    [InsertPermission(ImplementationPermissionKeys.IcmTeam.Insert)]
    [DeletePermission(ImplementationPermissionKeys.IcmTeam.Delete)]
    public sealed class IcmTeamRow : Row, IIdRow, INameRow,IMultiTenantRow
    {
        [DisplayName("ID"), Column("ICMTeamId"), Identity]
        public Int32? IcmTeamId
        {
            get { return Fields.IcmTeamId[this]; }
            set { Fields.IcmTeamId[this] = value; }
        }

        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow)), Required]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [Required]
        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow))]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [Required]
        [DisplayName("Part"), PrimaryKey, ForeignKey("[dbo].[Part]", "PartId"), LeftJoin("jPart"), TextualField("PartPartName")]
        [LookupEditor(typeof(Lookup.Entities.PartRow), InplaceAdd = true)]
        public Int16? PartId
        {
            get { return Fields.PartId[this]; }
            set { Fields.PartId[this] = value; }
        }

        [Required]
        [DisplayName("Cluster"), PrimaryKey, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster"), TextualField("Cname")]
        [LookupEditor(typeof(Locations.Entities.ClusterRow))]
        public Int32? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }

        [DisplayName("Monitor Name"), Size(255), NotNull]
        public String MonitorName
        {
            get { return Fields.MonitorName[this]; }
            set { Fields.MonitorName[this] = value; }
        }

        [DisplayName("Team Member Name"), Size(100), QuickSearch]
        public String TeamMemberName
        {
            get { return Fields.TeamMemberName[this]; }
            set { Fields.TeamMemberName[this] = value; }
        }

        [DisplayName("Team No"), NotNull]
        public string TeamNo
        {
            get { return Fields.TeamNo[this]; }
            set { Fields.TeamNo[this] = value; }
        }

        [DisplayName("Report Date"), NotNull]
        public DateTime? ReportDate
        {
            get { return Fields.ReportDate[this]; }
            set { Fields.ReportDate[this] = value; }
        }


        [DisplayName("Time of monitor visit")]
        public string MonitVisitTime
        {
            get { return Fields.MonitVisitTime[this]; }
            set { Fields.MonitVisitTime[this] = value; }
        }

        [DisplayName("Round"), Expression("jRound.[RoundName]"),QuickSearch]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }

        [DisplayName("Part"), Expression("jPart.[PartName]"),QuickSearch]
        public String PartName
        {
            get { return Fields.PartName[this]; }
            set { Fields.PartName[this] = value; }
        }

        [DisplayName("Cluster"), Expression("jCluster.[Cname]")]
        public String Cname
        {
            get { return Fields.Cname[this]; }
            set { Fields.Cname[this] = value; }
        }

        [DisplayName("At least one member resident of same area?"), NotNull]
        public Boolean? IsTeamResident
        {
            get { return Fields.IsTeamResident[this]; }
            set { Fields.IsTeamResident[this] = value; }
        }

        [DisplayName("Both vaccinators trained before this campaign?"), NotNull]
        public Boolean? BothTrained
        {
            get { return Fields.BothTrained[this]; }
            set { Fields.BothTrained[this] = value; }
        }

        [DisplayName("Do they have a clear itinary/map?"), NotNull]
        public Boolean? HaveClearMap
        {
            get { return Fields.HaveClearMap[this]; }
            set { Fields.HaveClearMap[this] = value; }
        }

        [DisplayName(" Able to clearly describe their area and boundaries?"), NotNull]
        public Boolean? AbleKnowArea
        {
            get { return Fields.AbleKnowArea[this]; }
            set { Fields.AbleKnowArea[this] = value; }
        }

        [DisplayName("Vaccination team going house-to-house"), NotNull]
        public Boolean? TeamGHtoH
        {
            get { return Fields.TeamGHtoH[this]; }
            set { Fields.TeamGHtoH[this] = value; }
        }

        [DisplayName("Are OPV vials kept dry?"), Column("OPVVialsKeptDry"), NotNull]
        public Boolean? OpvVialsKeptDry
        {
            get { return Fields.OpvVialsKeptDry[this]; }
            set { Fields.OpvVialsKeptDry[this] = value; }
        }

        [DisplayName("Is the team using vials at stage 3 or 4?"), Column("UsingOPVStage3or4"), NotNull]
        public Boolean? UsingOpvStage3or4
        {
            get { return Fields.UsingOpvStage3or4[this]; }
            set { Fields.UsingOpvStage3or4[this] = value; }
        }

        [DisplayName("Is team specially asking about 0-11 months children?"), NotNull]
        public Boolean? AskingAbout011C
        {
            get { return Fields.AskingAbout011C[this]; }
            set { Fields.AskingAbout011C[this] = value; }
        }

        [DisplayName("Is screening for guest/new born/sleeping/sick children?"), Column("AskingforGNSSC"), NotNull]
        public Boolean? AskingforGnssc
        {
            get { return Fields.AskingforGnssc[this]; }
            set { Fields.AskingforGnssc[this] = value; }
        }

        [DisplayName("Is team recording names of the absent/refusal children on the back of tally sheet?"), NotNull]
        public Boolean? RecNameOfAbsentRefC
        {
            get { return Fields.RecNameOfAbsentRefC[this]; }
            set { Fields.RecNameOfAbsentRefC[this] = value; }
        }

        [DisplayName("Is the team asking about AFP cases?"), Column("AskingAFPCases"), NotNull]
        public Boolean? AskingAfpCases
        {
            get { return Fields.AskingAfpCases[this]; }
            set { Fields.AskingAfpCases[this] = value; }
        }

        [DisplayName("Is the team visited by supervisor in the field and tally sheet signed?"), NotNull]
        public Boolean? VistedBySupervisor
        {
            get { return Fields.VistedBySupervisor[this]; }
            set { Fields.VistedBySupervisor[this] = value; }
        }

        [DisplayName("Is at least one member of the team CHW?"), Column("TeamHasACHW"), NotNull]
        public Boolean? TeamHasAchw
        {
            get { return Fields.TeamHasAchw[this]; }
            set { Fields.TeamHasAchw[this] = value; }
        }

        [DisplayName("Is any member of the team female?"), NotNull]
        public Boolean? TeamHasFemale
        {
            get { return Fields.TeamHasFemale[this]; }
            set { Fields.TeamHasFemale[this] = value; }
        }

        [DisplayName("Does social mobilizer accompany the vaccination team in the field?"), NotNull]
        public Boolean? SocMobAccompanyTeam
        {
            get { return Fields.SocMobAccompanyTeam[this]; }
            set { Fields.SocMobAccompanyTeam[this] = value; }
        }


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

        [Expression("p.[Pname]"),QuickSearch]
        public string Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }

        [DisplayName("District Dname"), Expression("jDistrict.[Dname]"),QuickSearch]
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

        [DisplayName("Date From"), Expression("jRound.[DateFrom]"), ReadOnly(true),QuickSearch]
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

        [DisplayName("Approved By"), NotNull]
        public Int32? ApprovedBy
        {
            get { return Fields.ApprovedBy[this]; }
            set { Fields.ApprovedBy[this] = value; }
        }

        [DisplayName("Approved"), NotNull]
        public Boolean? Approved
        {
            get { return Fields.Approved[this]; }
            set { Fields.Approved[this] = value; }
        }

        [DisplayName("Approval Date"), NotNull]
        public DateTime? ApprovalDate
        {
            get { return Fields.ApprovalDate[this]; }
            set { Fields.ApprovalDate[this] = value; }
        }

        [Insertable(true), Updatable(true)]
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
            get { return Fields.IcmTeamId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TeamMemberName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public IcmTeamRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IcmTeamId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public Int16Field PartId;
            public Int32Field ClusterId;
            public StringField TeamMemberName;
            public StringField TeamNo;
            public DateTimeField ReportDate;
            public StringField MonitorName;
            public StringField MonitVisitTime;
            public BooleanField IsTeamResident;
            public BooleanField BothTrained;
            public BooleanField HaveClearMap;
            public BooleanField AbleKnowArea;
            public BooleanField TeamGHtoH;
            public BooleanField OpvVialsKeptDry;
            public BooleanField UsingOpvStage3or4;
            public BooleanField AskingAbout011C;
            public BooleanField AskingforGnssc;
            public BooleanField RecNameOfAbsentRefC;
            public BooleanField AskingAfpCases;
            public BooleanField VistedBySupervisor;
            public BooleanField TeamHasAchw;
            public BooleanField TeamHasFemale;
            public BooleanField SocMobAccompanyTeam;

            public StringField RoundName;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public Int32Field TenantId;
            public StringField PartName;
            public StringField Cname;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField Province;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.IcmTeam";
            }
        }
    }
}
