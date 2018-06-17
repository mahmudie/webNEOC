﻿
namespace webNEOC.ImportHelper.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("ImportHelper.PcmImport")]
    public class PcmImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}

