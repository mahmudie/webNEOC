
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.LQASImport")]
    public class LQASImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

