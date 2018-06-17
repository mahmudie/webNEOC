using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Campaign
{
    public partial class DailyVaccinationsFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "webNEOC.Campaign.DailyVaccinationsFormatter";

        public DailyVaccinationsFormatterAttribute()
            : base(Key)
        {
        }
    }
}

