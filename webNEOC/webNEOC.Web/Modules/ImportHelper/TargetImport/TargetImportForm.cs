
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.TargetImport")]
    public class TargetImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

