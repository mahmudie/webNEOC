using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webNEOC.Modules.PostCampaign
{
    public class PostCampaignPermissionKeys
    {
        public class LQASS
        {
            public const string Insert = "PostCampaign:LQAS:Insert";
            public const string Update = "PostCampaign:LQAS:Update";
            public const string Delete = "PostCampaign:LQAS:Delete";
            public const string View = "PostCampaign:LQAS:View";
            public const string Modify = "PostCampaign:LQAS:Modify";
        }
        public class OutOfHouseSurvey
        {
            public const string Insert = "PostCampaign:OutOfHouseSurvey:Insert";
            public const string Update = "PostCampaign:OutOfHouseSurvey:Update";
            public const string Delete = "PostCampaign:OutOfHouseSurvey:Delete";
            public const string View = "PostCampaign:OutOfHouseSurvey:View";
            public const string Modify = "PostCampaign:OutOfHouseSurvey:Modify";
        }

        public class Pcm
        {
            public const string Insert = "PostCampaign:Pcm:Insert";
            public const string Update = "PostCampaign:Pcm:Update";
            public const string Delete = "PostCampaign:Pcm:Delete";
            public const string View = "PostCampaign:Pcm:View";
            public const string Modify = "PostCampaign:Pcm:Modify";
        }
    }
}