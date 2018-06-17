
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.VitaminAImport")]
    public class VitaminAImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

