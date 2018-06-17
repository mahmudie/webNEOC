
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.AdminDataImport")]
    public class AdminDataImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

