using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.ImportGate
{
    public partial class TempCampaignEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.ImportGate.TempCampaignEditor";

        public TempCampaignEditorAttribute()
            : base(Key)
        {
        }
    }
}

