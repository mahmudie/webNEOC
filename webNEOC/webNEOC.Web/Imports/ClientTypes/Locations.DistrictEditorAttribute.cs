using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Locations
{
    public partial class DistrictEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Locations.DistrictEditor";

        public DistrictEditorAttribute()
            : base(Key)
        {
        }
    }
}

