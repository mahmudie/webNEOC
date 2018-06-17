
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.CommunicationImport")]
    public class CommunicationImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

