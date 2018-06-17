
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

    [ConnectionKey("Default"), TableName("[dbo].[Cluster]"), DisplayName("Cluster"), InstanceName("Cluster"), TwoLevelCached]
    [ReadPermission(PermissionKeys.Cluster.View)]
    [ModifyPermission(PermissionKeys.Cluster.Update)]
    [InsertPermission(PermissionKeys.Cluster.Insert)]
    [DeletePermission(PermissionKeys.Cluster.Delete)]

    [LookupScript("Locations.Cluster")]
    public sealed class ClusterRow : Row, IIdRow, INameRow
    {
        [DisplayName("ID"), Identity]
        public Int32? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }

        [DisplayName("District"), NotNull, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("Dname"),LookupInclude]
        [LookupEditor(typeof(Locations.Entities.DistrictRow), InplaceAdd = true)]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Code"), Size(30), NotNull, QuickSearch]
        public String Ccode
        {
            get { return Fields.Ccode[this]; }
            set { Fields.Ccode[this] = value; }
        }

        [DisplayName("Cluster"), Size(100), NotNull,QuickSearch]
        public String Cname
        {
            get { return Fields.Cname[this]; }
            set { Fields.Cname[this] = value; }
        }

        [DisplayName("Target Cases"), Size(100), NotNull,Required]
        public Int32? Targetpop
        {
            get { return Fields.Targetpop[this]; }
            set { Fields.Targetpop[this] = value; }
        }


        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("r"),LookupInclude,QuickSearch]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [Expression("r.[Pname]")]
        public string Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }


        [DisplayName("District"), Expression("jDistrict.[Dname]"),LookupInclude,QuickSearch]
        public String Dname
        {
            get { return Fields.Dname[this]; }
            set { Fields.Dname[this] = value; }
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

        [DisplayName("District Priority"), Expression("jDistrict.[Priority]"),QuickSearch]
        public Int16? DistrictPriority
        {
            get { return Fields.DistrictPriority[this]; }
            set { Fields.DistrictPriority[this] = value; }
        }

        [DisplayName("District Pop Year"), Expression("jDistrict.[PopYear]"),QuickSearch]
        public Int32? DistrictPopYear
        {
            get { return Fields.DistrictPopYear[this]; }
            set { Fields.DistrictPopYear[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ClusterId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Cname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ClusterRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ClusterId;
            public Int16Field DistrictId;
            public StringField Ccode;
            public StringField Cname;
            public Int32Field Targetpop;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField Dname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;
            public StringField Province;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Locations.Cluster";
            }
        }
    }
}
