using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Lookup
{
    public partial class CampaignTypeEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Lookup.CampaignTypeEditor";

        public CampaignTypeEditorAttribute()
            : base(Key)
        {
        }
    }
}

