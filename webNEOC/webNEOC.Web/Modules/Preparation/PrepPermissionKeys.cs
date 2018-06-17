using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webNEOC.Modules.Preparation
{
    public class PrepPermissionKeys
    {
        public class InAccessible
        {
            public const string Insert = "Preparation:InAccessible:Insert";
            public const string Update = "Preparation:InAccessible:Update";
            public const string Delete = "Preparation:InAccessible:Delete";
            public const string View = "Preparation:InAccessible:View";
            public const string Modify = "Preparation:InAccessible:Modify";
        }
        public class Microplan
        {
            public const string Insert = "Preparation:Microplan:Insert";
            public const string Update = "Preparation:Microplan:Update";
            public const string Delete = "Preparation:Microplan:Delete";
            public const string View = "Preparation:Microplan:View";
        }
    }
}