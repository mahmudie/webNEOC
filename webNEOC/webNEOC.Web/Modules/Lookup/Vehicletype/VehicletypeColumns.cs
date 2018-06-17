
namespace webNEOC.Lookup.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Lookup.Vehicletype")]
    [BasedOnRow(typeof(Entities.VehicletypeRow))]
    public class VehicletypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 VehicletypeId { get; set; }
        [EditLink]
        public String Typename { get; set; }
    }
}