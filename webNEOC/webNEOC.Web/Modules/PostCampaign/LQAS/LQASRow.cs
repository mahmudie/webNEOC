
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
    using System.ComponentModel.DataAnnotations;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[LQAS]"), DisplayName("LQAS"), InstanceName("LQAS"), TwoLevelCached]
    [ReadPermission(PostCampaignPermissionKeys.LQASS.View)]
    [ModifyPermission(PostCampaignPermissionKeys.LQASS.Update)]
    [InsertPermission(PostCampaignPermissionKeys.LQASS.Insert)]
    [DeletePermission(PostCampaignPermissionKeys.LQASS.Delete)]
    public sealed class LQASRow : Row, IIdRow, INameRow,IMultiTenantRow
    {
        [DisplayName("ID"), Column("LQASId"), Identity]
        public Int16? LqasId
        {
            get { return Fields.LqasId[this]; }
            set { Fields.LqasId[this] = value; }
        }

        [Serenity.ComponentModel.Required]
        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName"),DefaultValue("NA")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow))]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [Serenity.ComponentModel.Required]
        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDname"),LookupInclude]
        [LookupEditor(typeof(Locations.Entities.DistrictRow))]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Round"), Expression("jRound.[RoundName]"),QuickSearch]
        public string RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }


        [DisplayName("Lot No"), NotNull]
        public Int16? LotNo
        {
            get { return Fields.LotNo[this]; }
            set { Fields.LotNo[this] = value; }
        }

        [DisplayName("No. of with no finger childern"), NotNull]
        public Int16? NoVaccChildren
        {
            get { return Fields.NoVaccChildren[this]; }
            set { Fields.NoVaccChildren[this] = value; }
        }


        [TextAreaEditor(Rows =4)]
        [DisplayName("Comments list clusters omitted"), Size(255), QuickSearch]
        public String Comments
        {
            get { return Fields.Comments[this]; }
            set { Fields.Comments[this] = value; }
        }


        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [DisplayName("Province"), Expression("jDistrict.[ProvinceId]"),ForeignKey("Province","ProvinceId"),LeftJoin("p")]
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
            get { return Fields.LqasId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Comments; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LQASRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field LqasId;
            public Int16Field DistrictId;
            public Int16Field LotNo;
            public Int16Field NoVaccChildren;
            public Int16Field RoundId;
            public StringField Comments;

            public StringField RoundName;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public Int32Field TenantId;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField DistrictDname;
            public StringField Province;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;
            //public StringField Pname;
            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "PostCampaign.LQAS";
            }
        }
    }
}
