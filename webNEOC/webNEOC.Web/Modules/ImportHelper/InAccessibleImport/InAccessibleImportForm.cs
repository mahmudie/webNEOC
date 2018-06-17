
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.InAccessibleImport")]
    public class InAccessibleImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

