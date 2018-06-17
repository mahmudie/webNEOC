
namespace webNEOC.Campaign.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using webNEOC.Lookup.Entities;
    using webNEOC.Modules.Campaign;

    [ColumnsScript("Campaign.AdminData")]
    [BasedOnRow(typeof(Entities.AdminDataRow))]
    public class AdminDataColumns
    {
        [ModifyPermission(CampaignPermissionKeys.AdminData.Modify), Width(80), SortOrder(1, descending: false)]
        public Boolean Approved { get; set; }
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 AdminDataId { get; set; }
        [LookupEditor(typeof(RoundRow)),QuickFilter]
         public string Round { get; set; }

        [Width(130), LookupEditor(typeof(Locations.Entities.ProvinceRow)), QuickFilter]
        [DisplayName("Province")]
        public string Province { get; set; }

        [Width(120), LookupEditor(typeof(Locations.Entities.DistrictRow)), QuickFilter]
        [QuickFilterOption("cascadeFrom", "ProvinceId")]
        [DisplayName("District")]
        public String DistrictDname { get; set; }
        public String Cluster { get; set; }
        public DateTime DateOfCampaign { get; set; }
        [EditLink]
        public String PemtremtManager { get; set; }
        public String TeamNo { get; set; }
        public Int32 D1VialsRecieved { get; set; }
        public Int32 D1VialsReturned { get; set; }
        public Int32 D1VaccByTransit { get; set; }
        public Int32 D1NoOfHhsVisited { get; set; }
        public Int32 D1Ch05resident { get; set; }
        public Int32 D1Ch05guest { get; set; }
        public Int32 D1Ch05VaccInHouse { get; set; }
        public Int32 D1Ch05VaccOutHouse { get; set; }
        public Int32 D1Ch05NomadVacc { get; set; }
        public Int32 D1AbsentRecordDuring { get; set; }
        public Int32 D1AbsentFoundVaccDuring { get; set; }
        public Int32 D1AbsentVaccDuring { get; set; }
        public Int32 D1AbsentRemainDuring { get; set; }
        public Int32 D1AbsentRecordAfter { get; set; }
        public Int32 D1AbsentFoundVaccAfter { get; set; }
        public Int32 D1AbsentVaccAfter { get; set; }
        public Int32 D1AbsentRemainAfter { get; set; }
        public Int32 D1NssRecord { get; set; }
        public Int32 D1NssFoundVacc { get; set; }
        public Int32 D1NssVaccinated { get; set; }
        public Int32 D1NssReamining { get; set; }
        public Int32 D1RefusalRecord { get; set; }
        public Int32 D1RefusalFoundVacc { get; set; }
        public Int32 D1RefusalVacc { get; set; }
        public Int32 D1RefusalRemaining { get; set; }
        public Int32 D2VialsRecieved { get; set; }
        public Int32 D2VialsReturned { get; set; }
        public Int32 D2VaccByTransit { get; set; }
        public Int32 D2NoOfHhsVisited { get; set; }
        public Int32 D2Ch05resident { get; set; }
        public Int32 D2Ch05guest { get; set; }
        public Int32 D2Ch05VaccInHouse { get; set; }
        public Int32 D2Ch05VaccOutHouse { get; set; }
        public Int32 D2Ch05NomadVacc { get; set; }
        public Int32 D2AbsentRecordDuring { get; set; }
        public Int32 D2AbsentFoundVaccDuring { get; set; }
        public Int32 D2AbsentVaccDuring { get; set; }
        public Int32 D2AbsentRemainDuring { get; set; }
        public Int32 D2AbsentRecordAfter { get; set; }
        public Int32 D2AbsentFoundVaccAfter { get; set; }
        public Int32 D2AbsentVaccAfter { get; set; }
        public Int32 D2AbsentRemainAfter { get; set; }
        public Int32 D2NssRecord { get; set; }
        public Int32 D2NssFoundVacc { get; set; }
        public Int32 D2NssVaccinated { get; set; }
        public Int32 D2NssReamining { get; set; }
        public Int32 D2RefusalRecord { get; set; }
        public Int32 D2RefusalFoundVacc { get; set; }
        public Int32 D2RefusalVacc { get; set; }
        public Int32 D2RefusalRemaining { get; set; }
        public Int32 D3VialsRecieved { get; set; }
        public Int32 D3VialsReturned { get; set; }
        public Int32 D3VaccByTransit { get; set; }
        public Int32 D3NoOfHhsVisited { get; set; }
        public Int32 D3Ch05resident { get; set; }
        public Int32 D3Ch05guest { get; set; }
        public Int32 D3Ch05VaccInHouse { get; set; }
        public Int32 D3Ch05VaccOutHouse { get; set; }
        public Int32 D3Ch05NomadVacc { get; set; }
        public Int32 D3AbsentRecordDuring { get; set; }
        public Int32 D3AbsentFoundVaccDuring { get; set; }
        public Int32 D3AbsentVaccDuring { get; set; }
        public Int32 D3AbsentRemainDuring { get; set; }
        public Int32 D3AbsentRecordAfter { get; set; }
        public Int32 D3AbsentFoundVaccAfter { get; set; }
        public Int32 D3AbsentVaccAfter { get; set; }
        public Int32 D3AbsentRemainAfter { get; set; }
        public Int32 D3NssRecord { get; set; }
        public Int32 D3NssFoundVacc { get; set; }
        public Int32 D3NssVaccinated { get; set; }
        public Int32 D3NssReamining { get; set; }
        public Int32 D3RefusalRecord { get; set; }
        public Int32 D3RefusalFoundVacc { get; set; }
        public Int32 D3RefusalVacc { get; set; }
        public Int32 D3RefusalRemaining { get; set; }
        public Int32 D5VialsRecieved { get; set; }
        public Int32 D5VialsReturned { get; set; }
        public Int32 D5RemainAbsentDuring { get; set; }
        public Int32 D5AbsentFoundVaccDuring5 { get; set; }
        public Int32 D5AbsentVaccDuring5 { get; set; }
        public Int32 D5AbsentRemainDuring5 { get; set; }
        public Int32 D5RemainAbsentAfter { get; set; }
        public Int32 D5AbsentFoundVaccAfter5 { get; set; }
        public Int32 D5AbsentVaccAfter5 { get; set; }
        public Int32 D5AbsentRemainAfter5 { get; set; }
        public Int32 D5RemainNss { get; set; }
        public Int32 D5FoundVaccNss5 { get; set; }
        public Int32 D5VaccNss5 { get; set; }
        public Int32 D5RemainNss5 { get; set; }
        public Int32 D5RemainRefusal { get; set; }
        public Int32 D5FoundVaccRefusal5 { get; set; }
        public Int32 D5VaccRefusal5 { get; set; }
        public Int32 D5RemainRefusal5 { get; set; }
        public Int32 D5VaccOutofHouse { get; set; }
    }
}