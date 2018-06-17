using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Implementation
{
    public partial class IcmSupervisorEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Implementation.IcmSupervisorEditor";

        public IcmSupervisorEditorAttribute()
            : base(Key)
        {
        }
    }
}

