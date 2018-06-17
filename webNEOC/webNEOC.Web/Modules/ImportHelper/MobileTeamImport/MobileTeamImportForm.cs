
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.MobileTeamImport")]
    public class MobileTeamImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

