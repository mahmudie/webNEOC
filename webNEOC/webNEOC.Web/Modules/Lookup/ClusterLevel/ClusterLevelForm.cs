
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.ClusterLevel")]
    [BasedOnRow(typeof(Entities.ClusterLevelRow))]
    public class ClusterLevelForm
    {
        public String ClusterName { get; set; }
    }
}