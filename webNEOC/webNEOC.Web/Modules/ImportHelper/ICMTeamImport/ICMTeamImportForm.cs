
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.ICMTeamImport")]
    public class ICMTeamImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

