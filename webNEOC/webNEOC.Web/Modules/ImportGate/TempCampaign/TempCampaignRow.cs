
namespace webNEOC.ImportGate.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[TempCampaign]"), DisplayName("Campaign Import"), InstanceName("Campaign"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TempCampaignRow : Row, IIdRow, INameRow
    {
        [DisplayName("Temp Campaign Id"), Identity,PrimaryKey]
        public Int64? TempCampaignId
        {
            get { return Fields.TempCampaignId[this]; }
            set { Fields.TempCampaignId[this] = value; }
        }

        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow)), Required]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }
        [DisplayName("Round"), Expression("jRound.[RoundName]")]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }
        [DisplayName("Province"), PrimaryKey, ForeignKey("[dbo].[Province]", "ProvinceId"), LeftJoin("p")]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow)),Required]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }
        [Expression("p.[Pname]")]
        public string ProvinceName
        {
            get { return Fields.ProvinceName[this]; }
            set { Fields.ProvinceName[this] = value; }
        }
        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow))]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }
        [DisplayName("District Name"), Expression("jDistrict.[Dname]")]
        public String DistrictName
        {
            get { return Fields.DistrictName[this]; }
            set { Fields.DistrictName[this] = value; }
        }
        [DisplayName("Date Of Campaign"), NotNull]
        public DateTime? DateOfCampaign
        {
            get { return Fields.DateOfCampaign[this]; }
            set { Fields.DateOfCampaign[this] = value; }
        }

        [DisplayName("Pemtremt Manager"), Column("PEMTREMTManager"), Size(255), NotNull, QuickSearch]
        public String PemtremtManager
        {
            get { return Fields.PemtremtManager[this]; }
            set { Fields.PemtremtManager[this] = value; }
        }

        [DisplayName("Cluster"), PrimaryKey, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster"), TextualField("Cname")]
        [LookupEditor(typeof(Locations.Entities.ClusterRow))]
        public Int64? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }
        [DisplayName("Cluster Name"), Expression("jCluster.[Cname]")]
        public String ClusterName
        {
            get { return Fields.ClusterName[this]; }
            set { Fields.ClusterName[this] = value; }
        }
        [DisplayName("Target U5 Case"), NotNull]
        public Int32? TargetU5Case
        {
            get { return Fields.TargetU5Case[this]; }
            set { Fields.TargetU5Case[this] = value; }
        }

        [DisplayName("Team No"), Size(50)]
        public String TeamNo
        {
            get { return Fields.TeamNo[this]; }
            set { Fields.TeamNo[this] = value; }
        }

        [DisplayName("Hh No"), Column("HHNo")]
        public Int16? HhNo
        {
            get { return Fields.HhNo[this]; }
            set { Fields.HhNo[this] = value; }
        }

        [DisplayName("D1 Vial Dist"), Column("d1VialDist"), NotNull]
        public Int16? D1VialDist
        {
            get { return Fields.D1VialDist[this]; }
            set { Fields.D1VialDist[this] = value; }
        }

        [DisplayName("D1 Vial Use"), Column("d1VialUse"), NotNull]
        public Int16? D1VialUse
        {
            get { return Fields.D1VialUse[this]; }
            set { Fields.D1VialUse[this] = value; }
        }

        [DisplayName("D1 Vac011 Months"), Column("d1Vac011Months"), NotNull]
        public Int16? D1Vac011Months
        {
            get { return Fields.D1Vac011Months[this]; }
            set { Fields.D1Vac011Months[this] = value; }
        }

        [DisplayName("D1 Vac1259months"), Column("d1Vac1259months"), NotNull]
        public Int16? D1Vac1259months
        {
            get { return Fields.D1Vac1259months[this]; }
            set { Fields.D1Vac1259months[this] = value; }
        }

        [DisplayName("D1 Rec Abs Children"), Column("d1RecAbsChildren"), NotNull]
        public Int16? D1RecAbsChildren
        {
            get { return Fields.D1RecAbsChildren[this]; }
            set { Fields.D1RecAbsChildren[this] = value; }
        }

        [DisplayName("D1 Vac Abs Children"), Column("d1VacAbsChildren"), NotNull]
        public Int16? D1VacAbsChildren
        {
            get { return Fields.D1VacAbsChildren[this]; }
            set { Fields.D1VacAbsChildren[this] = value; }
        }

        [DisplayName("D1 Rec Newborn Ssc"), Column("d1RecNewbornSSC"), NotNull]
        public Int16? D1RecNewbornSsc
        {
            get { return Fields.D1RecNewbornSsc[this]; }
            set { Fields.D1RecNewbornSsc[this] = value; }
        }

        [DisplayName("D1 Vac Newborn Ssc"), Column("d1VacNewbornSSC"), NotNull]
        public Int16? D1VacNewbornSsc
        {
            get { return Fields.D1VacNewbornSsc[this]; }
            set { Fields.D1VacNewbornSsc[this] = value; }
        }

        [DisplayName("D1 Rec Refused Children"), Column("d1RecRefusedChildren"), NotNull]
        public Int16? D1RecRefusedChildren
        {
            get { return Fields.D1RecRefusedChildren[this]; }
            set { Fields.D1RecRefusedChildren[this] = value; }
        }

        [DisplayName("D1 Revac Refused Children"), Column("d1RevacRefusedChildren"), NotNull]
        public Int16? D1RevacRefusedChildren
        {
            get { return Fields.D1RevacRefusedChildren[this]; }
            set { Fields.D1RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D1 Afp Case"), Column("d1AFPCase"), NotNull]
        public Int16? D1AfpCase
        {
            get { return Fields.D1AfpCase[this]; }
            set { Fields.D1AfpCase[this] = value; }
        }

        [DisplayName("D2 Vial Dist"), Column("d2VialDist"), NotNull]
        public Int16? D2VialDist
        {
            get { return Fields.D2VialDist[this]; }
            set { Fields.D2VialDist[this] = value; }
        }

        [DisplayName("D2 Vial Use"), Column("d2VialUse"), NotNull]
        public Int16? D2VialUse
        {
            get { return Fields.D2VialUse[this]; }
            set { Fields.D2VialUse[this] = value; }
        }

        [DisplayName("D2 Vac011 Months"), Column("d2Vac011Months"), NotNull]
        public Int16? D2Vac011Months
        {
            get { return Fields.D2Vac011Months[this]; }
            set { Fields.D2Vac011Months[this] = value; }
        }

        [DisplayName("D2 Vac1259months"), Column("d2Vac1259months"), NotNull]
        public Int16? D2Vac1259months
        {
            get { return Fields.D2Vac1259months[this]; }
            set { Fields.D2Vac1259months[this] = value; }
        }

        [DisplayName("D2 Rec Abs Children"), Column("d2RecAbsChildren"), NotNull]
        public Int16? D2RecAbsChildren
        {
            get { return Fields.D2RecAbsChildren[this]; }
            set { Fields.D2RecAbsChildren[this] = value; }
        }

        [DisplayName("D2 Vac Abs Children"), Column("d2VacAbsChildren"), NotNull]
        public Int16? D2VacAbsChildren
        {
            get { return Fields.D2VacAbsChildren[this]; }
            set { Fields.D2VacAbsChildren[this] = value; }
        }

        [DisplayName("D2 Rec Newborn Ssc"), Column("d2RecNewbornSSC"), NotNull]
        public Int16? D2RecNewbornSsc
        {
            get { return Fields.D2RecNewbornSsc[this]; }
            set { Fields.D2RecNewbornSsc[this] = value; }
        }

        [DisplayName("D2 Vac Newborn Ssc"), Column("d2VacNewbornSSC"), NotNull]
        public Int16? D2VacNewbornSsc
        {
            get { return Fields.D2VacNewbornSsc[this]; }
            set { Fields.D2VacNewbornSsc[this] = value; }
        }

        [DisplayName("D2 Rec Refused Children"), Column("d2RecRefusedChildren"), NotNull]
        public Int16? D2RecRefusedChildren
        {
            get { return Fields.D2RecRefusedChildren[this]; }
            set { Fields.D2RecRefusedChildren[this] = value; }
        }

        [DisplayName("D2 Revac Refused Children"), Column("d2RevacRefusedChildren"), NotNull]
        public Int16? D2RevacRefusedChildren
        {
            get { return Fields.D2RevacRefusedChildren[this]; }
            set { Fields.D2RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D2 Afp Case"), Column("d2AFPCase"), NotNull]
        public Int16? D2AfpCase
        {
            get { return Fields.D2AfpCase[this]; }
            set { Fields.D2AfpCase[this] = value; }
        }

        [DisplayName("D3 Vial Dist"), Column("d3VialDist"), NotNull]
        public Int16? D3VialDist
        {
            get { return Fields.D3VialDist[this]; }
            set { Fields.D3VialDist[this] = value; }
        }

        [DisplayName("D3 Vial Use"), Column("d3VialUse"), NotNull]
        public Int16? D3VialUse
        {
            get { return Fields.D3VialUse[this]; }
            set { Fields.D3VialUse[this] = value; }
        }

        [DisplayName("D3 Vac011 Months"), Column("d3Vac011Months"), NotNull]
        public Int16? D3Vac011Months
        {
            get { return Fields.D3Vac011Months[this]; }
            set { Fields.D3Vac011Months[this] = value; }
        }

        [DisplayName("D3 Vac1259months"), Column("d3Vac1259months"), NotNull]
        public Int16? D3Vac1259months
        {
            get { return Fields.D3Vac1259months[this]; }
            set { Fields.D3Vac1259months[this] = value; }
        }

        [DisplayName("D3 Rec Abs Children"), Column("d3RecAbsChildren"), NotNull]
        public Int16? D3RecAbsChildren
        {
            get { return Fields.D3RecAbsChildren[this]; }
            set { Fields.D3RecAbsChildren[this] = value; }
        }

        [DisplayName("D3 Vac Abs Children"), Column("d3VacAbsChildren"), NotNull]
        public Int16? D3VacAbsChildren
        {
            get { return Fields.D3VacAbsChildren[this]; }
            set { Fields.D3VacAbsChildren[this] = value; }
        }

        [DisplayName("D3 Rec Newborn Ssc"), Column("d3RecNewbornSSC"), NotNull]
        public Int16? D3RecNewbornSsc
        {
            get { return Fields.D3RecNewbornSsc[this]; }
            set { Fields.D3RecNewbornSsc[this] = value; }
        }

        [DisplayName("D3 Vac Newborn Ssc"), Column("d3VacNewbornSSC"), NotNull]
        public Int16? D3VacNewbornSsc
        {
            get { return Fields.D3VacNewbornSsc[this]; }
            set { Fields.D3VacNewbornSsc[this] = value; }
        }

        [DisplayName("D3 Rec Refused Children"), Column("d3RecRefusedChildren"), NotNull]
        public Int16? D3RecRefusedChildren
        {
            get { return Fields.D3RecRefusedChildren[this]; }
            set { Fields.D3RecRefusedChildren[this] = value; }
        }

        [DisplayName("D3 Revac Refused Children"), Column("d3RevacRefusedChildren"), NotNull]
        public Int16? D3RevacRefusedChildren
        {
            get { return Fields.D3RevacRefusedChildren[this]; }
            set { Fields.D3RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D3 Afp Case"), Column("d3AFPCase"), NotNull]
        public Int16? D3AfpCase
        {
            get { return Fields.D3AfpCase[this]; }
            set { Fields.D3AfpCase[this] = value; }
        }

        [DisplayName("D5 Vial Dist"), Column("d5VialDist"), NotNull]
        public Int16? D5VialDist
        {
            get { return Fields.D5VialDist[this]; }
            set { Fields.D5VialDist[this] = value; }
        }

        [DisplayName("D5 Vial Use"), Column("d5VialUse"), NotNull]
        public Int16? D5VialUse
        {
            get { return Fields.D5VialUse[this]; }
            set { Fields.D5VialUse[this] = value; }
        }

        [DisplayName("D5 Vac011 Months"), Column("d5Vac011Months"), NotNull]
        public Int16? D5Vac011Months
        {
            get { return Fields.D5Vac011Months[this]; }
            set { Fields.D5Vac011Months[this] = value; }
        }

        [DisplayName("D5 Vac1259months"), Column("d5Vac1259months"), NotNull]
        public Int16? D5Vac1259months
        {
            get { return Fields.D5Vac1259months[this]; }
            set { Fields.D5Vac1259months[this] = value; }
        }

        [DisplayName("D5 Rec Abs Children"), Column("d5RecAbsChildren"), NotNull]
        public Int16? D5RecAbsChildren
        {
            get { return Fields.D5RecAbsChildren[this]; }
            set { Fields.D5RecAbsChildren[this] = value; }
        }

        [DisplayName("D5 Vac Abs Children"), Column("d5VacAbsChildren"), NotNull]
        public Int16? D5VacAbsChildren
        {
            get { return Fields.D5VacAbsChildren[this]; }
            set { Fields.D5VacAbsChildren[this] = value; }
        }

        [DisplayName("D5 Rec Newborn Ssc"), Column("d5RecNewbornSSC"), NotNull]
        public Int16? D5RecNewbornSsc
        {
            get { return Fields.D5RecNewbornSsc[this]; }
            set { Fields.D5RecNewbornSsc[this] = value; }
        }

        [DisplayName("D5 Vac Newborn Ssc"), Column("d5VacNewbornSSC"), NotNull]
        public Int16? D5VacNewbornSsc
        {
            get { return Fields.D5VacNewbornSsc[this]; }
            set { Fields.D5VacNewbornSsc[this] = value; }
        }

        [DisplayName("D5 Rec Refused Children"), Column("d5RecRefusedChildren"), NotNull]
        public Int16? D5RecRefusedChildren
        {
            get { return Fields.D5RecRefusedChildren[this]; }
            set { Fields.D5RecRefusedChildren[this] = value; }
        }

        [DisplayName("D5 Revac Refused Children"), Column("d5RevacRefusedChildren"), NotNull]
        public Int16? D5RevacRefusedChildren
        {
            get { return Fields.D5RevacRefusedChildren[this]; }
            set { Fields.D5RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D5 Afp Case"), Column("d5AFPCase"), NotNull]
        public Int16? D5AfpCase
        {
            get { return Fields.D5AfpCase[this]; }
            set { Fields.D5AfpCase[this] = value; }
        }

        [DisplayName("LDP Type")]
        public string LDPTypes
        {
            get { return Fields.LDPTypes[this]; }
            set { Fields.LDPTypes[this] = value; }
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
            get { return Fields.TempCampaignId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PemtremtManager; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TempCampaignRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field TempCampaignId;
            public Int16Field RoundId;
            public Int16Field ProvinceId;
            public Int16Field DistrictId;
            public DateTimeField DateOfCampaign;
            public StringField PemtremtManager;
            public Int64Field ClusterId;
            public Int32Field TargetU5Case;
            public StringField TeamNo;
            public Int16Field HhNo;
            public Int16Field D1VialDist;
            public Int16Field D1VialUse;
            public Int16Field D1Vac011Months;
            public Int16Field D1Vac1259months;
            public Int16Field D1RecAbsChildren;
            public Int16Field D1VacAbsChildren;
            public Int16Field D1RecNewbornSsc;
            public Int16Field D1VacNewbornSsc;
            public Int16Field D1RecRefusedChildren;
            public Int16Field D1RevacRefusedChildren;
            public Int16Field D1AfpCase;
            public Int16Field D2VialDist;
            public Int16Field D2VialUse;
            public Int16Field D2Vac011Months;
            public Int16Field D2Vac1259months;
            public Int16Field D2RecAbsChildren;
            public Int16Field D2VacAbsChildren;
            public Int16Field D2RecNewbornSsc;
            public Int16Field D2VacNewbornSsc;
            public Int16Field D2RecRefusedChildren;
            public Int16Field D2RevacRefusedChildren;
            public Int16Field D2AfpCase;
            public Int16Field D3VialDist;
            public Int16Field D3VialUse;
            public Int16Field D3Vac011Months;
            public Int16Field D3Vac1259months;
            public Int16Field D3RecAbsChildren;
            public Int16Field D3VacAbsChildren;
            public Int16Field D3RecNewbornSsc;
            public Int16Field D3VacNewbornSsc;
            public Int16Field D3RecRefusedChildren;
            public Int16Field D3RevacRefusedChildren;
            public Int16Field D3AfpCase;
            public Int16Field D5VialDist;
            public Int16Field D5VialUse;
            public Int16Field D5Vac011Months;
            public Int16Field D5Vac1259months;
            public Int16Field D5RecAbsChildren;
            public Int16Field D5VacAbsChildren;
            public Int16Field D5RecNewbornSsc;
            public Int16Field D5VacNewbornSsc;
            public Int16Field D5RecRefusedChildren;
            public Int16Field D5RevacRefusedChildren;
            public Int16Field D5AfpCase;
            public Int32Field TenantId;

            public StringField RoundName;
            public StringField ProvinceName;
            public StringField DistrictName;
            public StringField ClusterName;
            public StringField LDPTypes;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "ImportGate.TempCampaign";
            }
        }
    }
}
