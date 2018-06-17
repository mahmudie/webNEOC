using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Lookup
{
    public partial class InAcsCategoryEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Lookup.InAcsCategoryEditor";

        public InAcsCategoryEditorAttribute()
            : base(Key)
        {
        }
    }
}

