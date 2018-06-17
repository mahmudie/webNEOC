
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.ICNImport")]
    public class ICNImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

