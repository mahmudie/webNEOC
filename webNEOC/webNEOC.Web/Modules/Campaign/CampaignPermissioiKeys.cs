using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webNEOC.Modules.Campaign
{
    public class CampaignPermissionKeys
    {
        public class Vaccinations
        {
            public const string Read = "Campaign:DailyVaccinations:Read";
            public const string Insert = "Campaign:DailyVaccinations:Insert";
            public const string Update = "Campaign:DailyVaccinations:Update";
            public const string Delete = "Campaign:DailyVaccinations:Delete";
            public const string View = "Campaign:DailyVaccinations:View";
        }

        public const string General = "Campaign:General";


        public class CampaignDay
        {
            public const string Read = "Campaign:CampaignDay:Read";
            public const string Insert = "Campaign:CampaignDay:Insert";
            public const string Update = "Campaign:CampaignDay:Update";
            public const string Delete = "Campaign:CampaignDay:Delete";
            public const string View = "Campaign:CampaignDay:View";
            public const string Modify = "Campaign:CampaignDay:Modify";
        }
        public class AdminData
        {
            public const string Read = "Campaign:AdminData:Read";
            public const string Insert = "Campaign:AdminData:Insert";
            public const string Update = "Campaign:AdminData:Update";
            public const string Delete = "Campaign:AdminData:Delete";
            public const string View = "Campaign:AdminData:View";
            public const string Modify = "Campaign:AdminData:Modify";
        }
    }
}