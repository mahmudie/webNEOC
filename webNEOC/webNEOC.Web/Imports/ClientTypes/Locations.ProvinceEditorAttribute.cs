using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Locations
{
    public partial class ProvinceEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Locations.ProvinceEditor";

        public ProvinceEditorAttribute()
            : base(Key)
        {
        }
    }
}

