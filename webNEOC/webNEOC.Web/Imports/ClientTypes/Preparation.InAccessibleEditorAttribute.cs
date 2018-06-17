using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Preparation
{
    public partial class InAccessibleEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Preparation.InAccessibleEditor";

        public InAccessibleEditorAttribute()
            : base(Key)
        {
        }
    }
}

