
namespace webNEOC.ImportGate.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[TempVitaminA]"), DisplayName("Vitamin A Import"), InstanceName("Vitamin A"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TempVitaminARow : Row, IIdRow, INameRow
    {
        [DisplayName("Temp Vitamin A Id"), Identity]
        public Int64? TempVitaminAId
        {
            get { return Fields.TempVitaminAId[this]; }
            set { Fields.TempVitaminAId[this] = value; }
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

        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow)), Required]
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

        [DisplayName("Province"), PrimaryKey, ForeignKey("[dbo].[Province]", "ProvinceId"), LeftJoin("p")]
        [LookupEditor(typeof(Locations.Entities.ProvinceRow)),Required]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [ Expression("p.[Pname]")]
        public string ProvinceName
        {
            get { return Fields.ProvinceName[this]; }
            set { Fields.ProvinceName[this] = value; }
        }

        [DisplayName("Pemtremt Manager"), Column("PEMTREMTManager"), Size(255), QuickSearch]
        public String PemtremtManager
        {
            get { return Fields.PemtremtManager[this]; }
            set { Fields.PemtremtManager[this] = value; }
        }


        [DisplayName("Target U5 Cases")]
        public Int32? TargetU5Cases
        {
            get { return Fields.TargetU5Cases[this]; }
            set { Fields.TargetU5Cases[this] = value; }
        }

        [DisplayName("D1 Vit A Dist"), Column("d1VitADist")]
        public Int16? D1VitADist
        {
            get { return Fields.D1VitADist[this]; }
            set { Fields.D1VitADist[this] = value; }
        }

        [DisplayName("D1 Vit A Use"), Column("d1VitAUse")]
        public Int16? D1VitAUse
        {
            get { return Fields.D1VitAUse[this]; }
            set { Fields.D1VitAUse[this] = value; }
        }

        [DisplayName("D1 C611 Months"), Column("d1C611Months")]
        public Int16? D1C611Months
        {
            get { return Fields.D1C611Months[this]; }
            set { Fields.D1C611Months[this] = value; }
        }

        [DisplayName("D1 C1259 Months"), Column("d1C1259Months")]
        public Int16? D1C1259Months
        {
            get { return Fields.D1C1259Months[this]; }
            set { Fields.D1C1259Months[this] = value; }
        }

        [DisplayName("D2 Vit A Dist"), Column("d2VitADist")]
        public Int16? D2VitADist
        {
            get { return Fields.D2VitADist[this]; }
            set { Fields.D2VitADist[this] = value; }
        }

        [DisplayName("D2 Vit A Use"), Column("d2VitAUse")]
        public Int16? D2VitAUse
        {
            get { return Fields.D2VitAUse[this]; }
            set { Fields.D2VitAUse[this] = value; }
        }

        [DisplayName("D2 C611 Months"), Column("d2C611Months")]
        public Int16? D2C611Months
        {
            get { return Fields.D2C611Months[this]; }
            set { Fields.D2C611Months[this] = value; }
        }

        [DisplayName("D2 C1259 Months"), Column("d2C1259Months")]
        public Int16? D2C1259Months
        {
            get { return Fields.D2C1259Months[this]; }
            set { Fields.D2C1259Months[this] = value; }
        }

        [DisplayName("D3 Vit A Dist"), Column("d3VitADist")]
        public Int16? D3VitADist
        {
            get { return Fields.D3VitADist[this]; }
            set { Fields.D3VitADist[this] = value; }
        }

        [DisplayName("D3 Vit A Use"), Column("d3VitAUse")]
        public Int16? D3VitAUse
        {
            get { return Fields.D3VitAUse[this]; }
            set { Fields.D3VitAUse[this] = value; }
        }

        [DisplayName("D3 C611 Months"), Column("d3C611Months")]
        public Int16? D3C611Months
        {
            get { return Fields.D3C611Months[this]; }
            set { Fields.D3C611Months[this] = value; }
        }

        [DisplayName("D3 C1259 Months"), Column("d3C1259Months")]
        public Int16? D3C1259Months
        {
            get { return Fields.D3C1259Months[this]; }
            set { Fields.D3C1259Months[this] = value; }
        }

        [DisplayName("D5 Vit A Dist"), Column("d5VitADist")]
        public Int16? D5VitADist
        {
            get { return Fields.D5VitADist[this]; }
            set { Fields.D5VitADist[this] = value; }
        }

        [DisplayName("D5 Vit A Use"), Column("d5VitAUse")]
        public Int16? D5VitAUse
        {
            get { return Fields.D5VitAUse[this]; }
            set { Fields.D5VitAUse[this] = value; }
        }

        [DisplayName("D5 C611 Months"), Column("d5C611Months")]
        public Int16? D5C611Months
        {
            get { return Fields.D5C611Months[this]; }
            set { Fields.D5C611Months[this] = value; }
        }

        [DisplayName("D5 C1259 Months"), Column("d5C1259Months")]
        public Int16? D5C1259Months
        {
            get { return Fields.D5C1259Months[this]; }
            set { Fields.D5C1259Months[this] = value; }
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
            get { return Fields.TempVitaminAId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PemtremtManager; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TempVitaminARow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field TempVitaminAId;
            public Int16Field RoundId;
            public Int16Field ProvinceId;
            public Int16Field DistrictId;
            public StringField PemtremtManager;
            public Int64Field ClusterId;
            public Int32Field TargetU5Cases;
            public Int16Field D1VitADist;
            public Int16Field D1VitAUse;
            public Int16Field D1C611Months;
            public Int16Field D1C1259Months;
            public Int16Field D2VitADist;
            public Int16Field D2VitAUse;
            public Int16Field D2C611Months;
            public Int16Field D2C1259Months;
            public Int16Field D3VitADist;
            public Int16Field D3VitAUse;
            public Int16Field D3C611Months;
            public Int16Field D3C1259Months;
            public Int16Field D5VitADist;
            public Int16Field D5VitAUse;
            public Int16Field D5C611Months;
            public Int16Field D5C1259Months;
            public Int32Field TenantId;

            public StringField RoundName;
            public StringField ProvinceName;
            public StringField DistrictName;
            public StringField ClusterName;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "ImportGate.TempVitaminA";
            }
        }
    }
}
