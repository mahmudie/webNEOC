using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.CVA
{
    public partial class PTTSEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.CVA.PTTSEditor";

        public PTTSEditorAttribute()
            : base(Key)
        {
        }
    }
}

