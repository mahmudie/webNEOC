using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webNEOC.Modules.LocationPermission
{
    public class PermissionKeys
    {
        public class Region
        {
            public const string Insert = "Locations:Region:Insert";
            public const string Update = "Locations:Region:Update";
            public const string Delete = "Locations:Region:Delete";
            public const string View = "Locations:Region:View";
        }
        public class Province
        {
            public const string Insert = "Locations:Province:Insert";
            public const string Update = "Locations:Province:Update";
            public const string Delete = "Locations:Province:Delete";
            public const string View = "Locations:Province:View";
        }

        public class District
        {
            public const string Insert = "Locations:District:Insert";
            public const string Update = "Locations:District:Update";
            public const string Delete = "Locations:District:Delete";
            public const string View = "Locations:District:View";
        }

        public class Cluster
        {
            public const string Insert = "Locations:Cluster:Insert";
            public const string Update = "Locations:Cluster:Update";
            public const string Delete = "Locations:Cluster:Delete";
            public const string View = "Locations:Cluster:View";
        }
    }
}