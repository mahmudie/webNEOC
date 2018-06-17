
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.ICMSupervisorImport")]
    public class ICMSupervisorImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

