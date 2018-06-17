using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Lookup
{
    public partial class StatusEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Lookup.StatusEditor";

        public StatusEditorAttribute()
            : base(Key)
        {
        }
    }
}

