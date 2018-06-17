using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace webNEOC.Meeting
{
    public partial class MeetingAttendeeEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "webNEOC.Meeting.MeetingAttendeeEditor";

        public MeetingAttendeeEditorAttribute()
            : base(Key)
        {
        }
    }
}

