
namespace webNEOC.Campaign.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Campaign"), InstanceName("Campaign"), TwoLevelCached]
    [ReadPermission("Campaign:Campaign:Read")]
    [InsertPermission("Campaign:Campaign:Insert")]
    [UpdatePermission("Campaign:Campaign:Update")]
    [DeletePermission("Campaign:Campaign:Delete")]
    [LookupScript("Campaign.Campaign")]
    public sealed class CampaignRow : Row, IIdRow, INameRow
    {        
            #region Campaign Id
            [DisplayName("Campaign Id"), Identity]
            public Int32? CampaignId { get { return Fields.CampaignId[this]; } set { Fields.CampaignId[this] = value; } }
            public partial class RowFields { public Int32Field CampaignId; }
            #endregion CampaignId
                
            #region Campgaign Name
            [DisplayName("Campaign"), Size(100), NotNull, QuickSearch]
            public String CampgaignName { get { return Fields.CampgaignName[this]; } set { Fields.CampgaignName[this] = value; } }
            public partial class RowFields { public StringField CampgaignName; }
            #endregion CampgaignName
                
            #region Date From
            [DisplayName("Date From"), NotNull]
            public DateTime? DateFrom { get { return Fields.DateFrom[this]; } set { Fields.DateFrom[this] = value; } }
            public partial class RowFields { public DateTimeField DateFrom; }
            #endregion DateFrom
                
            #region Date To
            [DisplayName("Date To"), NotNull]
            public DateTime? DateTo { get { return Fields.DateTo[this]; } set { Fields.DateTo[this] = value; } }
            public partial class RowFields { public DateTimeField DateTo; }
            #endregion DateTo
                
            #region Round Id
            [DisplayName("Round"), NotNull]
            public Int16? RoundId { get { return Fields.RoundId[this]; } set { Fields.RoundId[this] = value; } }
            public partial class RowFields { public Int16Field RoundId; }
            #endregion RoundId
                
            #region Date Created
            [DisplayName("Date"), NotNull]
            public DateTime? DateCreated { get { return Fields.DateCreated[this]; } set { Fields.DateCreated[this] = value; } }
            public partial class RowFields { public DateTimeField DateCreated; }
            #endregion DateCreated
                
            #region Comment
            [DisplayName("Comment"), Size(255), NotNull]
            public String Comment { get { return Fields.Comment[this]; } set { Fields.Comment[this] = value; } }
            public partial class RowFields { public StringField Comment; }
            #endregion Comment
                
            #region Status
            [DisplayName("Status"), NotNull]
            public Boolean? Status { get { return Fields.Status[this]; } set { Fields.Status[this] = value; } }
            public partial class RowFields { public BooleanField Status; }
            #endregion Status
        

    #region Foreign Fields

    #endregion Foreign Fields

    #region Id and Name fields
    IIdField IIdRow.IdField
    {
    get { return Fields.CampaignId; }
    }
        
            StringField INameRow.NameField
            {
            get { return Fields.CampgaignName; }
            }
            #endregion Id and Name fields

    #region Constructor
    public CampaignRow()
    : base(Fields)
    {
    }
    #endregion Constructor

    #region RowFields
    public static readonly RowFields Fields = new RowFields().Init();

    public partial class RowFields : RowFieldsBase
    {
    public RowFields()
    : base("[dbo].[Campaign]")
    {
    LocalTextPrefix = "Campaign.Campaign";
    }
    }
    #endregion RowFields
    }
    }
