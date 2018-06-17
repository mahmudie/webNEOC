
namespace webNEOC.Locations.Entities
{
    using Serenity;
    using Modules.LocationPermission;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Region]"), DisplayName("Region"), InstanceName("Region"), TwoLevelCached]
    [ReadPermission(PermissionKeys.Region.View)]
    [ModifyPermission(PermissionKeys.Region.Update)]
    [InsertPermission(PermissionKeys.Region.Insert)]
    [DeletePermission(PermissionKeys.Region.Delete)]

    [LookupScript("Locations.Region")]
    public sealed class RegionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Region Id"), Column("RegionID"), Identity]
        public Int16? RegionId
        {
            get { return Fields.RegionId[this]; }
            set { Fields.RegionId[this] = value; }
        }

        [DisplayName("Region"), Size(30), NotNull, QuickSearch]
        public String Rname
        {
            get { return Fields.Rname[this]; }
            set { Fields.Rname[this] = value; }
        }

        [DisplayName("Region Abrv"), Size(5), NotNull]
        public String RAbrv
        {
            get { return Fields.RAbrv[this]; }
            set { Fields.RAbrv[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RegionId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Rname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RegionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field RegionId;
            public StringField Rname;
            public StringField RAbrv;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Locations.Region";
            }
        }
    }
}
