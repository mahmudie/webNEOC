
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

    [ConnectionKey("Default"), TableName("[dbo].[ICMSupervisor]"), DisplayName("ICM Supervisor"), InstanceName("ICM Supervisor"), TwoLevelCached]
    [ReadPermission(ImplementationPermissionKeys.IcmSupervisor.View)]
    [ModifyPermission(ImplementationPermissionKeys.IcmSupervisor.Update)]
    [InsertPermission(ImplementationPermissionKeys.IcmSupervisor.Insert)]
    [DeletePermission(ImplementationPermissionKeys.IcmSupervisor.Delete)]
    public sealed class IcmSupervisorRow : Row, IIdRow, INameRow,IMultiTenantRow
    {
        [DisplayName("Icm Supervisor Id"), Column("ICMSupervisorId"), Identity]
        public Int32? IcmSupervisorId
        {
            get { return Fields.IcmSupervisorId[this]; }
            set { Fields.IcmSupervisorId[this] = value; }
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

        [DisplayName("Cluster"), PrimaryKey, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster"), TextualField("Cname")]
        [LookupEditor(typeof(Locations.Entities.ClusterRow)),Required]
        public Int32? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }
        [DisplayName("Part"), PrimaryKey, ForeignKey("[dbo].[Part]", "PartId"), LeftJoin("jPart"), TextualField("PartPartName")]
        [LookupEditor(typeof(Lookup.Entities.PartRow), InplaceAdd = true), Required]
        public Int16? PartId
        {
            get { return Fields.PartId[this]; }
            set { Fields.PartId[this] = value; }
        }
        [DisplayName("Report Date"), NotNull]
        public DateTime? ReportDate
        {
            get { return Fields.ReportDate[this]; }
            set { Fields.ReportDate[this] = value; }
        }


        [DisplayName("Supervisor name"), Size(255), NotNull, QuickSearch]
        public String Supervisor
        {
            get { return Fields.Supervisor[this]; }
            set { Fields.Supervisor[this] = value; }
        }

        [DisplayName("Monitor name"), Size(255), NotNull]
        public String MonitorName
        {
            get { return Fields.MonitorName[this]; }
            set { Fields.MonitorName[this] = value; }
        }

        [DisplayName("Is supervisor resident of his assigned cluster?"), NotNull]
        public Boolean? IsSuperResidentOfArea
        {
            get { return Fields.IsSuperResidentOfArea[this]; }
            set { Fields.IsSuperResidentOfArea[this] = value; }
        }

        [DisplayName("Has supervisor been trained before this campaign?"), NotNull]
        public Boolean? IsSuperTrained
        {
            get { return Fields.IsSuperTrained[this]; }
            set { Fields.IsSuperTrained[this] = value; }
        }

        [DisplayName("Is supervisor carrying OPV?"), Column("IsSuperCarryOPV"), NotNull]
        public Boolean? IsSuperCarryOpv
        {
            get { return Fields.IsSuperCarryOpv[this]; }
            set { Fields.IsSuperCarryOpv[this] = value; }
        }

        [DisplayName("Is supervisor carrying maps...?"), NotNull]
        public Boolean? IsSuperHasClearMap
        {
            get { return Fields.IsSuperHasClearMap[this]; }
            set { Fields.IsSuperHasClearMap[this] = value; }
        }

        [DisplayName("Is supervisor carrying and filling households check list?"), Column("IsSuperFillingHHChecklist"), NotNull]
        public Boolean? IsSuperFillingHhChecklist
        {
            get { return Fields.IsSuperFillingHhChecklist[this]; }
            set { Fields.IsSuperFillingHhChecklist[this] = value; }
        }

        [DisplayName("Is transport provided for supervision based on microplan?"), NotNull]
        public Boolean? IsTransProviddToSuper
        {
            get { return Fields.IsTransProviddToSuper[this]; }
            set { Fields.IsTransProviddToSuper[this] = value; }
        }

        [DisplayName("Vehicletype"), ForeignKey("[dbo].[Vehicletype]", "VehicletypeId"), LeftJoin("jVehicletype"), TextualField("VehicletypeTypename")]
        [LookupEditor(typeof(Lookup.Entities.VehicletypeRow),InplaceAdd =true),Required]
        public Int16? VehicletypeId
        {
            get { return Fields.VehicletypeId[this]; }
            set { Fields.VehicletypeId[this] = value; }
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
        [DisplayName("Part Name"), Expression("jPart.[PartName]"),QuickSearch]
        public String PartPartName
        {
            get { return Fields.PartPartName[this]; }
            set { Fields.PartPartName[this] = value; }
        }

        [DisplayName("Vehicletype Typename"), Expression("jVehicletype.[Typename]"),QuickSearch]
        public String VehicletypeTypename
        {
            get { return Fields.VehicletypeTypename[this]; }
            set { Fields.VehicletypeTypename[this] = value; }
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
            get { return Fields.IcmSupervisorId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Supervisor; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public IcmSupervisorRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IcmSupervisorId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public Int16Field PartId;
            public Int32Field ClusterId;
            public DateTimeField ReportDate;
            public StringField Supervisor;
            public StringField MonitorName;
            public BooleanField IsSuperResidentOfArea;
            public BooleanField IsSuperTrained;
            public BooleanField IsSuperCarryOpv;
            public BooleanField IsSuperHasClearMap;
            public BooleanField IsSuperFillingHhChecklist;
            public BooleanField IsTransProviddToSuper;
            public Int16Field VehicletypeId;

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

            public StringField VehicletypeTypename;

            public StringField PartPartName;

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.IcmSupervisor";
            }
        }
    }
}
