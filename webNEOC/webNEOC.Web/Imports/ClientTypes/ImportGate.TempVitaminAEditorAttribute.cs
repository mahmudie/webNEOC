using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.ImportGate
{
    public partial class TempVitaminAEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.ImportGate.TempVitaminAEditor";

        public TempVitaminAEditorAttribute()
            : base(Key)
        {
        }
    }
}

