using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.PostCampaign
{
    public partial class OutOfHouseSurveyEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.PostCampaign.OutOfHouseSurveyEditor";

        public OutOfHouseSurveyEditorAttribute()
            : base(Key)
        {
        }
    }
}

