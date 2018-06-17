using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Lookup
{
    public partial class RoundEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Lookup.RoundEditor";

        public RoundEditorAttribute()
            : base(Key)
        {
        }
    }
}

