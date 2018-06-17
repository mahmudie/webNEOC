
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

    [ConnectionKey("Default"), TableName("[dbo].[Vehicletype]"), DisplayName("Vehicletype"), InstanceName("Vehicletype"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.Vehicletype.View)]
    [ModifyPermission(LookupPermissionKeys.Vehicletype.Update)]
    [DeletePermission(LookupPermissionKeys.Vehicletype.Delete)]
    [InsertPermission(LookupPermissionKeys.Vehicletype.Insert)]
    [LookupScript("Lookup.Vehicletype")]
    public sealed class VehicletypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("ID"), Identity]
        public Int16? VehicletypeId
        {
            get { return Fields.VehicletypeId[this]; }
            set { Fields.VehicletypeId[this] = value; }
        }

        [DisplayName("Typename"), Size(255), QuickSearch]
        public String Typename
        {
            get { return Fields.Typename[this]; }
            set { Fields.Typename[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.VehicletypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Typename; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VehicletypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field VehicletypeId;
            public StringField Typename;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.Vehicletype";
            }
        }
    }
}
