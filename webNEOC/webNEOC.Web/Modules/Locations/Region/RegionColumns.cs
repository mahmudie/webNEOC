
namespace webNEOC.Locations.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Locations.Region")]
    [BasedOnRow(typeof(Entities.RegionRow))]
    public class RegionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 RegionId { get; set; }
        [EditLink]
        public String Rname { get; set; }
        public String RAbrv { get; set; }
    }
}