using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Lookup
{
    public partial class ClusterLevelEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Lookup.ClusterLevelEditor";

        public ClusterLevelEditorAttribute()
            : base(Key)
        {
        }
    }
}

