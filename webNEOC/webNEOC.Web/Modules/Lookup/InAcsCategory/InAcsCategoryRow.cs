
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

    [ConnectionKey("Default"), TableName("[dbo].[InAcsCategory]"), DisplayName("In Acs Category"), InstanceName("In Acs Category"), TwoLevelCached]
    [ReadPermission(LookupPermissionKeys.InAcsCategory.View)]
    [ModifyPermission(LookupPermissionKeys.InAcsCategory.Update)]
    [DeletePermission(LookupPermissionKeys.InAcsCategory.Delete)]
    [InsertPermission(LookupPermissionKeys.InAcsCategory.Insert)]

    [LookupScript("Lookup.InAcsCategory")]
    public sealed class InAcsCategoryRow : Row, IIdRow, INameRow
    {
        [DisplayName("In Acs Category Id"), Identity]
        public Int16? InAcsCategoryId
        {
            get { return Fields.InAcsCategoryId[this]; }
            set { Fields.InAcsCategoryId[this] = value; }
        }

        [DisplayName("Category Code"), Size(255), NotNull, QuickSearch]
        public String CategoryCode
        {
            get { return Fields.CategoryCode[this]; }
            set { Fields.CategoryCode[this] = value; }
        }

        [DisplayName("Description"), Size(255), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.InAcsCategoryId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InAcsCategoryRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field InAcsCategoryId;
            public StringField CategoryCode;
            public StringField Description;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.InAcsCategory";
            }
        }
    }
}
