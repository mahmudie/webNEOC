
namespace webNEOC.Lookup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[RecruitmentType]")]
    [DisplayName("Recruitment Type"), InstanceName("Recruitment Type"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RecruitmentTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recruitment Type Id"), PrimaryKey]
        public Int16? RecruitmentTypeId
        {
            get { return Fields.RecruitmentTypeId[this]; }
            set { Fields.RecruitmentTypeId[this] = value; }
        }

        [DisplayName("Recruitment Type"), Size(50), QuickSearch]
        public String RecruitmentType
        {
            get { return Fields.RecruitmentType[this]; }
            set { Fields.RecruitmentType[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RecruitmentTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RecruitmentType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RecruitmentTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int16Field RecruitmentTypeId;
            public StringField RecruitmentType;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Lookup.RecruitmentType";
            }
        }
    }
}
