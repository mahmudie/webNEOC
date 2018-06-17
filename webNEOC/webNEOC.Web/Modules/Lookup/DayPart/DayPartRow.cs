
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Daypart]")]
    [DisplayName("Daypart"), InstanceName("Daypart"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Lookup.Daypart")]
    public sealed class DayPartRow : Row, IIdRow, INameRow
    {
        [DisplayName("Part Id"), PrimaryKey]
        public Int16? DaypartId
        {
            get { return Fields.DaypartId[this]; }
            set { Fields.DaypartId[this] = value; }
        }

        [DisplayName("Part name"), Size(50), QuickSearch]
        public String Daypart
        {
            get { return Fields.Daypart[this]; }
            set { Fields.Daypart[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.DaypartId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Daypart; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DayPartRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field DaypartId;
            public StringField Daypart;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.DayPart";
            }
        }
    }
}
