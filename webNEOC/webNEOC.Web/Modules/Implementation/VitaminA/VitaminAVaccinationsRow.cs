
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

    [ConnectionKey("Default"), TableName("[dbo].[VitaminAVaccinations]"), DisplayName("Vitamin A Distribution"), InstanceName("Vitamin A Distribution"), TwoLevelCached]
    [ReadPermission(ImplementationPermissionKeys.VitaminAVaccinations.View)]
    [ModifyPermission(ImplementationPermissionKeys.VitaminAVaccinations.Update)]
    [InsertPermission(ImplementationPermissionKeys.VitaminAVaccinations.Insert)]
    [DeletePermission(ImplementationPermissionKeys.VitaminAVaccinations.Delete)]
    public sealed class VitaminAVaccinationsRow : Row, IIdRow,IMultiTenantRow
    {
        [DisplayName("ID"), Identity]
        public Int32? VitaminAVaccinationsId
        {
            get { return Fields.VitaminAVaccinationsId[this]; }
            set { Fields.VitaminAVaccinationsId[this] = value; }
        }

        [DisplayName("Vitamin A Day"), PrimaryKey, ForeignKey("[dbo].[VitaminA]", "VitaminADayId"), LeftJoin("jVitaminADay"), TextualField("VitaminADayPemtremtManager")]
        //[LookupEditor(typeof(Implementation.Entities.VitaminARow), InplaceAdd = true)]
        public Int64? VitaminADayId
        {
            get { return Fields.VitaminADayId[this]; }
            set { Fields.VitaminADayId[this] = value; }
        }

        [DisplayName("Cluster"), NotNull, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("ccluster"), TextualField("ClusterName")]
        [LookupEditor(typeof(Locations.Entities.ClusterRow))]
        public Int32? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }

        [DisplayName("Cluster Name"),Expression("ccluster.[Cname]")]
        public String ClusterName
        {
            get { return Fields.ClusterName[this]; }
            set { Fields.ClusterName[this] = value; }
        }

        [DisplayName("Target under 5 cases"), NotNull]
        public Int32? TargetU5Cases
        {
            get { return Fields.TargetU5Cases[this]; }
            set { Fields.TargetU5Cases[this] = value; }
        }

        [DisplayName("D1-Vitamian A received"), NotNull]
        public Int16? d1VitADist
        {
            get { return Fields.d1VitADist[this]; }
            set { Fields.d1VitADist[this] = value; }
        }

        [DisplayName("D1-Vitamin A used"), NotNull]
        public Int16? d1VitAUse
        {
            get { return Fields.d1VitAUse[this]; }
            set { Fields.d1VitAUse[this] = value; }
        }

        [DisplayName("D1-Children 6-11 months"), NotNull]
        public Int16? d1C611Months
        {
            get { return Fields.d1C611Months[this]; }
            set { Fields.d1C611Months[this] = value; }
        }

        [DisplayName("D1-Children 12-59 months"), NotNull]
        public Int16? d1C1259Months
        {
            get { return Fields.d1C1259Months[this]; }
            set { Fields.d1C1259Months[this] = value; }
        }

        [DisplayName("D2-Vitamian A received"), NotNull]
        public Int16? d2VitADist
        {
            get { return Fields.d2VitADist[this]; }
            set { Fields.d2VitADist[this] = value; }
        }

        [DisplayName("D2-Vitamin A used"), NotNull]
        public Int16? d2VitAUse
        {
            get { return Fields.d2VitAUse[this]; }
            set { Fields.d2VitAUse[this] = value; }
        }

        [DisplayName("D2-Children 6-11 months"), NotNull]
        public Int16? d2C611Months
        {
            get { return Fields.d2C611Months[this]; }
            set { Fields.d2C611Months[this] = value; }
        }

        [DisplayName("D2-Children 12-59 months"), NotNull]
        public Int16? d2C1259Months
        {
            get { return Fields.d2C1259Months[this]; }
            set { Fields.d2C1259Months[this] = value; }
        }

        [DisplayName("D3-Vitamian A received"), NotNull]
        public Int16? d3VitADist
        {
            get { return Fields.d3VitADist[this]; }
            set { Fields.d3VitADist[this] = value; }
        }

        [DisplayName("D3-Vitamin A used"), NotNull]
        public Int16? d3VitAUse
        {
            get { return Fields.d3VitAUse[this]; }
            set { Fields.d3VitAUse[this] = value; }
        }

        [DisplayName("D3-Children 6-11 months"), NotNull]
        public Int16? d3C611Months
        {
            get { return Fields.d3C611Months[this]; }
            set { Fields.d3C611Months[this] = value; }
        }

        [DisplayName("D3-Children 12-59 months"), NotNull]
        public Int16? d3C1259Months
        {
            get { return Fields.d3C1259Months[this]; }
            set { Fields.d3C1259Months[this] = value; }
        }

        [DisplayName("D5-Vitamian A received"), NotNull]
        public Int16? d5VitADist
        {
            get { return Fields.d5VitADist[this]; }
            set { Fields.d5VitADist[this] = value; }
        }

        [DisplayName("D5-Vitamin A used"), NotNull]
        public Int16? d5VitAUse
        {
            get { return Fields.d5VitAUse[this]; }
            set { Fields.d5VitAUse[this] = value; }
        }

        [DisplayName("D5-Children 6-11 months"), NotNull]
        public Int16? d5C611Months
        {
            get { return Fields.d5C611Months[this]; }
            set { Fields.d5C611Months[this] = value; }
        }

        [DisplayName("D5-Children 12-59 months"), NotNull]
        public Int16? d5C1259Months
        {
            get { return Fields.d5C1259Months[this]; }
            set { Fields.d5C1259Months[this] = value; }
        }


        [DisplayName("Vitamin A Day Campaign Id"), Expression("jVitaminADay.[CampaignId]")]
        public Int32? VitaminADayCampaignId
        {
            get { return Fields.VitaminADayCampaignId[this]; }
            set { Fields.VitaminADayCampaignId[this] = value; }
        }

        [DisplayName("Vitamin A Day Province Id"), Expression("jVitaminADay.[ProvinceId]")]
        public Int16? VitaminADayProvinceId
        {
            get { return Fields.VitaminADayProvinceId[this]; }
            set { Fields.VitaminADayProvinceId[this] = value; }
        }

        [DisplayName("Vitamin A Day District Id"), Expression("jVitaminADay.[DistrictId]")]
        public Int16? VitaminADayDistrictId
        {
            get { return Fields.VitaminADayDistrictId[this]; }
            set { Fields.VitaminADayDistrictId[this] = value; }
        }

        [DisplayName("Vitamin A Day Day Number"), Expression("jVitaminADay.[DayNumber]")]
        public Int16? VitaminADayDayNumber
        {
            get { return Fields.VitaminADayDayNumber[this]; }
            set { Fields.VitaminADayDayNumber[this] = value; }
        }

        [DisplayName("Vitamin A Day Date Of Campaign"), Expression("jVitaminADay.[DateOfCampaign]")]
        public DateTime? VitaminADayDateOfCampaign
        {
            get { return Fields.VitaminADayDateOfCampaign[this]; }
            set { Fields.VitaminADayDateOfCampaign[this] = value; }
        }

        [DisplayName("Vitamin A Day Pemtremt Manager"), Expression("jVitaminADay.[PEMTREMTManager]")]
        public String VitaminADayPemtremtManager
        {
            get { return Fields.VitaminADayPemtremtManager[this]; }
            set { Fields.VitaminADayPemtremtManager[this] = value; }
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
            get { return Fields.VitaminAVaccinationsId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VitaminAVaccinationsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field VitaminAVaccinationsId;
            public Int64Field VitaminADayId;
            public Int32Field ClusterId;
            public Int32Field TargetU5Cases;
            public Int16Field d1VitADist;
            public Int16Field d1VitAUse;
            public Int16Field d1C611Months;
            public Int16Field d1C1259Months;
            public Int16Field d2VitADist;
            public Int16Field d2VitAUse;
            public Int16Field d2C611Months;
            public Int16Field d2C1259Months;
            public Int16Field d3VitADist;
            public Int16Field d3VitAUse;
            public Int16Field d3C611Months;
            public Int16Field d3C1259Months;
            public Int16Field d5VitADist;
            public Int16Field d5VitAUse;
            public Int16Field d5C611Months;
            public Int16Field d5C1259Months;

            public Int32Field VitaminADayCampaignId;
            public Int16Field VitaminADayProvinceId;
            public Int16Field VitaminADayDistrictId;
            public Int16Field VitaminADayDayNumber;
            public DateTimeField VitaminADayDateOfCampaign;
            public StringField VitaminADayPemtremtManager;
            public StringField ClusterName;

            public Int32Field TenantId;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.VitaminAVaccinations";
            }
        }
    }
}
