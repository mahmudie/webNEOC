
namespace webNEOC.Implementation.Entities
{
    using Serenity;
    using Modules.Implementation;
    using MultiTenancy;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[VitaminA]"), DisplayName("Vitamin A"), InstanceName("Vitamin A"), TwoLevelCached]
    [ReadPermission(ImplementationPermissionKeys.VitaminA.View)]
    [ModifyPermission(ImplementationPermissionKeys.VitaminA.Update)]
    [InsertPermission(ImplementationPermissionKeys.VitaminA.Insert)]
    [DeletePermission(ImplementationPermissionKeys.VitaminA.Delete)]
    public sealed class VitaminARow : Row, IIdRow, INameRow,IMultiTenantRow
    {
        [DisplayName("ID"), Identity]
        public Int64? VitaminADayId
        {
            get { return Fields.VitaminADayId[this]; }
            set { Fields.VitaminADayId[this] = value; }
        }

        [DisplayName("Round"), NotNull, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow), InplaceAdd = true)]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }


        [DisplayName("Province"), NotNull, ForeignKey("[dbo].[Province]", "ProvinceId"), LeftJoin("jProvince"), TextualField("ProvincePcode")]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow),InplaceAdd =false)]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [DisplayName("District"), NotNull, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDname")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow),InplaceAdd =true)]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }


        [DisplayName("PEMT/REM Mgr"), Column("PEMTREMTManager"), Size(255), NotNull, QuickSearch]
        public String PemtremtManager
        {
            get { return Fields.PemtremtManager[this]; }
            set { Fields.PemtremtManager[this] = value; }
        }



        [DisplayName("Province Pcode"), Expression("jProvince.[Pcode]")]
        public String ProvincePcode
        {
            get { return Fields.ProvincePcode[this]; }
            set { Fields.ProvincePcode[this] = value; }
        }

        [DisplayName("Province Region Id"), Expression("jProvince.[RegionID]")]
        public Int16? ProvinceRegionId
        {
            get { return Fields.ProvinceRegionId[this]; }
            set { Fields.ProvinceRegionId[this] = value; }
        }

        [DisplayName("Province Pname"), Expression("jProvince.[Pname]"),QuickSearch]
        public String ProvincePname
        {
            get { return Fields.ProvincePname[this]; }
            set { Fields.ProvincePname[this] = value; }
        }

        [DisplayName("Province P Abrv"), Expression("jProvince.[PAbrv]")]
        public String ProvincePAbrv
        {
            get { return Fields.ProvincePAbrv[this]; }
            set { Fields.ProvincePAbrv[this] = value; }
        }

        [DisplayName("Province Pcenter"), Expression("jProvince.[Pcenter]")]
        public String ProvincePcenter
        {
            get { return Fields.ProvincePcenter[this]; }
            set { Fields.ProvincePcenter[this] = value; }
        }

        [DisplayName("Province Area Km Sqr"), Expression("jProvince.[AreaKmSqr]")]
        public Int16? ProvinceAreaKmSqr
        {
            get { return Fields.ProvinceAreaKmSqr[this]; }
            set { Fields.ProvinceAreaKmSqr[this] = value; }
        }

        [DisplayName("Province No Of Districts"), Expression("jProvince.[NoOfDistricts]")]
        public Int32? ProvinceNoOfDistricts
        {
            get { return Fields.ProvinceNoOfDistricts[this]; }
            set { Fields.ProvinceNoOfDistricts[this] = value; }
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

        [DisplayName("District"), Expression("jDistrict.[Dname]"),QuickSearch]
        public String DistrictDname
        {
            get { return Fields.DistrictDname[this]; }
            set { Fields.DistrictDname[this] = value; }
        }

        [DisplayName("RoundName"), Expression("jRound.[RoundName]"),QuickSearch]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
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

        [DisplayName(""), MasterDetailRelation(foreignKey: "VitaminADayId"), NotMapped]
        public List<VitaminAVaccinationsRow> VitaminAVaccinations
        {
            get { return Fields.VitaminAVaccinations[this]; }
            set { Fields.VitaminAVaccinations[this] = value; }
        }


        [DisplayName("Date From"), Expression("jRound.[DateFrom]"), ReadOnly(true),QuickSearch]
        public DateTime? DateFrom
        {
            get { return Fields.DateFrom[this]; }
            set { Fields.DateFrom[this] = value; }
        }

        [DisplayName("Date To"), Expression("jRound.[DateTo]"), ReadOnly(true),QuickSearch]
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
            get { return Fields.VitaminADayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PemtremtManager; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VitaminARow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field VitaminADayId;
            public Int16Field RoundId;
            public Int16Field ProvinceId;
            public Int16Field DistrictId;
            public StringField PemtremtManager;

            public StringField RoundName;

            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public Int32Field TenantId;

            public StringField ProvincePcode;
            public Int16Field ProvinceRegionId;
            public StringField ProvincePname;
            public StringField ProvincePAbrv;
            public StringField ProvincePcenter;
            public Int16Field ProvinceAreaKmSqr;
            public Int32Field ProvinceNoOfDistricts;

            public StringField DistrictDcode;
            public Int16Field DistrictProvinceId;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;

            public RowListField<VitaminAVaccinationsRow> VitaminAVaccinations;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.VitaminA";
            }
        }
    }
}
