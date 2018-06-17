
namespace webNEOC.Lookup.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Lookup.Vehicletype")]
    [BasedOnRow(typeof(Entities.VehicletypeRow))]
    public class VehicletypeForm
    {
        public String Typename { get; set; }
    }
}