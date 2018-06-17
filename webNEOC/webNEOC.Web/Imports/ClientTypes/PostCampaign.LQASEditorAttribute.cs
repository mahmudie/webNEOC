using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.PostCampaign
{
    public partial class LQASEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.PostCampaign.LQASEditor";

        public LQASEditorAttribute()
            : base(Key)
        {
        }
    }
}

