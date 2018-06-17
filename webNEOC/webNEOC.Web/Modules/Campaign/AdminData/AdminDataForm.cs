
namespace webNEOC.Campaign.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using webNEOC.Locations.Entities;
    using webNEOC.Lookup.Entities;

    [FormScript("Campaign.AdminData")]
    [BasedOnRow(typeof(Entities.AdminDataRow))]
    public class AdminDataForm
    {
        [Tab("REPORT INFO")]
        [LookupEditor(typeof(RoundRow)), DisplayName("Round")]
        public Int16 RoundId { get; set; }
        [LookupEditor(typeof(ProvinceRow)), DisplayName("Province"),Required]
        public Int16 ProvinceId { get; set; }
        [LookupEditor(typeof(DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int16 DistrictId { get; set; }
        [LookupEditor(typeof(ClusterRow), CascadeFrom = "DistrictId", CascadeField = "DistrictId"),DisplayName("Cluster")]
        public Int64 ClusterId { get; set; }
        [Required]
        public DateTime DateOfCampaign { get; set; }
        [Required]
        public String PemtremtManager { get; set; }
        [Required]
        public String TeamNo { get; set; }

        [Tab("DAY ONE")]
        [Category("Vaccine record")]
        [QuarterWidth]
        public Int32 D1VialsRecieved { get; set; }
        [QuarterWidth]
        public Int32 D1VialsReturned { get; set; }
        [Category("Target children and vaccination")]
        [QuarterWidth]
        public Int32 D1VaccByTransit { get; set; }
        [QuarterWidth]
        public Int32 D1NoOfHhsVisited { get; set; }
        [QuarterWidth]
        public Int32 D1Ch05resident { get; set; }
        [QuarterWidth]
        public Int32 D1Ch05guest { get; set; }
        [QuarterWidth]
        public Int32 D1Ch05VaccInHouse { get; set; }
        [QuarterWidth]
        public Int32 D1Ch05VaccOutHouse { get; set; }
        [QuarterWidth]
        public Int32 D1Ch05NomadVacc { get; set; }
        [Category("During campaign")]
        [QuarterWidth]
        public Int32 D1AbsentRecordDuring { get; set; }
        [QuarterWidth]
        public Int32 D1AbsentFoundVaccDuring { get; set; }
        [QuarterWidth]
        public Int32 D1AbsentVaccDuring { get; set; }
        [QuarterWidth]
        public Int32 D1AbsentRemainDuring { get; set; }
        [QuarterWidth, Category("After campaign")]
        public Int32 D1AbsentRecordAfter { get; set; }
        [QuarterWidth]
        public Int32 D1AbsentFoundVaccAfter { get; set; }
        [QuarterWidth]
        public Int32 D1AbsentVaccAfter { get; set; }
        [QuarterWidth]
        public Int32 D1AbsentRemainAfter { get; set; }
        [QuarterWidth, Category("Newborn, sleep, sick")]
        public Int32 D1NssRecord { get; set; }
        [QuarterWidth]
        public Int32 D1NssFoundVacc { get; set; }
        [QuarterWidth]
        public Int32 D1NssVaccinated { get; set; }
        [QuarterWidth]
        public Int32 D1NssReamining { get; set; }
        [QuarterWidth, Category("Refusals")]
        public Int32 D1RefusalRecord { get; set; }
        [QuarterWidth]
        public Int32 D1RefusalFoundVacc { get; set; }
        [QuarterWidth]
        public Int32 D1RefusalVacc { get; set; }
        [QuarterWidth]
        public Int32 D1RefusalRemaining { get; set; }
        [Tab("DAY TWO")]
        [Category("Vaccine record")]
        [QuarterWidth]
        public Int32 D2VialsRecieved { get; set; }
        [QuarterWidth]
        public Int32 D2VialsReturned { get; set; }
        [QuarterWidth, Category("Target children and vaccination")]
        public Int32 D2VaccByTransit { get; set; }
        [QuarterWidth]
        public Int32 D2NoOfHhsVisited { get; set; }
        [QuarterWidth]
        public Int32 D2Ch05resident { get; set; }
        [QuarterWidth]
        public Int32 D2Ch05guest { get; set; }
        [QuarterWidth]
        public Int32 D2Ch05VaccInHouse { get; set; }
        [QuarterWidth]
        public Int32 D2Ch05VaccOutHouse { get; set; }
        [QuarterWidth]
        public Int32 D2Ch05NomadVacc { get; set; }
        [QuarterWidth, Category("During campaign")]
        public Int32 D2AbsentRecordDuring { get; set; }
        [QuarterWidth]
        public Int32 D2AbsentFoundVaccDuring { get; set; }
        [QuarterWidth]
        public Int32 D2AbsentVaccDuring { get; set; }
        [QuarterWidth]
        public Int32 D2AbsentRemainDuring { get; set; }
        [QuarterWidth, Category("After campaign")]
        public Int32 D2AbsentRecordAfter { get; set; }
        [QuarterWidth]
        public Int32 D2AbsentFoundVaccAfter { get; set; }
        [QuarterWidth]
        public Int32 D2AbsentVaccAfter { get; set; }
        [QuarterWidth]
        public Int32 D2AbsentRemainAfter { get; set; }
        [QuarterWidth, Category("Newborn, sleep, sick")]
        public Int32 D2NssRecord { get; set; }
        [QuarterWidth]
        public Int32 D2NssFoundVacc { get; set; }
        [QuarterWidth]
        public Int32 D2NssVaccinated { get; set; }
        [QuarterWidth]
        public Int32 D2NssReamining { get; set; }
        [QuarterWidth, Category("Refusals")]
        public Int32 D2RefusalRecord { get; set; }
        [QuarterWidth]
        public Int32 D2RefusalFoundVacc { get; set; }
        [QuarterWidth]
        public Int32 D2RefusalVacc { get; set; }
        [QuarterWidth]
        public Int32 D2RefusalRemaining { get; set; }
        [Tab("DAY THREE"),Category("Vaccine record")]
        [QuarterWidth]
        public Int32 D3VialsRecieved { get; set; }
        [QuarterWidth]
        public Int32 D3VialsReturned { get; set; }
        [QuarterWidth, Category("Target children and vaccination")]
        public Int32 D3VaccByTransit { get; set; }
        [QuarterWidth]
        public Int32 D3NoOfHhsVisited { get; set; }
        [QuarterWidth]
        public Int32 D3Ch05resident { get; set; }
        [QuarterWidth]
        public Int32 D3Ch05guest { get; set; }
        [QuarterWidth]
        public Int32 D3Ch05VaccInHouse { get; set; }
        [QuarterWidth]
        public Int32 D3Ch05VaccOutHouse { get; set; }
        [QuarterWidth]
        public Int32 D3Ch05NomadVacc { get; set; }
        [QuarterWidth, Category("During campaign")]
        public Int32 D3AbsentRecordDuring { get; set; }
        [QuarterWidth]
        public Int32 D3AbsentFoundVaccDuring { get; set; }
        [QuarterWidth]
        public Int32 D3AbsentVaccDuring { get; set; }
        [QuarterWidth]
        public Int32 D3AbsentRemainDuring { get; set; }
        [QuarterWidth, Category("After campaign")]
        public Int32 D3AbsentRecordAfter { get; set; }
        [QuarterWidth]
        public Int32 D3AbsentFoundVaccAfter { get; set; }
        [QuarterWidth]
        public Int32 D3AbsentVaccAfter { get; set; }
        [QuarterWidth]
        public Int32 D3AbsentRemainAfter { get; set; }
        [QuarterWidth, Category("Newborn, sleep, sick")]
        public Int32 D3NssRecord { get; set; }
        [QuarterWidth]
        public Int32 D3NssFoundVacc { get; set; }
        [QuarterWidth]
        public Int32 D3NssVaccinated { get; set; }
        [QuarterWidth]
        public Int32 D3NssReamining { get; set; }
        [QuarterWidth, Category("Refusals")]
        public Int32 D3RefusalRecord { get; set; }
        [QuarterWidth]

        public Int32 D3RefusalFoundVacc { get; set; }
        [QuarterWidth]
        public Int32 D3RefusalVacc { get; set; }
        [QuarterWidth]
        public Int32 D3RefusalRemaining { get; set; }
        [Tab("DAY FIVE")]
        [Category("Vaccine record")]
        [QuarterWidth]
        public Int32 D5VialsRecieved { get; set; }
        [QuarterWidth]
        public Int32 D5VialsReturned { get; set; }
        [Category("During campaign"),QuarterWidth]
        public Int32 D5RemainAbsentDuring { get; set; }
        [QuarterWidth]
        public Int32 D5AbsentFoundVaccDuring5 { get; set; }
        [QuarterWidth]
        public Int32 D5AbsentVaccDuring5 { get; set; }
        [QuarterWidth]
        public Int32 D5AbsentRemainDuring5 { get; set; }
        [QuarterWidth, Category("After campaign")]
        public Int32 D5RemainAbsentAfter { get; set; }
        [QuarterWidth]
        public Int32 D5AbsentFoundVaccAfter5 { get; set; }
        [QuarterWidth]
        public Int32 D5AbsentVaccAfter5 { get; set; }
        [QuarterWidth]
        public Int32 D5AbsentRemainAfter5 { get; set; }
        [QuarterWidth, Category("Newborn, sleep, sick")]
        public Int32 D5RemainNss { get; set; }
        [QuarterWidth]
        public Int32 D5FoundVaccNss5 { get; set; }
        [QuarterWidth]
        public Int32 D5VaccNss5 { get; set; }
        [QuarterWidth]
        public Int32 D5RemainNss5 { get; set; }
        [QuarterWidth, Category("Refusals")]
        public Int32 D5RemainRefusal { get; set; }
        [QuarterWidth]
        public Int32 D5FoundVaccRefusal5 { get; set; }
        [QuarterWidth]
        public Int32 D5VaccRefusal5 { get; set; }

        [QuarterWidth]
        public Int32 D5RemainRefusal5 { get; set; }
        [QuarterWidth,Category("Out of houseses")]
        public Int32 D5VaccOutofHouse { get; set; }
    }
}