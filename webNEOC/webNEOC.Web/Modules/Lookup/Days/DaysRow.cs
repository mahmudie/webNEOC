
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Days]")]
    [DisplayName("Days"), InstanceName("Days"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DaysRow : Row, IIdRow, INameRow
    {
        [DisplayName("Day Id"), PrimaryKey]
        public Int16? DayId
        {
            get { return Fields.DayId[this]; }
            set { Fields.DayId[this] = value; }
        }

        [DisplayName("Day Name"), Size(50), QuickSearch]
        public String DayName
        {
            get { return Fields.DayName[this]; }
            set { Fields.DayName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.DayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DayName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DaysRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field DayId;
            public StringField DayName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Days";
            }
        }
    }
}
