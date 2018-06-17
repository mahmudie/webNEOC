
namespace webNEOC.Campaign.Entities
{
    using Serenity;
    using Modules.Campaign;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;
    using MultiTenancy;

    [ConnectionKey("Default"), TableName("[dbo].[DailyVaccinations]"), DisplayName("Coverage"), InstanceName("Coverage"), TwoLevelCached]
    [ReadPermission(CampaignPermissionKeys.Vaccinations.View)]
    [InsertPermission(CampaignPermissionKeys.Vaccinations.Insert)]
    [UpdatePermission(CampaignPermissionKeys.Vaccinations.Update)]
    [DeletePermission(CampaignPermissionKeys.Vaccinations.Delete)]


    [LookupScript("Campaign.DailyVaccinations")]
    public sealed class DailyVaccinationsRow : Row, IIdRow, IMultiTenantRow
    {
        [DisplayName("ID"), Identity]
        public Int32? DailyVaccinationsId
        {
            get { return Fields.DailyVaccinationsId[this]; }
            set { Fields.DailyVaccinationsId[this] = value; }
        }

        [DisplayName("Campaign"), PrimaryKey, NotNull, ForeignKey("[dbo].[CampaignDay]", "CampaignDayId"), LeftJoin("jCampaignDay")]
        [LookupEditor(typeof(Campaign.Entities.CampaignDayRow), InplaceAdd = false)]
        public Int32? CampaignDayId
        {
            get { return Fields.CampaignDayId[this]; }
            set { Fields.CampaignDayId[this] = value; }
        }

        [DisplayName("Cluster"), PrimaryKey, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster"), TextualField("Cname")]
        [LookupEditor(typeof(Locations.Entities.ClusterRow))]
        public Int64? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }
        [Expression("jCluster.[Cname]"),DisplayName("Cluster Name")]
        public String Cname
        {
            get { return Fields.Cname[this]; }
            set { Fields.Cname[this] = value; }
        }

        [DisplayName("Target U5 Case"), NotNull, AlignRight]
        public Int32? TargetU5Case
        {
            get { return Fields.TargetU5Case[this]; }
            set { Fields.TargetU5Case[this] = value; }
        }

        [DisplayName("D1 # of vials distributed"), Column("d1VialDist"), NotNull, AlignRight]
        public Int16? D1VialDist
        {
            get { return Fields.D1VialDist[this]; }
            set { Fields.D1VialDist[this] = value; }
        }

        [DisplayName("D1 # of vials used"), Column("d1VialUse"), NotNull, AlignRight]
        public Int16? D1VialUse
        {
            get { return Fields.D1VialUse[this]; }
            set { Fields.D1VialUse[this] = value; }
        }

        [DisplayName("D1 # of children 0-11 months vaccinated"), Column("d1Vac011Months"), NotNull, AlignRight]
        public Int16? D1Vac011Months
        {
            get { return Fields.D1Vac011Months[this]; }
            set { Fields.D1Vac011Months[this] = value; }
        }

        [DisplayName("D1 # of children 12-59 months vaccinated"), Column("d1Vac1259months"), NotNull, AlignRight]
        public Int16? D1Vac1259months
        {
            get { return Fields.D1Vac1259months[this]; }
            set { Fields.D1Vac1259months[this] = value; }
        }

        [DisplayName("D1 # of recorded absent children"), Column("d1RecAbsChildren"), NotNull]
        public Int16? D1RecAbsChildren
        {
            get { return Fields.D1RecAbsChildren[this]; }
            set { Fields.D1RecAbsChildren[this] = value; }
        }

        [DisplayName("D1 # of absent children re-vaccinated"), Column("d1VacAbsChildren"), NotNull]
        public Int16? D1VacAbsChildren
        {
            get { return Fields.D1VacAbsChildren[this]; }
            set { Fields.D1VacAbsChildren[this] = value; }
        }

        [DisplayName("D1 # of Newborn,Sleep and Sick children reocroded"), Column("d1RecNewbornSSC"), NotNull]
        public Int16? D1RecNewbornSsc
        {
            get { return Fields.D1RecNewbornSsc[this]; }
            set { Fields.D1RecNewbornSsc[this] = value; }
        }

        [DisplayName("D1 # of Newborn,Sleep and Sick children vaccinated"), Column("d1VacNewbornSSC"), NotNull]
        public Int16? D1VacNewbornSsc
        {
            get { return Fields.D1VacNewbornSsc[this]; }
            set { Fields.D1VacNewbornSsc[this] = value; }
        }

        [DisplayName("D1 # of refusal children recorded"), Column("d1RecRefusedChildren"), NotNull]
        public Int16? D1RecRefusedChildren
        {
            get { return Fields.D1RecRefusedChildren[this]; }
            set { Fields.D1RecRefusedChildren[this] = value; }
        }

        [DisplayName("D1 # of refusal children re-vaccinated"), Column("d1RevacRefusedChildren"), NotNull]
        public Int16? D1RevacRefusedChildren
        {
            get { return Fields.D1RevacRefusedChildren[this]; }
            set { Fields.D1RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D1 AFP Cases"), Column("d1AFPCase"), NotNull]
        public Int16? D1AfpCase
        {
            get { return Fields.D1AfpCase[this]; }
            set { Fields.D1AfpCase[this] = value; }
        }

        [DisplayName("D2 # of vials distributed"), Column("d2VialDist"), NotNull]
        public Int16? D2VialDist
        {
            get { return Fields.D2VialDist[this]; }
            set { Fields.D2VialDist[this] = value; }
        }

        [DisplayName("D2 # of vials used"), Column("d2VialUse"), NotNull]
        public Int16? D2VialUse
        {
            get { return Fields.D2VialUse[this]; }
            set { Fields.D2VialUse[this] = value; }
        }

        [DisplayName("D2 # of children 0-11 months vaccinated"), Column("d2Vac011Months"), NotNull]
        public Int16? D2Vac011Months
        {
            get { return Fields.D2Vac011Months[this]; }
            set { Fields.D2Vac011Months[this] = value; }
        }

        [DisplayName("D2 # of children 12-59 months vaccinated"), Column("d2Vac1259months"), NotNull]
        public Int16? D2Vac1259months
        {
            get { return Fields.D2Vac1259months[this]; }
            set { Fields.D2Vac1259months[this] = value; }
        }

        [DisplayName("D2 # of recorded absent children"), Column("d2RecAbsChildren"), NotNull]
        public Int16? D2RecAbsChildren
        {
            get { return Fields.D2RecAbsChildren[this]; }
            set { Fields.D2RecAbsChildren[this] = value; }
        }

        [DisplayName("D2 # of absent children re-vaccinated"), Column("d2VacAbsChildren"), NotNull]
        public Int16? D2VacAbsChildren
        {
            get { return Fields.D2VacAbsChildren[this]; }
            set { Fields.D2VacAbsChildren[this] = value; }
        }

        [DisplayName("D2 # of Newborn,Sleep and Sick children reocroded"), Column("d2RecNewbornSSC"), NotNull]
        public Int16? D2RecNewbornSsc
        {
            get { return Fields.D2RecNewbornSsc[this]; }
            set { Fields.D2RecNewbornSsc[this] = value; }
        }

        [DisplayName("D2 # of Newborn,Sleep and Sick children vaccinated"), Column("d2VacNewbornSSC"), NotNull]
        public Int16? D2VacNewbornSsc
        {
            get { return Fields.D2VacNewbornSsc[this]; }
            set { Fields.D2VacNewbornSsc[this] = value; }
        }

        [DisplayName("D2 # of refusal children recorded"), Column("d2RecRefusedChildren"), NotNull]
        public Int16? D2RecRefusedChildren
        {
            get { return Fields.D2RecRefusedChildren[this]; }
            set { Fields.D2RecRefusedChildren[this] = value; }
        }

        [DisplayName("D2 # of refusal children re-vaccinated"), Column("d2RevacRefusedChildren"), NotNull]
        public Int16? D2RevacRefusedChildren
        {
            get { return Fields.D2RevacRefusedChildren[this]; }
            set { Fields.D2RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D2 AFP Cases"), Column("d2AFPCase"), NotNull]
        public Int16? D2AfpCase
        {
            get { return Fields.D2AfpCase[this]; }
            set { Fields.D2AfpCase[this] = value; }
        }

        [DisplayName("D3 # of vials distributed"), Column("d3VialDist"), NotNull]
        public Int16? D3VialDist
        {
            get { return Fields.D3VialDist[this]; }
            set { Fields.D3VialDist[this] = value; }
        }

        [DisplayName("D3 # of vials used"), Column("d3VialUse"), NotNull]
        public Int16? D3VialUse
        {
            get { return Fields.D3VialUse[this]; }
            set { Fields.D3VialUse[this] = value; }
        }

        [DisplayName("D3 # of children 0-11 months vaccinated"), Column("d3Vac011Months"), NotNull]
        public Int16? D3Vac011Months
        {
            get { return Fields.D3Vac011Months[this]; }
            set { Fields.D3Vac011Months[this] = value; }
        }

        [DisplayName("D3 # of children 12-59 months vaccinated"), Column("d3Vac1259months"), NotNull]
        public Int16? D3Vac1259months
        {
            get { return Fields.D3Vac1259months[this]; }
            set { Fields.D3Vac1259months[this] = value; }
        }

        [DisplayName("D3 # of recorded absent children"), Column("d3RecAbsChildren"), NotNull]
        public Int16? D3RecAbsChildren
        {
            get { return Fields.D3RecAbsChildren[this]; }
            set { Fields.D3RecAbsChildren[this] = value; }
        }
        [DisplayName("D3 # of absent children re-vaccinated"), Column("d3VacAbsChildren"), NotNull]
        public Int16? D3VacAbsChildren
        {
            get { return Fields.D3VacAbsChildren[this]; }
            set { Fields.D3VacAbsChildren[this] = value; }
        }

        [DisplayName("D3 # of Newborn,Sleep and Sick children reocroded"), Column("d3RecNewbornSSC"), NotNull]
        public Int16? D3RecNewbornSsc
        {
            get { return Fields.D3RecNewbornSsc[this]; }
            set { Fields.D3RecNewbornSsc[this] = value; }
        }

        [DisplayName("D3 # of Newborn,Sleep and Sick children vaccinated"), Column("d3VacNewbornSSC"), NotNull]
        public Int16? D3VacNewbornSsc
        {
            get { return Fields.D3VacNewbornSsc[this]; }
            set { Fields.D3VacNewbornSsc[this] = value; }
        }

        [DisplayName("D3 # of refusal children recorded"), Column("d3RecRefusedChildren"), NotNull]
        public Int16? D3RecRefusedChildren
        {
            get { return Fields.D3RecRefusedChildren[this]; }
            set { Fields.D3RecRefusedChildren[this] = value; }
        }

        [DisplayName("D3 # of refusal children re-vaccinated"), Column("d3RevacRefusedChildren"), NotNull]
        public Int16? D3RevacRefusedChildren
        {
            get { return Fields.D3RevacRefusedChildren[this]; }
            set { Fields.D3RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D3 AFP Cases"), Column("d3AFPCase"), NotNull]
        public Int16? D3AfpCase
        {
            get { return Fields.D3AfpCase[this]; }
            set { Fields.D3AfpCase[this] = value; }
        }

        [DisplayName("D5 # of vials distributed"), Column("d5VialDist"), NotNull]
        public Int16? D5VialDist
        {
            get { return Fields.D5VialDist[this]; }
            set { Fields.D5VialDist[this] = value; }
        }

        [DisplayName("D5 # of vials used"), Column("d5VialUse"), NotNull]
        public Int16? D5VialUse
        {
            get { return Fields.D5VialUse[this]; }
            set { Fields.D5VialUse[this] = value; }
        }

        [DisplayName("D5 # of new children 0-11 months vaccinated"), Column("d5Vac011Months"), NotNull]
        public Int16? D5Vac011Months
        {
            get { return Fields.D5Vac011Months[this]; }
            set { Fields.D5Vac011Months[this] = value; }
        }

        [DisplayName("D5 # of new children 12-59 months vaccinated"), Column("d5Vac1259months"), NotNull]
        public Int16? D5Vac1259months
        {
            get { return Fields.D5Vac1259months[this]; }
            set { Fields.D5Vac1259months[this] = value; }
        }

        [DisplayName("D5 # of missed absent children (1-3)"), Column("d5RecAbsChildren"), NotNull]
        public Int16? D5RecAbsChildren
        {
            get { return Fields.D5RecAbsChildren[this]; }
            set { Fields.D5RecAbsChildren[this] = value; }
        }

        [DisplayName("D5 # of absent children re-vaccinated on day 5"), Column("d5VacAbsChildren"), NotNull]
        public Int16? D5VacAbsChildren
        {
            get { return Fields.D5VacAbsChildren[this]; }
            set { Fields.D5VacAbsChildren[this] = value; }
        }

        [DisplayName("D5 # of missed Newborn,Sleep and Sick children reocroded (1-3)"), Column("d5RecNewbornSSC"), NotNull]
        public Int16? D5RecNewbornSsc
        {
            get { return Fields.D5RecNewbornSsc[this]; }
            set { Fields.D5RecNewbornSsc[this] = value; }
        }

        [DisplayName("D5 # of Newborn,Sleep and Sick children vaccinated on day 5"), Column("d5VacNewbornSSC"), NotNull]
        public Int16? D5VacNewbornSsc
        {
            get { return Fields.D5VacNewbornSsc[this]; }
            set { Fields.D5VacNewbornSsc[this] = value; }
        }

        [DisplayName("D5 # of missed refusal children recorded (1-3)"), Column("d5RecRefusedChildren"), NotNull]
        public Int16? D5RecRefusedChildren
        {
            get { return Fields.D5RecRefusedChildren[this]; }
            set { Fields.D5RecRefusedChildren[this] = value; }
        }

        [DisplayName("D5 # of refusal children re-vaccinated on day 5"), Column("d5RevacRefusedChildren"), NotNull]
        public Int16? D5RevacRefusedChildren
        {
            get { return Fields.D5RevacRefusedChildren[this]; }
            set { Fields.D5RevacRefusedChildren[this] = value; }
        }

        [DisplayName("D5 AFP Cases"), Column("d5AFPCase"), NotNull]
        public Int16? D5AfpCase
        {
            get { return Fields.D5AfpCase[this]; }
            set { Fields.D5AfpCase[this] = value; }
        }


        [DisplayName("LDP Type")]
        public string LDPTypes
        {
            get { return Fields.LDPTypes[this]; }
            set { Fields.LDPTypes[this] = value; }
        }

        [Expression("jCluster.[DistrictId]"), ForeignKey("District", "DistrictId"), LeftJoin("r"), LookupInclude, QuickSearch]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }
        //[Expression("r.[Dname]"),DisplayName("District")]
        //public string District
        //{
        //    get { return Fields.Dname[this]; }
        //    set { Fields.Dname[this] = value; }
        //}

        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.DailyVaccinationsId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();
        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }


        public DailyVaccinationsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DailyVaccinationsId;
            public Int32Field CampaignDayId;
            public Int64Field ClusterId;
            public Int32Field TargetU5Case;
            public Int16Field D1VialDist;
            public Int16Field D1VialUse;
            public Int16Field D1Vac011Months;
            public Int16Field D1Vac1259months;
            public Int16Field D1RecAbsChildren;
            public Int16Field D1VacAbsChildren;
            public Int16Field D1RecNewbornSsc;
            public Int16Field D1VacNewbornSsc;
            public Int16Field D1RecRefusedChildren;
            public Int16Field D1RevacRefusedChildren;
            public Int16Field D1AfpCase;
            public Int16Field D2VialDist;
            public Int16Field D2VialUse;
            public Int16Field D2Vac011Months;
            public Int16Field D2Vac1259months;
            public Int16Field D2RecAbsChildren;
            public Int16Field D2VacAbsChildren;
            public Int16Field D2RecNewbornSsc;
            public Int16Field D2VacNewbornSsc;
            public Int16Field D2RecRefusedChildren;
            public Int16Field D2RevacRefusedChildren;
            public Int16Field D2AfpCase;
            public Int16Field D3VialDist;
            public Int16Field D3VialUse;
            public Int16Field D3Vac011Months;
            public Int16Field D3Vac1259months;
            public Int16Field D3RecAbsChildren;
            public Int16Field D3VacAbsChildren;
            public Int16Field D3RecNewbornSsc;
            public Int16Field D3VacNewbornSsc;
            public Int16Field D3RecRefusedChildren;
            public Int16Field D3RevacRefusedChildren;
            public Int16Field D3AfpCase;
            public Int16Field D5VialDist;
            public Int16Field D5VialUse;
            public Int16Field D5Vac011Months;
            public Int16Field D5Vac1259months;
            public Int16Field D5RecAbsChildren;
            public Int16Field D5VacAbsChildren;
            public Int16Field D5RecNewbornSsc;
            public Int16Field D5VacNewbornSsc;
            public Int16Field D5RecRefusedChildren;
            public Int16Field D5RevacRefusedChildren;
            public Int16Field D5AfpCase;

            public Int16Field DistrictId;
            public StringField Cname;
            public Int32Field TenantId;
            public StringField LDPTypes;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Campaign.DailyVaccinations";
            }
        }
    }
}
