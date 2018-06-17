using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Implementation
{
    public partial class IcmTeamEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Implementation.IcmTeamEditor";

        public IcmTeamEditorAttribute()
            : base(Key)
        {
        }
    }
}

