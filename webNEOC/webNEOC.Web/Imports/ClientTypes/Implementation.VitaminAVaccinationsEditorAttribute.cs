using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Implementation
{
    public partial class VitaminAVaccinationsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Implementation.VitaminAVaccinationsEditor";

        public VitaminAVaccinationsEditorAttribute()
            : base(Key)
        {
        }
    }
}

