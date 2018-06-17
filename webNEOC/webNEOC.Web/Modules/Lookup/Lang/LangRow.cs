
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Lang]")]
    [DisplayName("Language"), InstanceName("Language"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Lookup.Lang")]
    public sealed class LangRow : Row, IIdRow, INameRow
    {
        [DisplayName("Language Id"), Identity]
        public Int32? LanguageId
        {
            get { return Fields.LanguageId[this]; }
            set { Fields.LanguageId[this] = value; }
        }

        [DisplayName("Language Name"), Size(50), QuickSearch]
        public String LanguageName
        {
            get { return Fields.LanguageName[this]; }
            set { Fields.LanguageName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.LanguageId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LanguageName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LangRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field LanguageId;
            public StringField LanguageName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Lang";
            }
        }
    }
}
