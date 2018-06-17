using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Campaign
{
    public partial class CampaignDayEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Campaign.CampaignDayEditor";

        public CampaignDayEditorAttribute()
            : base(Key)
        {
        }
    }
}

