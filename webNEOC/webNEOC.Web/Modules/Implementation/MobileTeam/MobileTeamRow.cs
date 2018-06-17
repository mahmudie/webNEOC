
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

    [ConnectionKey("Default"), TableName("[dbo].[MobileTeam]"), DisplayName("Mobile Team"), InstanceName("Mobile Team"), TwoLevelCached]
    [ReadPermission(ImplementationPermissionKeys.MobileTeam.View)]
    [ModifyPermission(ImplementationPermissionKeys.MobileTeam.Update)]
    [InsertPermission(ImplementationPermissionKeys.MobileTeam.Insert)]
    [DeletePermission(ImplementationPermissionKeys.MobileTeam.Delete)]

    public sealed class MobileTeamRow : Row, IIdRow,IMultiTenantRow
    {
        [DisplayName("ID"), Identity]
        public Int32? MobileTeamId
        {
            get { return Fields.MobileTeamId[this]; }
            set { Fields.MobileTeamId[this] = value; }
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

        [DisplayName("District"), PrimaryKey, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDcode")]
        [LookupEditor(typeof(Locations.Entities.DistrictRow)), Required]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Nomads"), NotNull]
        public Int16? Nomads
        {
            get { return Fields.Nomads[this]; }
            set { Fields.Nomads[this] = value; }
        }

        [DisplayName("Gypsis"), NotNull]
        public Int16? Gypsis
        {
            get { return Fields.Gypsis[this]; }
            set { Fields.Gypsis[this] = value; }
        }

        [DisplayName("Shrines/blue mosque"), NotNull]
        public Int16? BlueMosque
        {
            get { return Fields.BlueMosque[this]; }
            set { Fields.BlueMosque[this] = value; }
        }

        [DisplayName("Bus Station"), NotNull]
        public Int16? BusStation
        {
            get { return Fields.BusStation[this]; }
            set { Fields.BusStation[this] = value; }
        }

        [DisplayName("Check Post"), NotNull]
        public Int16? CheckPost
        {
            get { return Fields.CheckPost[this]; }
            set { Fields.CheckPost[this] = value; }
        }

        [DisplayName("IDPs"), NotNull]
        public Int16? IDPs
        {
            get { return Fields.IDPs[this]; }
            set { Fields.IDPs[this] = value; }
        }

        [DisplayName("Madrasa"), NotNull]
        public Int16? Madrasa
        {
            get { return Fields.Madrasa[this]; }
            set { Fields.Madrasa[this] = value; }
        }

        [DisplayName("School"), NotNull]
        public Int16? School
        {
            get { return Fields.School[this]; }
            set { Fields.School[this] = value; }
        }

        [DisplayName("Kindergarden"), NotNull]
        public Int16? Kindergarden
        {
            get { return Fields.Kindergarden[this]; }
            set { Fields.Kindergarden[this] = value; }
        }

        [DisplayName("Prison (Jell)"), NotNull]
        public Int16? Prison
        {
            get { return Fields.Prison[this]; }
            set { Fields.Prison[this] = value; }
        }

        [DisplayName("Daramsal"), NotNull]
        public Int16? Daramsal
        {
            get { return Fields.Daramsal[this]; }
            set { Fields.Daramsal[this] = value; }
        }

        [DisplayName("Crosborder"), NotNull]
        public Int16? Crosborder
        {
            get { return Fields.Crosborder[this]; }
            set { Fields.Crosborder[this] = value; }
        }

        [DisplayName("Returnees"), NotNull]
        public Int16? Returnees
        {
            get { return Fields.Returnees[this]; }
            set { Fields.Returnees[this] = value; }
        }


        [DisplayName("Date From"), Expression("jRound.[DateFrom]"),ReadOnly(true)]
        public DateTime? DateFrom
        {
            get { return Fields.DateFrom[this]; }
            set { Fields.DateFrom[this] = value; }
        }

        [DisplayName("Date To"), Expression("jRound.[DateTo]"),ReadOnly(true)]
        public DateTime? DateTo
        {
            get { return Fields.DateTo[this]; }
            set { Fields.DateTo[this] = value; }
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

        [Expression("p.[Pname]")]
        public string Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }

        [DisplayName("District Dname"), Expression("jDistrict.[Dname]")]
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

        [DisplayName("EPI Centers"), NotNull]
        public Int16? EPICenters
        {
            get { return Fields.EPICenters[this]; }
            set { Fields.EPICenters[this] = value; }
        }

        [DisplayName("Mobile Teams"), NotNull]
        public Int16? MobileTeams
        {
            get { return Fields.MobileTeams[this]; }
            set { Fields.MobileTeams[this] = value; }
        }
        [DisplayName("Private Clinics"), NotNull]
        public Int16? PrivateClinics
        {
            get { return Fields.PrivateClinics[this]; }
            set { Fields.PrivateClinics[this] = value; }
        }

        [DisplayName("Hotel/Guest Houses"), NotNull]
        public Int16? HotelGuestHouses
        {
            get { return Fields.HotelGuestHouses[this]; }
            set { Fields.HotelGuestHouses[this] = value; }
        }

        [DisplayName("Others"), NotNull]
        public Int16? Others
        {
            get { return Fields.Others[this]; }
            set { Fields.Others[this] = value; }
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
            get { return Fields.MobileTeamId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MobileTeamRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MobileTeamId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public Int16Field Nomads;
            public Int16Field Gypsis;
            public Int16Field BlueMosque;
            public Int16Field BusStation;
            public Int16Field CheckPost;
            public Int16Field IDPs;
            public Int16Field Madrasa;
            public Int16Field School;
            public Int16Field Kindergarden;
            public Int16Field Prison;
            public Int16Field Daramsal;
            public Int16Field Crosborder;
            public Int16Field Returnees;

            public Int16Field EPICenters;
            public Int16Field MobileTeams;
            public Int16Field PrivateClinics;
            public Int16Field HotelGuestHouses;
            public Int16Field Others;

            public StringField RoundName;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public Int32Field TenantId;
            //public StringField Pname;

            public StringField DistrictDcode;
            public Int16Field ProvinceId;
            public StringField Province;
            public StringField DistrictDname;
            public Int32Field DistrictTotalPop;
            public Int32Field DistrictTargetPop;
            public StringField DistrictType;
            public Int16Field DistrictPriority;
            public Int32Field DistrictPopYear;
            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.MobileTeam";
            }
        }
    }
}
