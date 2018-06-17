
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[MediaType]")]
    [DisplayName("Media Type"), InstanceName("Media Type"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Lookup.MediaType")]
    public sealed class MediaTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Media Type Id"), Identity]
        public Int16? MediaTypeId
        {
            get { return Fields.MediaTypeId[this]; }
            set { Fields.MediaTypeId[this] = value; }
        }

        [DisplayName("Media Type Name"), Size(50), QuickSearch]
        public String MediaTypeName
        {
            get { return Fields.MediaTypeName[this]; }
            set { Fields.MediaTypeName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MediaTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MediaTypeName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MediaTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field MediaTypeId;
            public StringField MediaTypeName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.MediaType";
            }
        }
    }
}
