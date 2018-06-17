
namespace webNEOC.PostCampaign.Entities
{
    using MultiTenancy;
    using Modules.PostCampaign;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[PCM]"), DisplayName("PCM"), InstanceName("PCM"), TwoLevelCached]
    [ReadPermission(PostCampaignPermissionKeys.Pcm.View)]
    [ModifyPermission(PostCampaignPermissionKeys.Pcm.Update)]
    [InsertPermission(PostCampaignPermissionKeys.Pcm.Insert)]
    [DeletePermission(PostCampaignPermissionKeys.Pcm.Delete)]
    public sealed class PcmRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Pcm Id"), Column("PCMId"), Identity]
        public Int32? PcmId
        {
            get { return Fields.PcmId[this]; }
            set { Fields.PcmId[this] = value; }
        }

        [DisplayName("Round"), PrimaryKey, ForeignKey(typeof(Lookup.Entities.RoundRow)), LeftJoin("jRound")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow))]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow))]
        public Int32? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Cluster"), PrimaryKey, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster"), TextualField("ClusterName"),LookupInclude]
        [LookupEditor(typeof(Locations.Entities.ClusterRow))]
        public Int64? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }


        [DisplayName("Cluster Level"), PrimaryKey, ForeignKey("[dbo].[ClusterLevel]", "ClusterLevelId"), LeftJoin("jClusterLevel"), LookupInclude]
        [LookupEditor(typeof(Lookup.Entities.ClusterLevelRow))]
        public Int16? ClusterLevelId
        {
            get { return Fields.ClusterLevelId[this]; }
            set { Fields.ClusterLevelId[this] = value; }
        }


        [DisplayName("Campaign Type"), ForeignKey("[dbo].[CampaignType]", "CampaignTypeId"), LeftJoin("jCampaignType"), TextualField("CampaignTypeName")]
        [LookupEditor(typeof(Lookup.Entities.CampaignTypeRow)),Required]
        public Int16? CampaignTypeId
        {
            get { return Fields.CampaignTypeId[this]; }
            set { Fields.CampaignTypeId[this] = value; }
        }

        [DisplayName("Cluster Code"), NotNull]
        public String ClusterCode
        {
            get { return Fields.ClusterCode[this]; }
            set { Fields.ClusterCode[this] = value; }
        }

        [DisplayName("Village"), Size(255), NotNull, QuickSearch]
        public String Village
        {
            get { return Fields.Village[this]; }
            set { Fields.Village[this] = value; }
        }

        [DisplayName("Visted Houses"), NotNull]
        public Int16? VistedHouses
        {
            get { return Fields.VistedHouses[this]; }
            set { Fields.VistedHouses[this] = value; }
        }

        [DisplayName("T 0-59m"), NotNull]
        public Int16? T059m
        {
            get { return Fields.T059m[this]; }
            set { Fields.T059m[this] = value; }
        }

        [DisplayName("V 0-59m"), NotNull]
        public Int16? V059m
        {
            get { return Fields.V059m[this]; }
            set { Fields.V059m[this] = value; }
        }

        [DisplayName("T 0-11 seen"), NotNull]
        public Int16? T011Seen
        {
            get { return Fields.T011Seen[this]; }
            set { Fields.T011Seen[this] = value; }
        }

        [DisplayName("FM 0-11 have FM"), Column("FM011HvFm"), NotNull]
        public Int16? Fm011HvFm
        {
            get { return Fields.Fm011HvFm[this]; }
            set { Fields.Fm011HvFm[this] = value; }
        }

        [DisplayName("T 12-59 seen"), NotNull]
        public Int16? T1259Seen
        {
            get { return Fields.T1259Seen[this]; }
            set { Fields.T1259Seen[this] = value; }
        }

        [DisplayName("FM 12-59 have FM"), Column("FM1259HvFm"), NotNull]
        public Int16? Fm1259HvFm
        {
            get { return Fields.Fm1259HvFm[this]; }
            set { Fields.Fm1259HvFm[this] = value; }
        }

        [DisplayName("T children no FM"), NotNull]
        public Int16? TChildrenNoFm
        {
            get { return Fields.TChildrenNoFm[this]; }
            set { Fields.TChildrenNoFm[this] = value; }
        }

        [DisplayName("R1 team did not visit"), NotNull]
        public Int16? R1TeamNoVisit
        {
            get { return Fields.R1TeamNoVisit[this]; }
            set { Fields.R1TeamNoVisit[this] = value; }
        }

        [DisplayName("R2.1 NA Madrasa, School, HF"), NotNull]
        public Int16? R21
        {
            get { return Fields.R21[this]; }
            set { Fields.R21[this] = value; }
        }

        [DisplayName("R2.2 NA Market, Street"), NotNull]
        public Int16? R22
        {
            get { return Fields.R22[this]; }
            set { Fields.R22[this] = value; }
        }

        [DisplayName("R2.3 NA Travel"), NotNull]
        public Int16? R23
        {
            get { return Fields.R23[this]; }
            set { Fields.R23[this] = value; }
        }

        [DisplayName("R2.4 NA Other"), NotNull]
        public Int16? R24
        {
            get { return Fields.R24[this]; }
            set { Fields.R24[this] = value; }
        }

        [DisplayName("R3.1 Refusal misperception"), NotNull]
        public Int16? R31
        {
            get { return Fields.R31[this]; }
            set { Fields.R31[this] = value; }
        }

        [DisplayName("R3.2 Refusal decision maker not at home"), NotNull]
        public Int16? R32
        {
            get { return Fields.R32[this]; }
            set { Fields.R32[this] = value; }
        }

        [DisplayName("R3.3 Newborn, sick or sleep children"), NotNull]
        public Int16? R33
        {
            get { return Fields.R33[this]; }
            set { Fields.R33[this] = value; }
        }

        [DisplayName("R4: Newborn"), NotNull]
        public Int16? R4NewBorn
        {
            get { return Fields.R4NewBorn[this]; }
            set { Fields.R4NewBorn[this] = value; }
        }

        [DisplayName("R5 Sleep"), NotNull]
        public Int16? R5Sleep
        {
            get { return Fields.R5Sleep[this]; }
            set { Fields.R5Sleep[this] = value; }
        }

        [DisplayName("R6 Sick"), NotNull]
        public Int16? R6Sick
        {
            get { return Fields.R6Sick[this]; }
            set { Fields.R6Sick[this] = value; }
        }

        [DisplayName("R7 Other"), NotNull]
        public Int16? R7Other
        {
            get { return Fields.R7Other[this]; }
            set { Fields.R7Other[this] = value; }
        }

        [DisplayName("DM Correct"), Column("DMCorrect"), NotNull]
        public Int16? DmCorrect
        {
            get { return Fields.DmCorrect[this]; }
            set { Fields.DmCorrect[this] = value; }
        }

        [DisplayName("DM Incorrect"), Column("DMIncorrect"), NotNull]
        public Int16? DmIncorrect
        {
            get { return Fields.DmIncorrect[this]; }
            set { Fields.DmIncorrect[this] = value; }
        }

        [DisplayName("No DM"), Column("NoDM"), NotNull]
        public Int16? NoDm
        {
            get { return Fields.NoDm[this]; }
            set { Fields.NoDm[this] = value; }
        }

        [DisplayName("Family heared about campaign"), Column("FMHeard"), NotNull]
        public Int16? FmHeard
        {
            get { return Fields.FmHeard[this]; }
            set { Fields.FmHeard[this] = value; }
        }

        [DisplayName("Family not heared about campaign"), Column("FMNotHeard"), NotNull]
        public Int16? FmNotHeard
        {
            get { return Fields.FmNotHeard[this]; }
            set { Fields.FmNotHeard[this] = value; }
        }

        [DisplayName("Radio"), NotNull]
        public Int16? Radio
        {
            get { return Fields.Radio[this]; }
            set { Fields.Radio[this] = value; }
        }

        [DisplayName("TV"), Column("TV"), NotNull]
        public Int16? Tv
        {
            get { return Fields.Tv[this]; }
            set { Fields.Tv[this] = value; }
        }

        [DisplayName("Mullah/Elders"), NotNull]
        public Int16? MullahElders
        {
            get { return Fields.MullahElders[this]; }
            set { Fields.MullahElders[this] = value; }
        }

        [DisplayName("Teacher"), NotNull]
        public Int16? Teacher
        {
            get { return Fields.Teacher[this]; }
            set { Fields.Teacher[this] = value; }
        }

        [DisplayName("Community Health Workers (CHW)"), Column("CHW"), NotNull]
        public Int16? Chw
        {
            get { return Fields.Chw[this]; }
            set { Fields.Chw[this] = value; }
        }

        [DisplayName("Community Elders"), NotNull]
        public Int16? CElders
        {
            get { return Fields.CElders[this]; }
            set { Fields.CElders[this] = value; }
        }

        [DisplayName("Poster Banner Leaflet"), Column("PBLeaflet"), NotNull]
        public Int16? PbLeaflet
        {
            get { return Fields.PbLeaflet[this]; }
            set { Fields.PbLeaflet[this] = value; }
        }

        [DisplayName("SM"), Column("SM"), NotNull]
        public Int16? Sm
        {
            get { return Fields.Sm[this]; }
            set { Fields.Sm[this] = value; }
        }

        [DisplayName("Other"), NotNull]
        public Int16? Other
        {
            get { return Fields.Other[this]; }
            set { Fields.Other[this] = value; }
        }

        [DisplayName("Children vaccinated by monitor"), NotNull]
        public Int16? ChVacByMonitor
        {
            get { return Fields.ChVacByMonitor[this]; }
            set { Fields.ChVacByMonitor[this] = value; }
        }

        [DisplayName("Recall coverage"), NotNull]
        [IntegerEditor(MinValue =0,MaxValue =100)]
        public Single? RCallCoverage
        {
            get { return Fields.RCallCoverage[this]; }
            set { Fields.RCallCoverage[this] = value; }
        }

        [DisplayName("FM 0-59M coverage"), Column("FM059Coverage"), NotNull]
        [IntegerEditor(MinValue = 0, MaxValue = 100)]
        public Single? Fm059Coverage
        {
            get { return Fields.Fm059Coverage[this]; }
            set { Fields.Fm059Coverage[this] = value; }
        }

        [DisplayName("FM 0-11m coverage"), Column("FM011Coverage"), NotNull]
        [IntegerEditor(MinValue = 0, MaxValue = 100)]
        public Single? Fm011Coverage
        {
            get { return Fields.Fm011Coverage[this]; }
            set { Fields.Fm011Coverage[this] = value; }
        }

        [DisplayName("In Aces Children"), DefaultValue(0)]
        public Int16? InAcesChildren
        {
            get { return Fields.InAcesChildren[this]; }
            set { Fields.InAcesChildren[this] = value; }
        }

        [DisplayName("Round"), Expression("jRound.[RoundName]"),QuickSearch]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }

        [DisplayName("Cluster Level"), Expression("jClusterLevel.[ClusterName]"),QuickSearch]
        public String LevelName
        {
            get { return Fields.LevelName[this]; }
            set { Fields.LevelName[this] = value; }
        }

        [DisplayName("Cluster"), Expression("jCluster.[CName]"),LookupInclude,QuickSearch]
        public String ClusterName
        {
            get { return Fields.ClusterName[this]; }
            set { Fields.ClusterName[this] = value; }
        }

        [DisplayName("Campaign Type"), Expression("jCampaignType.[CampaignName]")]
        public String CampaignTypeName
        {
            get { return Fields.CampaignTypeName[this]; }
            set { Fields.CampaignTypeName[this] = value; }
        }

        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [DisplayName("Province"), Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("p")]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
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

        [DisplayName("Date From"), Expression("jRound.[DateFrom]"),ReadOnly(true)]
        public DateTime? DateFrom
        {
            get { return Fields.DateFrom[this]; }
            set { Fields.DateFrom[this] = value; }
        }

        [DisplayName("Date To"), Expression("jRound.[DateTo]"),ReadOnly(true)]
        public DateTime? DateTo
        {
            get { return Fields.DateTo[this]; }
            set { Fields.DateTo[this] = value; }
        }

        [Expression("p.[Pname]")]
        public string Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
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
            get { return Fields.PcmId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Village; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PcmRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PcmId;
            public Int16Field RoundId;
            public Int32Field DistrictId;
            public Int16Field ClusterLevelId;
            public Int64Field ClusterId;
            public Int16Field CampaignTypeId;
            public StringField ClusterCode;
            public StringField Village;
            public Int16Field VistedHouses;
            public Int16Field T059m;
            public Int16Field V059m;
            public Int16Field T011Seen;
            public Int16Field Fm011HvFm;
            public Int16Field T1259Seen;
            public Int16Field Fm1259HvFm;
            public Int16Field TChildrenNoFm;
            public Int16Field R1TeamNoVisit;
            public Int16Field R21;
            public Int16Field R22;
            public Int16Field R23;
            public Int16Field R24;
            public Int16Field R31;
            public Int16Field R32;
            public Int16Field R33;
            public Int16Field R4NewBorn;
            public Int16Field R5Sleep;
            public Int16Field R6Sick;
            public Int16Field R7Other;
            public Int16Field DmCorrect;
            public Int16Field DmIncorrect;
            public Int16Field NoDm;
            public Int16Field FmHeard;
            public Int16Field FmNotHeard;
            public Int16Field Radio;
            public Int16Field Tv;
            public Int16Field MullahElders;
            public Int16Field Teacher;
            public Int16Field Chw;
            public Int16Field CElders;
            public Int16Field PbLeaflet;
            public Int16Field Sm;
            public Int16Field Other;
            public Int16Field ChVacByMonitor;
            public SingleField RCallCoverage;
            public SingleField Fm059Coverage;
            public SingleField Fm011Coverage;
            public Int16Field InAcesChildren;

            public DateTimeField DateFrom;
            public DateTimeField DateTo;

            public StringField RoundName;
            public StringField ClusterName;
            public StringField LevelName;
            public StringField CampaignTypeName;
            public Int32Field TenantId;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField DistrictDname;
            public StringField Province;
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
                LocalTextPrefix = "PostCampaign.Pcm";
            }
        }
    }
}
