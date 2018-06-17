using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Lookup
{
    public partial class VehicletypeEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Lookup.VehicletypeEditor";

        public VehicletypeEditorAttribute()
            : base(Key)
        {
        }
    }
}

