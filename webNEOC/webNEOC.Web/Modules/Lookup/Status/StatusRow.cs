
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

    [ConnectionKey("Default"), TableName("[dbo].[Status]"), DisplayName("Status"), InstanceName("Status"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.Status.View)]
    [ModifyPermission(LookupPermissionKeys.Status.Update)]
    [DeletePermission(LookupPermissionKeys.Status.Delete)]
    [InsertPermission(LookupPermissionKeys.Status.Insert)]
    [LookupScript("Lookup.Status")]
    public sealed class StatusRow : Row, IIdRow, INameRow
    {
        [DisplayName("Status Id"), Column("StatusID"), PrimaryKey,Identity]
        public Int16? StatusId
        {
            get { return Fields.StatusId[this]; }
            set { Fields.StatusId[this] = value; }
        }

        [DisplayName("Status Name"), Size(255), NotNull, QuickSearch]
        public String StatusName
        {
            get { return Fields.StatusName[this]; }
            set { Fields.StatusName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.StatusId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.StatusName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public StatusRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field StatusId;
            public StringField StatusName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Status";
            }
        }
    }
}
