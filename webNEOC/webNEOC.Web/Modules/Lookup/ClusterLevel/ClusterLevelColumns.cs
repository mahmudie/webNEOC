
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.ClusterLevel")]
    [BasedOnRow(typeof(Entities.ClusterLevelRow))]
    public class ClusterLevelColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 ClusterLevelId { get; set; }
        [EditLink]
        public String ClusterName { get; set; }
    }
}