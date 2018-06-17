
namespace webNEOC.Implementation.Entities
{
    using MultiTenancy;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[ICNDeployment]")]
    [DisplayName("Icn Deployment"), InstanceName("Icn Deployment"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class IcnDeploymentRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Icn Deployment Id"), Column("ICNDeploymentId"), Identity]
        public Int64? IcnDeploymentId
        {
            get { return Fields.IcnDeploymentId[this]; }
            set { Fields.IcnDeploymentId[this] = value; }
        }

        [DisplayName("District"), ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode")]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Planned Icn"), Column("PlannedICN")]
        public Int32? PlannedIcn
        {
            get { return Fields.PlannedIcn[this]; }
            set { Fields.PlannedIcn[this] = value; }
        }

        [DisplayName("Recruited Icn"), Column("RecruitedICN")]
        public Int32? RecruitedIcn
        {
            get { return Fields.RecruitedIcn[this]; }
            set { Fields.RecruitedIcn[this] = value; }
        }

        [DisplayName("Recruited Male")]
        public Int32? RecruitedMale
        {
            get { return Fields.RecruitedMale[this]; }
            set { Fields.RecruitedMale[this] = value; }
        }

        [DisplayName("Recruited Female")]
        public Int32? RecruitedFemale
        {
            get { return Fields.RecruitedFemale[this]; }
            set { Fields.RecruitedFemale[this] = value; }
        }

        [DisplayName("Icn Type"), Column("ICNTypeId"), ForeignKey("[dbo].[ICNType]", "ICNTypeId"), LeftJoin("jIcnType"), TextualField("IcnType")]
        public Int16? IcnTypeId
        {
            get { return Fields.IcnTypeId[this]; }
            set { Fields.IcnTypeId[this] = value; }
        }

        [DisplayName("Recruitment Type"), ForeignKey("[dbo].[RecruitmentType]", "RecruitmentTypeId"), LeftJoin("jRecruitmentType"), TextualField("RecruitmentType")]
        public Int16? RecruitmentTypeId
        {
            get { return Fields.RecruitmentTypeId[this]; }
            set { Fields.RecruitmentTypeId[this] = value; }
        }

        [DisplayName("Month"), ForeignKey("[dbo].[Months]", "MonthId"), LeftJoin("jMonth"), TextualField("MonthMonthshort")]
        public Int32? MonthId
        {
            get { return Fields.MonthId[this]; }
            set { Fields.MonthId[this] = value; }
        }

        [DisplayName("Year")]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
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

        [DisplayName("District Lat"), Expression("jDistrict.[LAT]")]
        public Double? DistrictLat
        {
            get { return Fields.DistrictLat[this]; }
            set { Fields.DistrictLat[this] = value; }
        }

        [DisplayName("District Lon"), Expression("jDistrict.[LON]")]
        public Double? DistrictLon
        {
            get { return Fields.DistrictLon[this]; }
            set { Fields.DistrictLon[this] = value; }
        }

        [DisplayName("District Backup Name"), Expression("jDistrict.[BackupName]")]
        public String DistrictBackupName
        {
            get { return Fields.DistrictBackupName[this]; }
            set { Fields.DistrictBackupName[this] = value; }
        }

        [DisplayName("District Map Name"), Expression("jDistrict.[MapName]")]
        public String DistrictMapName
        {
            get { return Fields.DistrictMapName[this]; }
            set { Fields.DistrictMapName[this] = value; }
        }

        [DisplayName("District Ld Ps"), Expression("jDistrict.[LDPs]")]
        public String DistrictLdPs
        {
            get { return Fields.DistrictLdPs[this]; }
            set { Fields.DistrictLdPs[this] = value; }
        }

        [DisplayName("Icn Type"), Expression("jIcnType.[ICNType]")]
        public String IcnType
        {
            get { return Fields.IcnType[this]; }
            set { Fields.IcnType[this] = value; }
        }

        [DisplayName("Recruitment Type"), Expression("jRecruitmentType.[RecruitmentType]")]
        public String RecruitmentType
        {
            get { return Fields.RecruitmentType[this]; }
            set { Fields.RecruitmentType[this] = value; }
        }

        [DisplayName("Month Monthshort"), Expression("jMonth.[Monthshort]")]
        public String MonthMonthshort
        {
            get { return Fields.MonthMonthshort[this]; }
            set { Fields.MonthMonthshort[this] = value; }
        }

        [DisplayName("Month Monthlong"), Expression("jMonth.[Monthlong]")]
        public String MonthMonthlong
        {
            get { return Fields.MonthMonthlong[this]; }
            set { Fields.MonthMonthlong[this] = value; }
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
            get { return Fields.IcnDeploymentId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DistrictDname; }
        }
        public static readonly RowFields Fields = new RowFields().Init();

        public IcnDeploymentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field IcnDeploymentId;
            public Int16Field DistrictId;
            public Int32Field PlannedIcn;
            public Int32Field RecruitedIcn;
            public Int32Field RecruitedMale;
            public Int32Field RecruitedFemale;
            public Int16Field IcnTypeId;
            public Int16Field RecruitmentTypeId;
            public Int32Field MonthId;
            public Int32Field Year;

            public StringField DistrictDcode;
            public Int16Field DistrictProvinceId;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;
            public DoubleField DistrictLat;
            public DoubleField DistrictLon;
            public StringField DistrictBackupName;
            public StringField DistrictMapName;
            public StringField DistrictLdPs;

            public StringField IcnType;

            public StringField RecruitmentType;

            public StringField MonthMonthshort;
            public StringField MonthMonthlong;

            public Int32Field TenantId;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.IcnDeployment";
            }
        }
    }
}
