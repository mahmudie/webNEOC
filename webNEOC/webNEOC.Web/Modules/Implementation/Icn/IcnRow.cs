
namespace webNEOC.Implementation.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[ICN]"), DisplayName("ICN Records"), InstanceName("ICN Records"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class IcnRow : Row, IIdRow, INameRow
    {
        [DisplayName("Icn Id"), Column("ICNId"),Identity, PrimaryKey]
        public Guid? IcnId
        {
            get { return Fields.IcnId[this]; }
            set { Fields.IcnId[this] = value; }
        }

        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow)), Required]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [DisplayName("District"), NotNull, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode")]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [Required]
        [DisplayName("Cluster"), PrimaryKey, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster"), TextualField("Cname")]
        [LookupEditor(typeof(Locations.Entities.ClusterRow))]
        public Int64? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }

        [DisplayName("Cluster"), Expression("jCluster.[Cname]")]
        public String Cname
        {
            get { return Fields.Cname[this]; }
            set { Fields.Cname[this] = value; }
        }


        [DisplayName("Round"), Expression("jRound.[RoundName]"), QuickSearch]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }

        [DisplayName("Area"), Size(70), QuickSearch]
        public String Area
        {
            get { return Fields.Area[this]; }
            set { Fields.Area[this] = value; }
        }

        [DisplayName("Registered Absent"), NotNull]
        public Int16? RegAbsent
        {
            get { return Fields.RegAbsent[this]; }
            set { Fields.RegAbsent[this] = value; }
        }

        [DisplayName("Vaccinated Absent"), NotNull]
        public Int16? VacAbsent
        {
            get { return Fields.VacAbsent[this]; }
            set { Fields.VacAbsent[this] = value; }
        }

        [DisplayName("Registered Newborn/Sick/Sleep (NSS)"), Column("RegNSS"), NotNull]
        public Int16? RegNss
        {
            get { return Fields.RegNss[this]; }
            set { Fields.RegNss[this] = value; }
        }

        [DisplayName("Vaccinated Newborn/Sick/Sleep (NSS)"), Column("VacNSS"), NotNull]
        public Int16? VacNss
        {
            get { return Fields.VacNss[this]; }
            set { Fields.VacNss[this] = value; }
        }

        [DisplayName("Registered Refusal"), NotNull]
        public Int16? RegRefusal
        {
            get { return Fields.RegRefusal[this]; }
            set { Fields.RegRefusal[this] = value; }
        }

        [DisplayName("Vaccinated Refusal"), NotNull]
        public Int16? VacRefusal
        {
            get { return Fields.VacRefusal[this]; }
            set { Fields.VacRefusal[this] = value; }
        }

        [DisplayName("Unrecorded"), NotNull]
        public Int16? RegUnrecorded
        {
            get { return Fields.RegUnrecorded[this]; }
            set { Fields.RegUnrecorded[this] = value; }
        }

        [DisplayName("Vaccinated Unrecorded"), NotNull]
        public Int16? VacUnrecorded
        {
            get { return Fields.VacUnrecorded[this]; }
            set { Fields.VacUnrecorded[this] = value; }
        }

        [DisplayName("Tenant Id"), NotNull]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [DisplayName("District Province Id"), Expression("jDistrict.[ProvinceId]")]
        public Int16? DistrictProvinceId
        {
            get { return Fields.DistrictProvinceId[this]; }
            set { Fields.DistrictProvinceId[this] = value; }
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
        [DisplayName("Province Id"), Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("p")]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [Expression("p.[Pname]"), QuickSearch]
        public string Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }
        [DisplayName("Date From"), Expression("jRound.[DateFrom]"), ReadOnly(true), QuickSearch]
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


        IIdField IIdRow.IdField
        {
            get { return Fields.IcnId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Area; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public IcnRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField IcnId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public Int64Field ClusterId;
            public StringField Area;
            public Int16Field RegAbsent;
            public Int16Field VacAbsent;
            public Int16Field RegNss;
            public Int16Field VacNss;
            public Int16Field RegRefusal;
            public Int16Field VacRefusal;
            public Int16Field RegUnrecorded;
            public Int16Field VacUnrecorded;
            public Int32Field TenantId;

            public StringField DistrictDcode;
            public Int16Field DistrictProvinceId;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;
            public Int16Field ProvinceId;
            public StringField Province;

            public StringField RoundName;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public StringField Cname;

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.Icn";
            }
        }
    }
}
