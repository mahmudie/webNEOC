
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

    [ConnectionKey("Default"), TableName("[dbo].[ClusterLevel]"), DisplayName("Cluster Level"), InstanceName("Cluster Level"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.ClusterLevel.View)]
    [ModifyPermission(LookupPermissionKeys.ClusterLevel.Update)]
    [DeletePermission(LookupPermissionKeys.ClusterLevel.Delete)]
    [InsertPermission(LookupPermissionKeys.ClusterLevel.Insert)]
    [LookupScript("Lookup.ClusterLevel")]
    public sealed class ClusterLevelRow : Row, IIdRow, INameRow
    {
        [DisplayName("Cluster Level Id"), PrimaryKey,Identity]
        public Int16? ClusterLevelId
        {
            get { return Fields.ClusterLevelId[this]; }
            set { Fields.ClusterLevelId[this] = value; }
        }

        [DisplayName("Cluster Name"), Size(255), NotNull, QuickSearch]
        public String ClusterName
        {
            get { return Fields.ClusterName[this]; }
            set { Fields.ClusterName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ClusterLevelId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ClusterName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ClusterLevelRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field ClusterLevelId;
            public StringField ClusterName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.ClusterLevel";
            }
        }
    }
}
