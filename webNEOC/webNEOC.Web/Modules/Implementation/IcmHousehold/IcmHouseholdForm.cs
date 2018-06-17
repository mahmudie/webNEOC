
namespace webNEOC.Implementation.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Implementation.IcmHousehold")]
    [BasedOnRow(typeof(Entities.IcmHouseholdRow))]
    public class IcmHouseholdForm
    {
        [Category("General")]
        public Int16 RoundId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [LookupEditor(typeof(Locations.Entities.ProvinceRow)), DisplayName("Province")]
        public Int16 ProvinceId { get; set; }

        [LookupEditor(typeof(Locations.Entities.DistrictRow), CascadeFrom = "ProvinceId", CascadeField = "ProvinceId")]
        public Int32 DistrictId { get; set; }
        public Int16 PartId { get; set; }

        [LookupEditor(typeof(Locations.Entities.ClusterRow), CascadeFrom = "DistrictId", CascadeField = "DistrictId")]
        public Int32 ClusterId { get; set; }
        public DateTime ReportDate { get; set; }
        public String Village { get; set; }
        public String Supervisor { get; set; }


        [Category("Household record")]
        public Int16 NoHhVisited { get; set; }
        public Int16 NoChildrenInVisitedHh { get; set; }
        public Int16 NoVaccInRecall { get; set; }

        [Category("Reason for missing")]
        public Int16 MissedChildren { get; set; }
        public Int16 TeamNotCome { get; set; }
        public Int16 ChildrenAbsent { get; set; }
        public Int16 NewbornSsChildren { get; set; }
        public Int16 NoRefused { get; set; }
        public Int16 NoIgnoredbyTeam { get; set; }

        [Category("Finger Mark")]
        public Int16 TotUn5SeenByMonit { get; set; }
        public Int16 NoSeenWithFingerMark { get; set; }
        [Category("Door Mark")]
        public Int16 NoCorrect { get; set; }
        public Int16 NoIncorrect { get; set; }
        public Int16 NoNotMarked { get; set; }

        [Category("Not vaccinated")]
        public Int16 NoChildFoundMissedRecall { get; set; }
        public Int16 NoChildRecBackOfTally { get; set; }
    }
}