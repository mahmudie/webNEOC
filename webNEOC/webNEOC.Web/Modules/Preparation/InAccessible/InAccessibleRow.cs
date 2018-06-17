
namespace webNEOC.Preparation.Entities
{
    using Serenity;
    using Modules.Preparation;
    using MultiTenancy;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[InAccessible]"), DisplayName("In Accessible"), InstanceName("In Accessible"), TwoLevelCached]
    [ReadPermission(PrepPermissionKeys.InAccessible.View)]
    [ModifyPermission(PrepPermissionKeys.InAccessible.Update)]
    [InsertPermission(PrepPermissionKeys.InAccessible.Insert)]
    [DeletePermission(PrepPermissionKeys.InAccessible.Delete)]
    public sealed class InAccessibleRow : Row, IIdRow, INameRow,IMultiTenantRow
    {
        [DisplayName("ID"), Identity]
        public Int32? InAccessibleId
        {
            get { return Fields.InAccessibleId[this]; }
            set { Fields.InAccessibleId[this] = value; }
        }

        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow)),Required]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow)),Required]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Date"), NotNull]
        public DateTime? ReportDate
        {
            get { return Fields.ReportDate[this]; }
            set { Fields.ReportDate[this] = value; }
        }

        [DisplayName("Target population"), NotNull]
        public Int32? Target
        {
            get { return Fields.Target[this]; }
            set { Fields.Target[this] = value; }
        }


        [DisplayName("Missed clusters"), NotNull]
        public Int16? MissedClusters
        {
            get { return Fields.MissedClusters[this]; }
            set { Fields.MissedClusters[this] = value; }
        }

        [DisplayName("Missed children"), NotNull]
        public Int32? MissedChildren
        {
            get { return Fields.MissedChildren[this]; }
            set { Fields.MissedChildren[this] = value; }
        }

        [DisplayName("# of partially missed clusters"), NotNull]
        public Int16? PartiallyMissed
        {
            get { return Fields.PartiallyMissed[this]; }
            set { Fields.PartiallyMissed[this] = value; }
        }
        [TextAreaEditor(Rows = 2)]
        [DisplayName("Partially missed cluster names"), Size(255), NotNull, QuickSearch]
        public String PartiallyMissedName
        {
            get { return Fields.PartiallyMissedName[this]; }
            set { Fields.PartiallyMissedName[this] = value; }
        }

        [DisplayName("# of fully missed clusters"), NotNull]
        public Int16? FullyMissed
        {
            get { return Fields.FullyMissed[this]; }
            set { Fields.FullyMissed[this] = value; }
        }
        [TextAreaEditor(Rows = 2)]
        [DisplayName("Fully missed cluster names"), Size(255), NotNull,QuickSearch]
        public String FullyMissedName
        {
            get { return Fields.FullyMissedName[this]; }
            set { Fields.FullyMissedName[this] = value; }
        }

        [TextAreaEditor(Rows = 3)]
        [DisplayName("Plan to reduce"), Size(255), NotNull,QuickSearch]
        public String PlanToReduce
        {
            get { return Fields.PlanToReduce[this]; }
            set { Fields.PlanToReduce[this] = value; }
        }

        [TextAreaEditor(Rows=3)]
        [DisplayName("Remarks"), Size(500),QuickSearch]
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

        [DisplayName("Province Id"), Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("p")]
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
       
        [DisplayName("Category Code"), PrimaryKey, ForeignKey("[dbo].[InAcsCategory]", "InAcsCategoryId"), LeftJoin("jInAcsCategory"), TextualField("Description")]
        [LookupEditor(typeof(Lookup.Entities.InAcsCategoryRow)), Required]
        public Int16? InAcsCategoryId
        {
            get { return Fields.InAcsCategoryId[this]; }
            set { Fields.InAcsCategoryId[this] = value; }
        }

        [DisplayName("Category Description"), Expression("jInAcsCategory.[Description]")]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Round"), Expression("jRound.[RoundName]"),QuickSearch]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
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
            get { return Fields.InAccessibleId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PartiallyMissedName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InAccessibleRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field InAccessibleId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public DateTimeField ReportDate;
            public Int32Field Target;
            public Int16Field MissedClusters;
            public Int32Field MissedChildren;
            public Int16Field PartiallyMissed;
            public StringField PartiallyMissedName;
            public Int16Field FullyMissed;
            public StringField FullyMissedName;
            public Int16Field InAcsCategoryId;
            public StringField PlanToReduce;
            public StringField Remarks;

            public StringField RoundName;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public Int32Field TenantId;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField Province;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;

            public StringField Description;

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Preparation.InAccessible";
            }
        }
    }
}
