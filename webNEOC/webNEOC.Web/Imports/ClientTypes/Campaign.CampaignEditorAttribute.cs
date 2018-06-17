using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Campaign
{
    public partial class CampaignEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Campaign.CampaignEditor";

        public CampaignEditorAttribute()
            : base(Key)
        {
        }
    }
}

