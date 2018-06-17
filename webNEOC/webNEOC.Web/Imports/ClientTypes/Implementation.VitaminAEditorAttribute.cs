using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Implementation
{
    public partial class VitaminAEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Implementation.VitaminAEditor";

        public VitaminAEditorAttribute()
            : base(Key)
        {
        }
    }
}

