
namespace webNEOC.Implementation.Entities
{
    using MultiTenancy;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Communication]")]
    [DisplayName("Communication"), InstanceName("Communication"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CommunicationRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Communication Id"), Identity]
        public Int32? CommunicationId
        {
            get { return Fields.CommunicationId[this]; }
            set { Fields.CommunicationId[this] = value; }
        }

        [DisplayName("Language"), NotNull, ForeignKey("[dbo].[Lang]", "LanguageId"), LeftJoin("jLanguage"), TextualField("LanguageLanguageName")]
        public Int32? LanguageId
        {
            get { return Fields.LanguageId[this]; }
            set { Fields.LanguageId[this] = value; }
        }

        [DisplayName("Media Type"), NotNull, ForeignKey("[dbo].[MediaType]", "MediaTypeId"), LeftJoin("jMediaType"), TextualField("MediaTypeMediaTypeName")]
        public Int16? MediaTypeId
        {
            get { return Fields.MediaTypeId[this]; }
            set { Fields.MediaTypeId[this] = value; }
        }

        [DisplayName("Duration"), NotNull,QuickSearch,QuickFilter]
        public Int32? Duration
        {
            get { return Fields.Duration[this]; }
            set { Fields.Duration[this] = value; }
        }

        [DisplayName("Media"), NotNull, ForeignKey("[dbo].[Media]", "MediaId"), LeftJoin("jMedia"), TextualField("MediaMediaName")]
        public Int32? MediaId
        {
            get { return Fields.MediaId[this]; }
            set { Fields.MediaId[this] = value; }
        }

        [DisplayName("Broadcast Date"), NotNull]
        public DateTime? BroadCastDate
        {
            get { return Fields.BroadCastDate[this]; }
            set { Fields.BroadCastDate[this] = value; }
        }

        [DisplayName("Source"),QuickSearch, Size(50)]
        public String Source
        {
            get { return Fields.Source[this]; }
            set { Fields.Source[this] = value; }
        }

        [DisplayName("Language Name"), Expression("jLanguage.[LanguageName]"),QuickSearch]
        public String LanguageLanguageName
        {
            get { return Fields.LanguageLanguageName[this]; }
            set { Fields.LanguageLanguageName[this] = value; }
        }


        [DisplayName("Media Type"), Expression("jMediaType.[MediaTypeName]"),QuickSearch]
        public String MediaTypeMediaTypeName
        {
            get { return Fields.MediaTypeMediaTypeName[this]; }
            set { Fields.MediaTypeMediaTypeName[this] = value; }
        }

        [DisplayName("Media Name"), Expression("jMedia.[MediaName]"),QuickSearch]
        public String MediaMediaName
        {
            get { return Fields.MediaMediaName[this]; }
            set { Fields.MediaMediaName[this] = value; }
        }

        [DisplayName("Broadcast Time")]
        public TimeSpan? BroadCastTime
        {
            get { return Fields.BroadCastTime[this]; }
            set { Fields.BroadCastTime[this] = value; }
        }


        [DisplayName("Day Id"), NotNull, ForeignKey("[dbo].[DayPart]", "DaypartId"), LeftJoin("jDaypart"), TextualField("Daypart")]
        public Int16? DaypartId
        {
            get { return Fields.DaypartId[this]; }
            set { Fields.DaypartId[this] = value; }
        }

        [DisplayName("Day part"), Expression("jDaypart.[Daypart]"),QuickSearch]
        public String Daypart
        {
            get { return Fields.Daypart[this]; }
            set { Fields.Daypart[this] = value; }
        }

        [DisplayName("UniqueId"), Expression("(jDaypart.Daypart  +' '+ jMediaType.[MediaTypeName]+' ' +jMedia.[MediaName]+' ' + jLanguage.[LanguageName])")]
        public String CommunId
        {
            get { return Fields.CommunId[this]; }
            set { Fields.CommunId[this] = value; }
        }

        [Insertable(true), Updatable(true)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }
        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CommunicationId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CommunId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CommunicationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CommunicationId;
            public Int32Field LanguageId;
            public Int16Field MediaTypeId;
            public Int32Field Duration;
            public Int32Field MediaId;
            public DateTimeField BroadCastDate;
            public StringField Source;

            public Int32Field TenantId;

            public StringField LanguageLanguageName;

            public StringField MediaTypeMediaTypeName;

            public StringField MediaMediaName;
            public TimeSpanField BroadCastTime;

            public Int16Field DaypartId;
            public StringField Daypart;

            public StringField CommunId;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "Implementation.Communication";
            }
        }
    }
}
