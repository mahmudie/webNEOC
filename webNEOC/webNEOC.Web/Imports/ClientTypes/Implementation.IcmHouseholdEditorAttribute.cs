using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Implementation
{
    public partial class IcmHouseholdEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Implementation.IcmHouseholdEditor";

        public IcmHouseholdEditorAttribute()
            : base(Key)
        {
        }
    }
}

