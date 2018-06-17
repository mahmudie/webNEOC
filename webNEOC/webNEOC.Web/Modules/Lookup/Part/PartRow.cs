
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

    [ConnectionKey("Default"), TableName("[dbo].[Part]"), DisplayName("Part"), InstanceName("Part"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.Part.View)]
    [ModifyPermission(LookupPermissionKeys.Part.Update)]
    [DeletePermission(LookupPermissionKeys.Part.Delete)]
    [InsertPermission(LookupPermissionKeys.Part.Insert)]
    [LookupScript("Lookup.Part")]
    public sealed class PartRow : Row, IIdRow, INameRow
    {
        [DisplayName("PartId"), Identity]
        public Int16? PartId
        {
            get { return Fields.PartId[this]; }
            set { Fields.PartId[this] = value; }
        }

        [DisplayName("Part Name"), Size(255), NotNull, QuickSearch]
        public String PartName
        {
            get { return Fields.PartName[this]; }
            set { Fields.PartName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PartId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PartName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PartRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field PartId;
            public StringField PartName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Part";
            }
        }
    }
}
