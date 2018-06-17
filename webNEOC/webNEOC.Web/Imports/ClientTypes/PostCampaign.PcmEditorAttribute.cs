using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.PostCampaign
{
    public partial class PcmEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.PostCampaign.PcmEditor";

        public PcmEditorAttribute()
            : base(Key)
        {
        }
    }
}

