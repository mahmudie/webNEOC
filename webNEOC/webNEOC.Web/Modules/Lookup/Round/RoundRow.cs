
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Modules.Lookup;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;
    using MultiTenancy;

    [ConnectionKey("Default"), TableName("[dbo].[Round]"), DisplayName("Round"), InstanceName("Round"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.Round.View)]
    [ModifyPermission(LookupPermissionKeys.Round.Update)]
    [DeletePermission(LookupPermissionKeys.Round.Delete)]
    [InsertPermission(LookupPermissionKeys.Round.Insert)]

    [LookupScript("Lookup.Round")]
    public sealed class RoundRow : Row, IIdRow, INameRow
    {
        [DisplayName("RoundId"), Identity]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [DisplayName("Date From"), NotNull]
        public DateTime? DateFrom
        {
            get { return Fields.DateFrom[this]; }
            set { Fields.DateFrom[this] = value; }
        }

        [DisplayName("Date To"), NotNull]
        public DateTime? DateTo
        {
            get { return Fields.DateTo[this]; }
            set { Fields.DateTo[this] = value; }
        }

        [DisplayName("Round Name"), Size(255), NotNull, QuickSearch]
        public String RoundName
        {
            get { return Fields.RoundName[this]; }
            set { Fields.RoundName[this] = value; }
        }

        [DisplayName("Campaign Type"), Column("CampaignTypeId"), NotNull, ForeignKey("[dbo].[CampaignType]", "CampaignTypeId"), LeftJoin("jCampaignType"), TextualField("CampaignName"), LookupInclude]
        [LookupEditor(typeof(Lookup.Entities.CampaignTypeRow), InplaceAdd = true)]
        public Int16? CampaignTypeId
        {
            get { return Fields.CampaignTypeId[this]; }
            set { Fields.CampaignTypeId[this] = value; }
        }

        [DisplayName("Campaign Type"), Expression("jCampaignType.[CampaignName]"), LookupInclude,NotNull]
        public String CampaignName
        {
            get { return Fields.CampaignName[this]; }
            set { Fields.CampaignName[this] = value; }
        }


        IIdField IIdRow.IdField
        {
            get { return Fields.RoundId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RoundName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RoundRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field RoundId;
            public DateTimeField DateFrom;
            public DateTimeField DateTo;
            public StringField RoundName;
            public Int16Field CampaignTypeId;
            public StringField CampaignName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Round";
            }
        }
    }
}
