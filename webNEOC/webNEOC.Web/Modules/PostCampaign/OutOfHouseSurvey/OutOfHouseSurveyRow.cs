
namespace webNEOC.PostCampaign.Entities
{
    using Serenity;
    using Modules.PostCampaign;
    using MultiTenancy;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[OutOfHouseSurvey]"), DisplayName("Out Of House Survey"), InstanceName("Out Of House Survey"), TwoLevelCached]
    [ReadPermission(PostCampaignPermissionKeys.OutOfHouseSurvey.View)]
    [ModifyPermission(PostCampaignPermissionKeys.OutOfHouseSurvey.Update)]
    [InsertPermission(PostCampaignPermissionKeys.OutOfHouseSurvey.Insert)]
    [DeletePermission(PostCampaignPermissionKeys.OutOfHouseSurvey.Delete)]
    public sealed class OutOfHouseSurveyRow : Row, IIdRow, IMultiTenantRow
    {
        [DisplayName("ID"), Identity]
        public Int64? OutOfHouseSurveyId
        {
            get { return Fields.OutOfHouseSurveyId[this]; }
            set { Fields.OutOfHouseSurveyId[this] = value; }
        }

        [Serenity.ComponentModel.Required]
        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName"), DefaultValue("NA")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow))]
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

        [DisplayName("Date"), NotNull,PrimaryKey]
        public DateTime? ReportDate
        {
            get { return Fields.ReportDate[this]; }
            set { Fields.ReportDate[this] = value; }
        }

        [DisplayName("Male 0-59m Seen"), NotNull]
        public Int16? T059m
        {
            get { return Fields.T059m[this]; }
            set { Fields.T059m[this] = value; }
        }

        [DisplayName("Male 0-59m vaccinated"), NotNull]
        public Int16? Vac059m
        {
            get { return Fields.Vac059m[this]; }
            set { Fields.Vac059m[this] = value; }
        }

        [DisplayName("Male 0-59m with finger mark"), Column("FM059m"), NotNull]
        public Int16? FM059m
        {
            get { return Fields.FM059m[this]; }
            set { Fields.FM059m[this] = value; }
        }

        [DisplayName("Female 0-59m Seen"), NotNull]
        public Int16? T059f
        {
            get { return Fields.T059f[this]; }
            set { Fields.T059f[this] = value; }
        }

        [DisplayName("Female 0-59m vaccinated"), NotNull]
        public Int16? Vac059f
        {
            get { return Fields.Vac059f[this]; }
            set { Fields.Vac059f[this] = value; }
        }

        [DisplayName("Female 0-59m with finger mark"), Column("FM059f"), NotNull]
        public Int16? FM059f
        {
            get { return Fields.FM059f[this]; }
            set { Fields.FM059f[this] = value; }
        }

        [DisplayName("Missed team not come"), Column("MissTmNotCome"),DefaultValue(0)]
        public Int16? MissTmNotCome
        {
            get { return Fields.MissTmNotCome[this]; }
            set { Fields.MissTmNotCome[this] = value; }
        }

        [DisplayName("Missed children absent"), Column("MissAbsent"), DefaultValue(0)]
        public Int16? MissAbsent
        {
            get { return Fields.MissAbsent[this]; }
            set { Fields.MissAbsent[this] = value; }
        }


        [DisplayName("Missed children refrused"), Column("MissRefused"), DefaultValue(0)]
        public Int16? MissRefused
        {
            get { return Fields.MissRefused[this]; }
            set { Fields.MissRefused[this] = value; }
        }

        [DisplayName("Missed newborn, sick or sleep"), Column("MissNewBornSick"), DefaultValue(0)]
        public Int16? MissNewBornSick
        {
            get { return Fields.MissNewBornSick[this]; }
            set { Fields.MissNewBornSick[this] = value; }
        }

        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [DisplayName("Province Id"), Expression("jDistrict.[ProvinceId]"),ForeignKey("Province","ProvinceId"),LeftJoin("p")]
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

        [DisplayName("Round"), Expression("jRound.[RoundName]")]
        public string RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }

        [DisplayName("Date From"), Expression("jRound.[DateFrom]"),ReadOnly(true),QuickSearch]
        public DateTime? DateFrom
        {
            get { return Fields.DateFrom[this]; }
            set { Fields.DateFrom[this] = value; }
        }


        [DisplayName("Date To"), Expression("jRound.[DateTo]"),ReadOnly(true),QuickSearch]
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
            get { return Fields.OutOfHouseSurveyId; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public OutOfHouseSurveyRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field OutOfHouseSurveyId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public DateTimeField ReportDate;
            public Int16Field T059m;
            public Int16Field Vac059m;
            public Int16Field FM059m;
            public Int16Field T059f;
            public Int16Field Vac059f;
            public Int16Field FM059f;
            public Int16Field MissTmNotCome;
            public Int16Field MissAbsent;
            public Int16Field MissRefused;
            public Int16Field MissNewBornSick;

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

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "PostCampaign.OutOfHouseSurvey";
            }
        }
    }
}
