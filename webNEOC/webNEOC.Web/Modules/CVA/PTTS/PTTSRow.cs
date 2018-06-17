
namespace webNEOC.CVA.Entities
{
    using MultiTenancy;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[PTTS]"), DisplayName("PTTs"), InstanceName("PTTs"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    //[LookupScript("CVA.PTTS", LookupType = typeof(MultiTenantRowLookupScript<>))]
    public sealed class PTTSRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Ptts Id"), Identity]
        public Int64? PttsId
        {
            get { return Fields.PttsId[this]; }
            set { Fields.PttsId[this] = value; }
        }

        [DisplayName("District"), Column("DistrictID"), ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictName"),LookupInclude]
        [LookupEditor(typeof(Locations.Entities.DistrictRow))]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Year"), NotNull]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Month"), ForeignKey("[dbo].[Months]", "MonthId"), LeftJoin("jMonth"), TextualField("Monthlong"), NotNull, QuickSearch]
        [LookupEditor(typeof(Lookup.Entities.MonthsRow))]
        public Int32? MonthId
        {
            get { return Fields.MonthId[this]; }
            set { Fields.MonthId[this] = value; }
        }

        [DisplayName("Type"), Size(255)]
        public String Type
        {
            get { return Fields.Type[this]; }
            set { Fields.Type[this] = value; }
        }

        [DisplayName("Sub type"), Size(255),QuickSearch]
        public String Subtype
        {
            get { return Fields.Subtype[this]; }
            set { Fields.Subtype[this] = value; }
        }

        [DisplayName("Number of Team")]
        public Int16? NoOfTeam
        {
            get { return Fields.NoOfTeam[this]; }
            set { Fields.NoOfTeam[this] = value; }
        }

        [DisplayName("Team Name"), Size(255),QuickSearch]
        public String TeamName
        {
            get { return Fields.TeamName[this]; }
            set { Fields.TeamName[this] = value; }
        }

        [DisplayName("Boys(0-11)")]
        public Int32? Boys011
        {
            get { return Fields.Boys011[this]; }
            set { Fields.Boys011[this] = value; }
        }

        [DisplayName("Girls(0-11)")]
        public Int32? Girls011
        {
            get { return Fields.Girls011[this]; }
            set { Fields.Girls011[this] = value; }
        }

        [DisplayName("Boys(12-59)")]
        public Int32? Boys1259
        {
            get { return Fields.Boys1259[this]; }
            set { Fields.Boys1259[this] = value; }
        }

        [DisplayName("Girls(12-59)")]
        public Int32? Girls1259
        {
            get { return Fields.Girls1259[this]; }
            set { Fields.Girls1259[this] = value; }
        }

        [DisplayName("Remarks"), TextAreaEditor(Rows =4)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("r"), LookupInclude, QuickSearch]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [Expression("r.[Pname]")]
        public string ProvName
        {
            get { return Fields.ProvName[this]; }
            set { Fields.ProvName[this] = value; }
        }

        [DisplayName("District"), Expression("jDistrict.[Dname]"),QuickSearch,LookupInclude]
        public String DistrictDname
        {
            get { return Fields.DistrictDname[this]; }
            set { Fields.DistrictDname[this] = value; }
        }

        [DisplayName("Total Pop"), Expression("jDistrict.[TotalPop]")]
        public Int32? DistrictTotalPop
        {
            get { return Fields.DistrictTotalPop[this]; }
            set { Fields.DistrictTotalPop[this] = value; }
        }

        [DisplayName("Target Pop"), Expression("jDistrict.[TargetPop]")]
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

        [DisplayName("Priority"), Expression("jDistrict.[Priority]")]
        public Int16? DistrictPriority
        {
            get { return Fields.DistrictPriority[this]; }
            set { Fields.DistrictPriority[this] = value; }
        }

        [DisplayName("Pop Year"), Expression("jDistrict.[PopYear]")]
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

        [DisplayName("Month"), Expression("jMonth.[Monthlong]"),QuickSearch]
        public String MonthName
        {
            get { return Fields.MonthName[this]; }
            set { Fields.MonthName[this] = value; }
        }

        [DisplayName("District Lon"), Expression("jDistrict.[LON]")]
        public Double? DistrictLon
        {
            get { return Fields.DistrictLon[this]; }
            set { Fields.DistrictLon[this] = value; }
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
            get { return Fields.PttsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TeamName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PTTSRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field PttsId;
            public Int16Field DistrictId;
            public Int32Field Year;
            public Int32Field MonthId;
            public StringField Type;
            public StringField Subtype;
            public Int16Field NoOfTeam;
            public StringField TeamName;
            public Int32Field Boys011;
            public Int32Field Girls011;
            public Int32Field Boys1259;
            public Int32Field Girls1259;
            public StringField Remarks;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;
            public DoubleField DistrictLat;
            public DoubleField DistrictLon;
            public StringField ProvName;
            public StringField MonthName;

            public Int32Field TenantId;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "CVA.PTTS";
            }
        }
    }
}
