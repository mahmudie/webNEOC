
namespace webNEOC.Lookup.Entities
{
    using Modules.Lookup;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[CampaignType]"), DisplayName("Campaign Type"), InstanceName("Campaign Type"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.CampaignType.View)]
    [ModifyPermission(LookupPermissionKeys.CampaignType.Update)]
    [DeletePermission(LookupPermissionKeys.CampaignType.Delete)]
    [InsertPermission(LookupPermissionKeys.CampaignType.Insert)]
    [LookupScript("Lookup.CampaignType")]
    public sealed class CampaignTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Campaign Type Id"), PrimaryKey,Identity]
        public Int16? CampaignTypeId
        {
            get { return Fields.CampaignTypeId[this]; }
            set { Fields.CampaignTypeId[this] = value; }
        }

        [DisplayName("Campaign Name"), Size(255), NotNull, QuickSearch]
        public String CampaignName
        {
            get { return Fields.CampaignName[this]; }
            set { Fields.CampaignName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CampaignTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CampaignName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CampaignTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field CampaignTypeId;
            public StringField CampaignName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.CampaignType";
            }
        }
    }
}
