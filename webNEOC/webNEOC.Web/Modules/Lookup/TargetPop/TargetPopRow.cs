
namespace webNEOC.Lookup.Entities
{
    using Modules.Lookup;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dadb].[TargetPop]"), DisplayName("Target Populatoin"), InstanceName("Target Populatoin"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.ClusterLevel.View)]
    [ModifyPermission(LookupPermissionKeys.ClusterLevel.Update)]
    [DeletePermission(LookupPermissionKeys.ClusterLevel.Delete)]
    [InsertPermission(LookupPermissionKeys.ClusterLevel.Insert)]
    public sealed class TargetPopRow : Row, IIdRow, INameRow
    {
        [DisplayName("Target Id"), Identity]
        public Int32? TargetId
        {
            get { return Fields.TargetId[this]; }
            set { Fields.TargetId[this] = value; }
        }

        [DisplayName("District"), NotNull, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode"),QuickSearch]
        [LookupEditor(typeof(Locations.Entities.DistrictRow), InplaceAdd = false), Required]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Year"), NotNull]
        public Int32? YearId
        {
            get { return Fields.YearId[this]; }
            set { Fields.YearId[this] = value; }
        }

        [DisplayName("Population"), NotNull]
        public Int64? Population
        {
            get { return Fields.Population[this]; }
            set { Fields.Population[this] = value; }
        }

        [DisplayName("Target"), NotNull]
        public Int64? Target
        {
            get { return Fields.Target[this]; }
            set { Fields.Target[this] = value; }
        }

        [DisplayName("LPDs"), Column("LPDs"), Size(30), NotNull, QuickSearch]
        public String LpDs
        {
            get { return Fields.LpDs[this]; }
            set { Fields.LpDs[this] = value; }
        }

        [DisplayName("Comment"), Size(-1)]
        public String Comment
        {
            get { return Fields.Comment[this]; }
            set { Fields.Comment[this] = value; }
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
        [Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("r"), LookupInclude, QuickSearch]
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

        IIdField IIdRow.IdField
        {
            get { return Fields.TargetId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LpDs; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TargetPopRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TargetId;
            public Int16Field DistrictId;
            public Int32Field YearId;
            public Int64Field Population;
            public Int64Field Target;
            public StringField LpDs;
            public StringField Comment;

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

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.TargetPop";
            }
        }
    }
}
