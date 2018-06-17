
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

    [ConnectionKey("Default"), TableName("[dbo].[Months]"), DisplayName("Months"), InstanceName("Months"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.ClusterLevel.View)]
    [ModifyPermission(LookupPermissionKeys.ClusterLevel.Update)]
    [DeletePermission(LookupPermissionKeys.ClusterLevel.Delete)]
    [InsertPermission(LookupPermissionKeys.ClusterLevel.Insert)]
    [LookupScript("Lookup.Months")]
    public sealed class MonthsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Month Id"), PrimaryKey]
        public Int32? MonthId
        {
            get { return Fields.MonthId[this]; }
            set { Fields.MonthId[this] = value; }
        }

        [DisplayName("Monthshort"), Size(50), QuickSearch]
        public String Monthshort
        {
            get { return Fields.Monthshort[this]; }
            set { Fields.Monthshort[this] = value; }
        }

        [DisplayName("Monthlong"), Size(50)]
        public String Monthlong
        {
            get { return Fields.Monthlong[this]; }
            set { Fields.Monthlong[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MonthId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Monthlong; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MonthsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MonthId;
            public StringField Monthshort;
            public StringField Monthlong;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Months";
            }
        }
    }
}
