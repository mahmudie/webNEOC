
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.ICMHouseholdImport")]
    public class ICMHouseholdImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

