
namespace webNEOC.Implementation.Entities
{
    using Serenity;
    using Modules.Implementation;
    using MultiTenancy;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[ICMHousehold]"), DisplayName("ICM Household"), InstanceName("ICM Household"), TwoLevelCached]
    [ReadPermission(ImplementationPermissionKeys.IcmHousehold.View)]
    [ModifyPermission(ImplementationPermissionKeys.IcmHousehold.Update)]
    [InsertPermission(ImplementationPermissionKeys.IcmHousehold.Insert)]
    [DeletePermission(ImplementationPermissionKeys.IcmHousehold.Delete)]
    public sealed class IcmHouseholdRow : Row, IIdRow, INameRow,IMultiTenantRow
    {
        [DisplayName("Icm Household Id"), Column("ICMHouseholdId"), Identity]
        public Int32? IcmHouseholdId
        {
            get { return Fields.IcmHouseholdId[this]; }
            set { Fields.IcmHouseholdId[this] = value; }
        }

        [DisplayName("Round"), PrimaryKey, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound"), TextualField("RoundName")]
        [LookupEditor(typeof(Lookup.Entities.RoundRow)), Required]
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

        [DisplayName("Part"), PrimaryKey, ForeignKey("[dbo].[Part]", "PartId"), LeftJoin("jPart"), TextualField("PartPartName")]
        [LookupEditor(typeof(Lookup.Entities.PartRow), InplaceAdd = true),Required]
        public Int16? PartId
        {
            get { return Fields.PartId[this]; }
            set { Fields.PartId[this] = value; }
        }

        [DisplayName("Cluster"), PrimaryKey, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster")]
        [LookupEditor(typeof(Locations.Entities.ClusterRow)),Required]
        public Int32? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }

        [DisplayName("Report Date"), NotNull]
        public DateTime? ReportDate
        {
            get { return Fields.ReportDate[this]; }
            set { Fields.ReportDate[this] = value; }
        }


        [DisplayName("Village"), Size(255), NotNull, QuickSearch]
        public String Village
        {
            get { return Fields.Village[this]; }
            set { Fields.Village[this] = value; }
        }

        [DisplayName("Supervisor Name"), Size(255), NotNull,QuickSearch]
        public String Supervisor
        {
            get { return Fields.Supervisor[this]; }
            set { Fields.Supervisor[this] = value; }
        }

        [DisplayName("# of household visited"), Column("NoHHVisited"), NotNull]
        public Int16? NoHhVisited
        {
            get { return Fields.NoHhVisited[this]; }
            set { Fields.NoHhVisited[this] = value; }
        }

        [DisplayName("# of children living in the household"), Column("NoChildrenInVisitedHH"), NotNull]
        public Int16? NoChildrenInVisitedHh
        {
            get { return Fields.NoChildrenInVisitedHh[this]; }
            set { Fields.NoChildrenInVisitedHh[this] = value; }
        }

        [DisplayName("# children vaccinated based on recall "), NotNull]
        public Int16? NoVaccInRecall
        {
            get { return Fields.NoVaccInRecall[this]; }
            set { Fields.NoVaccInRecall[this] = value; }
        }

        [DisplayName("Missed children"), NotNull]
        public Int16? MissedChildren
        {
            get { return Fields.MissedChildren[this]; }
            set { Fields.MissedChildren[this] = value; }
        }

        [DisplayName(" Team not come"), NotNull]
        public Int16? TeamNotCome
        {
            get { return Fields.TeamNotCome[this]; }
            set { Fields.TeamNotCome[this] = value; }
        }

        [DisplayName("Children Absent"), NotNull]
        public Int16? ChildrenAbsent
        {
            get { return Fields.ChildrenAbsent[this]; }
            set { Fields.ChildrenAbsent[this] = value; }
        }

        [DisplayName("# newborn, sleep, sick Children"), Column("NewbornSSChildren"), NotNull]
        public Int16? NewbornSsChildren
        {
            get { return Fields.NewbornSsChildren[this]; }
            set { Fields.NewbornSsChildren[this] = value; }
        }

        [DisplayName("#  refused"), NotNull]
        public Int16? NoRefused
        {
            get { return Fields.NoRefused[this]; }
            set { Fields.NoRefused[this] = value; }
        }

        [DisplayName("# Ignored by team "), NotNull]
        public Int16? NoIgnoredbyTeam
        {
            get { return Fields.NoIgnoredbyTeam[this]; }
            set { Fields.NoIgnoredbyTeam[this] = value; }
        }


        [DisplayName("Total children <5 years seen by the monitor"), NotNull]
        public Int16? TotUn5SeenByMonit
        {
            get { return Fields.TotUn5SeenByMonit[this]; }
            set { Fields.TotUn5SeenByMonit[this] = value; }
        }

        [DisplayName("Children seen with finger marking"), NotNull]
        public Int16? NoSeenWithFingerMark
        {
            get { return Fields.NoSeenWithFingerMark[this]; }
            set { Fields.NoSeenWithFingerMark[this] = value; }
        }

        [DisplayName("# Correct"), NotNull]
        public Int16? NoCorrect
        {
            get { return Fields.NoCorrect[this]; }
            set { Fields.NoCorrect[this] = value; }
        }

        [DisplayName("# Not correct"), NotNull]
        public Int16? NoIncorrect
        {
            get { return Fields.NoIncorrect[this]; }
            set { Fields.NoIncorrect[this] = value; }
        }

        [DisplayName("# Not Marked"), NotNull]
        public Int16? NoNotMarked
        {
            get { return Fields.NoNotMarked[this]; }
            set { Fields.NoNotMarked[this] = value; }
        }

        [DisplayName("# of children found missed based on recall"), NotNull]
        public Int16? NoChildFoundMissedRecall
        {
            get { return Fields.NoChildFoundMissedRecall[this]; }
            set { Fields.NoChildFoundMissedRecall[this] = value; }
        }

        [DisplayName("# of missed children recorded on back of tally sheet"), NotNull]
        public Int16? NoChildRecBackOfTally
        {
            get { return Fields.NoChildRecBackOfTally[this]; }
            set { Fields.NoChildRecBackOfTally[this] = value; }
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

        [DisplayName("Part Part Name"), Expression("jPart.[PartName]"),QuickSearch]
        public String PartPartName
        {
            get { return Fields.PartPartName[this]; }
            set { Fields.PartPartName[this] = value; }
        }

        [DisplayName("Round"), Expression("jRound.[RoundName]"),QuickSearch]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }

        [DisplayName("Cluster"), Expression("jCluster.[Cname]"),QuickSearch]
        public String Cname
        {
            get { return Fields.Cname[this]; }
            set { Fields.Cname[this] = value; }
        }

        [DisplayName("Date From"), Expression("jRound.[DateFrom]"), ReadOnly(true)]
        public DateTime? DateFrom
        {
            get { return Fields.DateFrom[this]; }
            set { Fields.DateFrom[this] = value; }
        }

        [DisplayName("Date To"), Expression("jRound.[DateTo]"), ReadOnly(true)]
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
            get { return Fields.IcmHouseholdId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Village; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public IcmHouseholdRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IcmHouseholdId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public Int16Field PartId;
            public Int32Field ClusterId;
            public DateTimeField ReportDate;
            public StringField Village;
            public StringField Supervisor;
            public Int16Field NoHhVisited;
            public Int16Field NoChildrenInVisitedHh;
            public Int16Field NoVaccInRecall;
            public Int16Field MissedChildren;
            public Int16Field TeamNotCome;
            public Int16Field ChildrenAbsent;
            public Int16Field NewbornSsChildren;
            public Int16Field NoRefused;
            public Int16Field NoIgnoredbyTeam;
            public Int16Field TotUn5SeenByMonit;
            public Int16Field NoSeenWithFingerMark;
            public Int16Field NoCorrect;
            public Int16Field NoIncorrect;
            public Int16Field NoNotMarked;
            public Int16Field NoChildFoundMissedRecall;
            public Int16Field NoChildRecBackOfTally;

            public StringField RoundName;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public Int32Field TenantId;
            public StringField Cname;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField Province;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;

            public StringField PartPartName;

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.IcmHousehold";
            }
        }
    }
}
