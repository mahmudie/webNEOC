
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[ICNType]")]
    [DisplayName("Icn Type"), InstanceName("Icn Type"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class IcnTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Icn Type Id"), Column("ICNTypeId"), Identity]
        public Int16? IcnTypeId
        {
            get { return Fields.IcnTypeId[this]; }
            set { Fields.IcnTypeId[this] = value; }
        }

        [DisplayName("Icn Type"), Column("ICNType"), Size(50), QuickSearch]
        public String IcnType
        {
            get { return Fields.IcnType[this]; }
            set { Fields.IcnType[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IcnTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.IcnType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public IcnTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field IcnTypeId;
            public StringField IcnType;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.IcnType";
            }
        }
    }
}
