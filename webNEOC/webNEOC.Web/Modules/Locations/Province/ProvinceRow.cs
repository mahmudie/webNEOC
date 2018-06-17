
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

    [ConnectionKey("Default"), TableName("[dbo].[Province]"), DisplayName("Province"), InstanceName("Province"), TwoLevelCached]
    [ReadPermission(PermissionKeys.Province.View)]
    [ModifyPermission(PermissionKeys.Province.Update)]
    [InsertPermission(PermissionKeys.Province.Insert)]
    [DeletePermission(PermissionKeys.Province.Delete)]

    [LookupScript("Locations.Province")]
    public sealed class ProvinceRow : Row, IIdRow, INameRow
    {
        [DisplayName("Province Id"), Identity]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [DisplayName("Code"), Size(2), NotNull, QuickSearch]
        public String Pcode
        {
            get { return Fields.Pcode[this]; }
            set { Fields.Pcode[this] = value; }
        }


        [DisplayName("Region"), Column("RegionID"), NotNull, ForeignKey("[dbo].[Region]", "RegionID"), LeftJoin("jRegion"), TextualField("Rname"),LookupInclude]
        [LookupEditor(typeof(Locations.Entities.RegionRow), InplaceAdd = true)]
        public Int16? RegionId
        {
            get { return Fields.RegionId[this]; }
            set { Fields.RegionId[this] = value; }
        }

        [DisplayName("Province"), Size(30), NotNull,LookupInclude,QuickSearch]
        public String Pname
        {
            get { return Fields.Pname[this]; }
            set { Fields.Pname[this] = value; }
        }

        [DisplayName("P Abrv"), Size(5), NotNull]
        public String PAbrv
        {
            get { return Fields.PAbrv[this]; }
            set { Fields.PAbrv[this] = value; }
        }

        [DisplayName("Center"), Size(30), NotNull]
        public String Pcenter
        {
            get { return Fields.Pcenter[this]; }
            set { Fields.Pcenter[this] = value; }
        }

        [DisplayName("Area Km Sqr"), NotNull]
        public Int32? AreaKmSqr
        {
            get { return Fields.AreaKmSqr[this]; }
            set { Fields.AreaKmSqr[this] = value; }
        }

        [DisplayName("No Of districts")]
        public Int32? NoOfDistricts
        {
            get { return Fields.NoOfDistricts[this]; }
            set { Fields.NoOfDistricts[this] = value; }
        }

        [DisplayName("Region"), Expression("jRegion.[Rname]"),LookupInclude]
        public String Rname
        {
            get { return Fields.Rname[this]; }
            set { Fields.Rname[this] = value; }
        }

        [DisplayName("Region R Abrv"), Expression("jRegion.[RAbrv]")]
        public String RegionRAbrv
        {
            get { return Fields.RegionRAbrv[this]; }
            set { Fields.RegionRAbrv[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProvinceId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Pname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProvinceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field ProvinceId;
            public StringField Pcode;
            public Int16Field RegionId;
            public StringField Pname;
            public StringField PAbrv;
            public StringField Pcenter;
            public Int32Field AreaKmSqr;
            public Int32Field NoOfDistricts;

            public StringField Rname;
            public StringField RegionRAbrv;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Locations.Province";
            }
        }
    }
}
