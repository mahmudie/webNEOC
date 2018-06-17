
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Media]")]
    [DisplayName("Media"), InstanceName("Media"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Lookup.Media")]
    public sealed class MediaRow : Row, IIdRow, INameRow
    {
        [DisplayName("Media Id"), Identity]
        public Int32? MediaId
        {
            get { return Fields.MediaId[this]; }
            set { Fields.MediaId[this] = value; }
        }

        [DisplayName("Media Name"), Size(50), QuickSearch]
        public String MediaName
        {
            get { return Fields.MediaName[this]; }
            set { Fields.MediaName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MediaId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MediaName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MediaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MediaId;
            public StringField MediaName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Media";
            }
        }
    }
}
