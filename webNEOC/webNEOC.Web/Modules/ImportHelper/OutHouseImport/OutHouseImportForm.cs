
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.OutHouseImport")]
    public class OutHouseImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

