
namespace webNEOC.Locations.Entities
{
    using Serenity;
    using Modules.LocationPermission;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[District]"), DisplayName("District"), InstanceName("District"), TwoLevelCached]
    [ReadPermission(PermissionKeys.District.View)]
    [ModifyPermission(PermissionKeys.District.Update)]
    [InsertPermission(PermissionKeys.District.Insert)]
    [DeletePermission(PermissionKeys.District.Delete)]

    [LookupScript("Locations.District")]
    public sealed class DistrictRow : Row, IIdRow, INameRow
    {
        [DisplayName("District Id"), Identity]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }
       
        [DisplayName("Code"), Size(10), NotNull, QuickSearch]
        public String Dcode
        {
            get { return Fields.Dcode[this]; }
            set { Fields.Dcode[this] = value; }
        }

        [DisplayName("Province"), Column("ProvinceId"), NotNull, ForeignKey("[dbo].[Province]", "ProvinceId"), LeftJoin("jProvince"), TextualField("Pname"),LookupInclude]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow), InplaceAdd = true)]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [DisplayName("District"), Size(50), NotNull,LookupInclude,QuickSearch]
        public String Dname
        {
            get { return Fields.Dname[this]; }
            set { Fields.Dname[this] = value; }
        }

        [DisplayName("Total Population"), NotNull]
        public Int32? TotalPop
        {
            get { return Fields.TotalPop[this]; }
            set { Fields.TotalPop[this] = value; }
        }

        [DisplayName("Target Population"), NotNull]
        public Int32? TargetPop
        {
            get { return Fields.TargetPop[this]; }
            set { Fields.TargetPop[this] = value; }
        }

        [DisplayName("Type"), Size(30), NotNull,QuickSearch]
        public String Type
        {
            get { return Fields.Type[this]; }
            set { Fields.Type[this] = value; }
        }

        [DisplayName("Priority"),QuickSearch]
        public Int16? Priority
        {
            get { return Fields.Priority[this]; }
            set { Fields.Priority[this] = value; }
        }

        [DisplayName("Population Year"), NotNull,QuickSearch]
        public Int32? PopYear
        {
            get { return Fields.PopYear[this]; }
            set { Fields.PopYear[this] = value; }
        }


        [DisplayName("Province"), Expression("jProvince.[Pname]"), LookupInclude,QuickSearch]
        public String Pname
        {
            get { return Fields.Pname[this]; }
            set { Fields.Pname[this] = value; }
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
        public Int32? ProvinceAreaKmSqr
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

        IIdField IIdRow.IdField
        {
            get { return Fields.DistrictId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Dname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DistrictRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field DistrictId;
            public StringField Dcode;
            public Int16Field ProvinceId;
            public StringField Dname;
            public Int32Field TotalPop;
            public Int32Field TargetPop;
            public StringField Type;
            public Int16Field Priority;
            public Int32Field PopYear;

            public StringField ProvincePcode;
            public Int16Field ProvinceRegionId;
            public StringField Pname;
            public StringField ProvincePAbrv;
            public StringField ProvincePcenter;
            public Int32Field ProvinceAreaKmSqr;
            public Int32Field ProvinceNoOfDistricts;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Locations.District";
            }
        }
    }
}
