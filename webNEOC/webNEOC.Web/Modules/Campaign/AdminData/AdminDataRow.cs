
namespace webNEOC.Campaign.Entities
{
    using MultiTenancy;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;
    using webNEOC.Modules.Campaign;

    [ConnectionKey("Default"), TableName("[dbo].[AdminData]")]
    [DisplayName("Admin Data"), InstanceName("Admin Data"), TwoLevelCached]
    [ReadPermission(CampaignPermissionKeys.AdminData.View)]
    [ModifyPermission(CampaignPermissionKeys.AdminData.Update)]
    [InsertPermission(CampaignPermissionKeys.AdminData.Insert)]
    [DeletePermission(CampaignPermissionKeys.AdminData.Delete)]
    public sealed class AdminDataRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Admin Data Id"), Identity]
        public Int64? AdminDataId
        {
            get { return Fields.AdminDataId[this]; }
            set { Fields.AdminDataId[this] = value; }
        }

        [DisplayName("Round Id"), NotNull, ForeignKey("[dbo].[Round]", "RoundId"), LeftJoin("jRound")]
        public Int16? RoundId
        {
            get { return Fields.RoundId[this]; }
            set { Fields.RoundId[this] = value; }
        }

        [DisplayName("District"), NotNull, ForeignKey("[dbo].[District]", "DistrictId"), LeftJoin("jDistrict"),LookupInclude]
        public Int16? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("Cluster Id"), NotNull, ForeignKey("[dbo].[Cluster]", "ClusterId"), LeftJoin("jCluster")]
        public Int64? ClusterId
        {
            get { return Fields.ClusterId[this]; }
            set { Fields.ClusterId[this] = value; }
        }

        [DisplayName("Date Of Campaign")]
        public DateTime? DateOfCampaign
        {
            get { return Fields.DateOfCampaign[this]; }
            set { Fields.DateOfCampaign[this] = value; }
        }

        [DisplayName("Pemtremt Manager"), Column("PEMTREMTManager"), Size(255), NotNull, QuickSearch]
        public String PemtremtManager
        {
            get { return Fields.PemtremtManager[this]; }
            set { Fields.PemtremtManager[this] = value; }
        }

        [DisplayName("Team No"), Size(50)]
        public String TeamNo
        {
            get { return Fields.TeamNo[this]; }
            set { Fields.TeamNo[this] = value; }
        }

        [DisplayName("D1-No of Full vials received "), Column("d1VialsRecieved"), NotNull]
        public Int32? D1VialsRecieved
        {
            get { return Fields.D1VialsRecieved[this]; }
            set { Fields.D1VialsRecieved[this] = value; }
        }

        [DisplayName("D1-No of Full vials returned  "), Column("d1VialsReturned"), NotNull]
        public Int32? D1VialsReturned
        {
            get { return Fields.D1VialsReturned[this]; }
            set { Fields.D1VialsReturned[this] = value; }
        }

        [DisplayName("D1-# of childrn 0-5 yrs vac by Transit Teams"), Column("d1VaccByTransit"), NotNull]
        public Int32? D1VaccByTransit
        {
            get { return Fields.D1VaccByTransit[this]; }
            set { Fields.D1VaccByTransit[this] = value; }
        }

        [DisplayName("D1-# of houses visited"), Column("d1NoOfHHSVisited"), NotNull]
        public Int32? D1NoOfHhsVisited
        {
            get { return Fields.D1NoOfHhsVisited[this]; }
            set { Fields.D1NoOfHhsVisited[this] = value; }
        }

        [DisplayName("D1-# of child 0-5 yrs resident in house"), Column("d1Ch05resident"), NotNull]
        public Int32? D1Ch05resident
        {
            get { return Fields.D1Ch05resident[this]; }
            set { Fields.D1Ch05resident[this] = value; }
        }

        [DisplayName("D1-# of child 0-5 yrs guest in house"), Column("d1Ch05guest"), NotNull]
        public Int32? D1Ch05guest
        {
            get { return Fields.D1Ch05guest[this]; }
            set { Fields.D1Ch05guest[this] = value; }
        }

        [DisplayName("D1-# of children 0-5 yrs vac in houses"), Column("d1Ch05VaccInHouse"), NotNull]
        public Int32? D1Ch05VaccInHouse
        {
            get { return Fields.D1Ch05VaccInHouse[this]; }
            set { Fields.D1Ch05VaccInHouse[this] = value; }
        }

        [DisplayName("D1-# of children 0-5 yrs vac outside of houses"), Column("d1Ch05VaccOutHouse"), NotNull]
        public Int32? D1Ch05VaccOutHouse
        {
            get { return Fields.D1Ch05VaccOutHouse[this]; }
            set { Fields.D1Ch05VaccOutHouse[this] = value; }
        }

        [DisplayName("D1-# of nomad children 0-5 yrs vaccinated"), Column("d1Ch05NomadVacc"), NotNull]
        public Int32? D1Ch05NomadVacc
        {
            get { return Fields.D1Ch05NomadVacc[this]; }
            set { Fields.D1Ch05NomadVacc[this] = value; }
        }

        [DisplayName("D1-# of recorded absent"), Column("d1AbsentRecordDuring"), NotNull]
        public Int32? D1AbsentRecordDuring
        {
            get { return Fields.D1AbsentRecordDuring[this]; }
            set { Fields.D1AbsentRecordDuring[this] = value; }
        }

        [DisplayName("D1-# found vaccinated absent"), Column("d1AbsentFoundVaccDuring"), NotNull]
        public Int32? D1AbsentFoundVaccDuring
        {
            get { return Fields.D1AbsentFoundVaccDuring[this]; }
            set { Fields.D1AbsentFoundVaccDuring[this] = value; }
        }

        [DisplayName("D1-# vaccinated by team absent"), Column("d1AbsentVaccDuring"), NotNull]
        public Int32? D1AbsentVaccDuring
        {
            get { return Fields.D1AbsentVaccDuring[this]; }
            set { Fields.D1AbsentVaccDuring[this] = value; }
        }

        [DisplayName("D1-# of remaining  absent"), Column("d1AbsentRemainDuring"), NotNull]
        public Int32? D1AbsentRemainDuring
        {
            get { return Fields.D1AbsentRemainDuring[this]; }
            set { Fields.D1AbsentRemainDuring[this] = value; }
        }

        [DisplayName("D1-# of recorded absent"), Column("d1AbsentRecordAfter"), NotNull]
        public Int32? D1AbsentRecordAfter
        {
            get { return Fields.D1AbsentRecordAfter[this]; }
            set { Fields.D1AbsentRecordAfter[this] = value; }
        }

        [DisplayName("D1-# found vaccinated absent"), Column("d1AbsentFoundVaccAfter"), NotNull]
        public Int32? D1AbsentFoundVaccAfter
        {
            get { return Fields.D1AbsentFoundVaccAfter[this]; }
            set { Fields.D1AbsentFoundVaccAfter[this] = value; }
        }

        [DisplayName("D1-# vaccinated by team absent"), Column("d1AbsentVaccAfter"), NotNull]
        public Int32? D1AbsentVaccAfter
        {
            get { return Fields.D1AbsentVaccAfter[this]; }
            set { Fields.D1AbsentVaccAfter[this] = value; }
        }

        [DisplayName("D1-# remaining absent"), Column("d1AbsentRemainAfter"), NotNull]
        public Int32? D1AbsentRemainAfter
        {
            get { return Fields.D1AbsentRemainAfter[this]; }
            set { Fields.D1AbsentRemainAfter[this] = value; }
        }

        [DisplayName("D1-# of recorded NSS"), Column("d1NSSRecord"), NotNull]
        public Int32? D1NssRecord
        {
            get { return Fields.D1NssRecord[this]; }
            set { Fields.D1NssRecord[this] = value; }
        }

        [DisplayName("D1-# found vaccinated NSS"), Column("d1NSSFoundVacc"), NotNull]
        public Int32? D1NssFoundVacc
        {
            get { return Fields.D1NssFoundVacc[this]; }
            set { Fields.D1NssFoundVacc[this] = value; }
        }

        [DisplayName("D1-# vaccinated by team NSS"), Column("d1NSSVaccinated"), NotNull]
        public Int32? D1NssVaccinated
        {
            get { return Fields.D1NssVaccinated[this]; }
            set { Fields.D1NssVaccinated[this] = value; }
        }

        [DisplayName("D1-# of remaining NSS"), Column("d1NSSReamining"), NotNull]
        public Int32? D1NssReamining
        {
            get { return Fields.D1NssReamining[this]; }
            set { Fields.D1NssReamining[this] = value; }
        }

        [DisplayName("D1-# of recorded refusal"), Column("d1RefusalRecord"), NotNull]
        public Int32? D1RefusalRecord
        {
            get { return Fields.D1RefusalRecord[this]; }
            set { Fields.D1RefusalRecord[this] = value; }
        }

        [DisplayName("D1-# found vaccinated refusal"), Column("d1RefusalFoundVacc"), NotNull]
        public Int32? D1RefusalFoundVacc
        {
            get { return Fields.D1RefusalFoundVacc[this]; }
            set { Fields.D1RefusalFoundVacc[this] = value; }
        }

        [DisplayName("D1-# vaccinated by team refusal"), Column("d1RefusalVacc"), NotNull]
        public Int32? D1RefusalVacc
        {
            get { return Fields.D1RefusalVacc[this]; }
            set { Fields.D1RefusalVacc[this] = value; }
        }

        [DisplayName("D1-# of remaining refusal "), Column("d1RefusalRemaining"), NotNull]
        public Int32? D1RefusalRemaining
        {
            get { return Fields.D1RefusalRemaining[this]; }
            set { Fields.D1RefusalRemaining[this] = value; }
        }

        [DisplayName("D2-No of Full vials received"), Column("d2VialsRecieved"), NotNull]
        public Int32? D2VialsRecieved
        {
            get { return Fields.D2VialsRecieved[this]; }
            set { Fields.D2VialsRecieved[this] = value; }
        }

        [DisplayName("D2-No of Full vials returned"), Column("d2VialsReturned"), NotNull]
        public Int32? D2VialsReturned
        {
            get { return Fields.D2VialsReturned[this]; }
            set { Fields.D2VialsReturned[this] = value; }
        }

        [DisplayName("D2-# of children 0-5 years vacc by Transit Teams"), Column("d2VaccByTransit"), NotNull]
        public Int32? D2VaccByTransit
        {
            get { return Fields.D2VaccByTransit[this]; }
            set { Fields.D2VaccByTransit[this] = value; }
        }

        [DisplayName("D2-# of houses visited"), Column("d2NoOfHHSVisited"), NotNull]
        public Int32? D2NoOfHhsVisited
        {
            get { return Fields.D2NoOfHhsVisited[this]; }
            set { Fields.D2NoOfHhsVisited[this] = value; }
        }

        [DisplayName("D2-# of children 0-5 yrs resident in the house"), Column("d2Ch05resident"), NotNull]
        public Int32? D2Ch05resident
        {
            get { return Fields.D2Ch05resident[this]; }
            set { Fields.D2Ch05resident[this] = value; }
        }

        [DisplayName("D2-# of children 0-5 yrs guest in the house"), Column("d2Ch05guest"), NotNull]
        public Int32? D2Ch05guest
        {
            get { return Fields.D2Ch05guest[this]; }
            set { Fields.D2Ch05guest[this] = value; }
        }

        [DisplayName("D2-# of children 0-5 yrs vacc in houses"), Column("d2Ch05VaccInHouse"), NotNull]
        public Int32? D2Ch05VaccInHouse
        {
            get { return Fields.D2Ch05VaccInHouse[this]; }
            set { Fields.D2Ch05VaccInHouse[this] = value; }
        }

        [DisplayName("D2-# of children 0-5 yrs vacc outside of houses"), Column("d2Ch05VaccOutHouse"), NotNull]
        public Int32? D2Ch05VaccOutHouse
        {
            get { return Fields.D2Ch05VaccOutHouse[this]; }
            set { Fields.D2Ch05VaccOutHouse[this] = value; }
        }

        [DisplayName("D2-# of nomad children 0-5 yrs vaccinated"), Column("d2Ch05NomadVacc"), NotNull]
        public Int32? D2Ch05NomadVacc
        {
            get { return Fields.D2Ch05NomadVacc[this]; }
            set { Fields.D2Ch05NomadVacc[this] = value; }
        }

        [DisplayName("D2-# of recorded absent"), Column("d2AbsentRecordDuring"), NotNull]
        public Int32? D2AbsentRecordDuring
        {
            get { return Fields.D2AbsentRecordDuring[this]; }
            set { Fields.D2AbsentRecordDuring[this] = value; }
        }

        [DisplayName("D2-# found vaccined absent"), Column("d2AbsentFoundVaccDuring"), NotNull]
        public Int32? D2AbsentFoundVaccDuring
        {
            get { return Fields.D2AbsentFoundVaccDuring[this]; }
            set { Fields.D2AbsentFoundVaccDuring[this] = value; }
        }

        [DisplayName("D2-# vaccinated absent by team"), Column("d2AbsentVaccDuring"), NotNull]
        public Int32? D2AbsentVaccDuring
        {
            get { return Fields.D2AbsentVaccDuring[this]; }
            set { Fields.D2AbsentVaccDuring[this] = value; }
        }

        [DisplayName("D2-# of remaining absent"), Column("d2AbsentRemainDuring"), NotNull]
        public Int32? D2AbsentRemainDuring
        {
            get { return Fields.D2AbsentRemainDuring[this]; }
            set { Fields.D2AbsentRemainDuring[this] = value; }
        }

        [DisplayName("D2-# of recorded absent"), Column("d2AbsentRecordAfter"), NotNull]
        public Int32? D2AbsentRecordAfter
        {
            get { return Fields.D2AbsentRecordAfter[this]; }
            set { Fields.D2AbsentRecordAfter[this] = value; }
        }

        [DisplayName("D2-# found vaccinated absent"), Column("d2AbsentFoundVaccAfter"), NotNull]
        public Int32? D2AbsentFoundVaccAfter
        {
            get { return Fields.D2AbsentFoundVaccAfter[this]; }
            set { Fields.D2AbsentFoundVaccAfter[this] = value; }
        }

        [DisplayName("D2-# vaccinated by team absent"), Column("d2AbsentVaccAfter"), NotNull]
        public Int32? D2AbsentVaccAfter
        {
            get { return Fields.D2AbsentVaccAfter[this]; }
            set { Fields.D2AbsentVaccAfter[this] = value; }
        }

        [DisplayName("D2-# remaining absent"), Column("d2AbsentRemainAfter"), NotNull]
        public Int32? D2AbsentRemainAfter
        {
            get { return Fields.D2AbsentRemainAfter[this]; }
            set { Fields.D2AbsentRemainAfter[this] = value; }
        }

        [DisplayName("D2-# of recorded NSS"), Column("d2NSSRecord"), NotNull]
        public Int32? D2NssRecord
        {
            get { return Fields.D2NssRecord[this]; }
            set { Fields.D2NssRecord[this] = value; }
        }

        [DisplayName("D2-# found vaccinated NSS"), Column("d2NSSFoundVacc"), NotNull]
        public Int32? D2NssFoundVacc
        {
            get { return Fields.D2NssFoundVacc[this]; }
            set { Fields.D2NssFoundVacc[this] = value; }
        }

        [DisplayName("D2-# vaccinated by team NSS"), Column("d2NSSVaccinated"), NotNull]
        public Int32? D2NssVaccinated
        {
            get { return Fields.D2NssVaccinated[this]; }
            set { Fields.D2NssVaccinated[this] = value; }
        }

        [DisplayName("D2-# of remaining NSS"), Column("d2NSSReamining"), NotNull]
        public Int32? D2NssReamining
        {
            get { return Fields.D2NssReamining[this]; }
            set { Fields.D2NssReamining[this] = value; }
        }

        [DisplayName("D2-# of recorded refusal"), Column("d2RefusalRecord"), NotNull]
        public Int32? D2RefusalRecord
        {
            get { return Fields.D2RefusalRecord[this]; }
            set { Fields.D2RefusalRecord[this] = value; }
        }

        [DisplayName("D2-# found vaccinated refusal"), Column("d2RefusalFoundVacc"), NotNull]
        public Int32? D2RefusalFoundVacc
        {
            get { return Fields.D2RefusalFoundVacc[this]; }
            set { Fields.D2RefusalFoundVacc[this] = value; }
        }

        [DisplayName("D2-# vaccinated by team refusal"), Column("d2RefusalVacc"), NotNull]
        public Int32? D2RefusalVacc
        {
            get { return Fields.D2RefusalVacc[this]; }
            set { Fields.D2RefusalVacc[this] = value; }
        }

        [DisplayName("D2-# of remaining refusal "), Column("d2RefusalRemaining"), NotNull]
        public Int32? D2RefusalRemaining
        {
            get { return Fields.D2RefusalRemaining[this]; }
            set { Fields.D2RefusalRemaining[this] = value; }
        }

        [DisplayName("D3-No of Full vials received"), Column("d3VialsRecieved"), NotNull]
        public Int32? D3VialsRecieved
        {
            get { return Fields.D3VialsRecieved[this]; }
            set { Fields.D3VialsRecieved[this] = value; }
        }

        [DisplayName("D3-No of Full vials returned"), Column("d3VialsReturned"), NotNull]
        public Int32? D3VialsReturned
        {
            get { return Fields.D3VialsReturned[this]; }
            set { Fields.D3VialsReturned[this] = value; }
        }

        [DisplayName("D3-# of children 0-5 yrs vacc by Transit Teams"), Column("d3VaccByTransit"), NotNull]
        public Int32? D3VaccByTransit
        {
            get { return Fields.D3VaccByTransit[this]; }
            set { Fields.D3VaccByTransit[this] = value; }
        }

        [DisplayName("D3-# of houses visited"), Column("d3NoOfHHSVisited"), NotNull]
        public Int32? D3NoOfHhsVisited
        {
            get { return Fields.D3NoOfHhsVisited[this]; }
            set { Fields.D3NoOfHhsVisited[this] = value; }
        }

        [DisplayName("D3-# of children 0-5 yrs resident in the house"), Column("d3Ch05resident"), NotNull]
        public Int32? D3Ch05resident
        {
            get { return Fields.D3Ch05resident[this]; }
            set { Fields.D3Ch05resident[this] = value; }
        }

        [DisplayName("D3-# of children 0-5 yrs guest in the house"), Column("d3Ch05guest"), NotNull]
        public Int32? D3Ch05guest
        {
            get { return Fields.D3Ch05guest[this]; }
            set { Fields.D3Ch05guest[this] = value; }
        }

        [DisplayName("D3-# of children 0-5 yrs vaccinated in houses"), Column("d3Ch05VaccInHouse"), NotNull]
        public Int32? D3Ch05VaccInHouse
        {
            get { return Fields.D3Ch05VaccInHouse[this]; }
            set { Fields.D3Ch05VaccInHouse[this] = value; }
        }

        [DisplayName("D3-# of children 0-5 yrs vacc outside of houses"), Column("d3Ch05VaccOutHouse"), NotNull]
        public Int32? D3Ch05VaccOutHouse
        {
            get { return Fields.D3Ch05VaccOutHouse[this]; }
            set { Fields.D3Ch05VaccOutHouse[this] = value; }
        }

        [DisplayName("D3-# of nomad children 0-5 yrs vaccinated"), Column("d3Ch05NomadVacc"), NotNull]
        public Int32? D3Ch05NomadVacc
        {
            get { return Fields.D3Ch05NomadVacc[this]; }
            set { Fields.D3Ch05NomadVacc[this] = value; }
        }

        [DisplayName("D3-# of recorded absent"), Column("d3AbsentRecordDuring"), NotNull]
        public Int32? D3AbsentRecordDuring
        {
            get { return Fields.D3AbsentRecordDuring[this]; }
            set { Fields.D3AbsentRecordDuring[this] = value; }
        }

        [DisplayName("D3-# found vaccined absent"), Column("d3AbsentFoundVaccDuring"), NotNull]
        public Int32? D3AbsentFoundVaccDuring
        {
            get { return Fields.D3AbsentFoundVaccDuring[this]; }
            set { Fields.D3AbsentFoundVaccDuring[this] = value; }
        }

        [DisplayName("D3-# vaccinated absent by team"), Column("d3AbsentVaccDuring"), NotNull]
        public Int32? D3AbsentVaccDuring
        {
            get { return Fields.D3AbsentVaccDuring[this]; }
            set { Fields.D3AbsentVaccDuring[this] = value; }
        }

        [DisplayName("D3-# of remaining absent"), Column("d3AbsentRemainDuring"), NotNull]
        public Int32? D3AbsentRemainDuring
        {
            get { return Fields.D3AbsentRemainDuring[this]; }
            set { Fields.D3AbsentRemainDuring[this] = value; }
        }

        [DisplayName("D3-# of recorded absent"), Column("d3AbsentRecordAfter"), NotNull]
        public Int32? D3AbsentRecordAfter
        {
            get { return Fields.D3AbsentRecordAfter[this]; }
            set { Fields.D3AbsentRecordAfter[this] = value; }
        }

        [DisplayName("D3-# found vaccinated absent"), Column("d3AbsentFoundVaccAfter"), NotNull]
        public Int32? D3AbsentFoundVaccAfter
        {
            get { return Fields.D3AbsentFoundVaccAfter[this]; }
            set { Fields.D3AbsentFoundVaccAfter[this] = value; }
        }

        [DisplayName("D3-# vaccinated by team"), Column("d3AbsentVaccAfter"), NotNull]
        public Int32? D3AbsentVaccAfter
        {
            get { return Fields.D3AbsentVaccAfter[this]; }
            set { Fields.D3AbsentVaccAfter[this] = value; }
        }

        [DisplayName("D3-# of remaining absent"), Column("d3AbsentRemainAfter"), NotNull]
        public Int32? D3AbsentRemainAfter
        {
            get { return Fields.D3AbsentRemainAfter[this]; }
            set { Fields.D3AbsentRemainAfter[this] = value; }
        }

        [DisplayName("D3-# of recorded NSS"), Column("d3NSSRecord"), NotNull]
        public Int32? D3NssRecord
        {
            get { return Fields.D3NssRecord[this]; }
            set { Fields.D3NssRecord[this] = value; }
        }

        [DisplayName("D3-# found vaccinated NSS"), Column("d3NSSFoundVacc"), NotNull]
        public Int32? D3NssFoundVacc
        {
            get { return Fields.D3NssFoundVacc[this]; }
            set { Fields.D3NssFoundVacc[this] = value; }
        }

        [DisplayName("D3-# vaccinated by team NSS"), Column("d3NSSVaccinated"), NotNull]
        public Int32? D3NssVaccinated
        {
            get { return Fields.D3NssVaccinated[this]; }
            set { Fields.D3NssVaccinated[this] = value; }
        }

        [DisplayName("D3-# of remaining NSS"), Column("d3NSSReamining"), NotNull]
        public Int32? D3NssReamining
        {
            get { return Fields.D3NssReamining[this]; }
            set { Fields.D3NssReamining[this] = value; }
        }

        [DisplayName("D3-# of recorded refusal"), Column("d3RefusalRecord"), NotNull]
        public Int32? D3RefusalRecord
        {
            get { return Fields.D3RefusalRecord[this]; }
            set { Fields.D3RefusalRecord[this] = value; }
        }

        [DisplayName("D3-# found vaccinated refusal"), Column("d3RefusalFoundVacc"), NotNull]
        public Int32? D3RefusalFoundVacc
        {
            get { return Fields.D3RefusalFoundVacc[this]; }
            set { Fields.D3RefusalFoundVacc[this] = value; }
        }

        [DisplayName("D3-# vaccinated by team refusal"), Column("d3RefusalVacc"), NotNull]
        public Int32? D3RefusalVacc
        {
            get { return Fields.D3RefusalVacc[this]; }
            set { Fields.D3RefusalVacc[this] = value; }
        }

        [DisplayName("D3-# of remaining refusal "), Column("d3RefusalRemaining"), NotNull]
        public Int32? D3RefusalRemaining
        {
            get { return Fields.D3RefusalRemaining[this]; }
            set { Fields.D3RefusalRemaining[this] = value; }
        }

        [DisplayName("D5-No of Full vials received "), Column("d5VialsRecieved"), NotNull]
        public Int32? D5VialsRecieved
        {
            get { return Fields.D5VialsRecieved[this]; }
            set { Fields.D5VialsRecieved[this] = value; }
        }

        [DisplayName("D5-No of Full vials returned  "), Column("d5VialsReturned"), NotNull]
        public Int32? D5VialsReturned
        {
            get { return Fields.D5VialsReturned[this]; }
            set { Fields.D5VialsReturned[this] = value; }
        }

        [DisplayName("D5-# of recorded absent from day 1-3"), Column("d5RemainAbsentDuring"), NotNull]
        public Int32? D5RemainAbsentDuring
        {
            get { return Fields.D5RemainAbsentDuring[this]; }
            set { Fields.D5RemainAbsentDuring[this] = value; }
        }

        [DisplayName("D5-# found vaccined absent (day 5)"), Column("d5AbsentFoundVaccDuring5"), NotNull]
        public Int32? D5AbsentFoundVaccDuring5
        {
            get { return Fields.D5AbsentFoundVaccDuring5[this]; }
            set { Fields.D5AbsentFoundVaccDuring5[this] = value; }
        }

        [DisplayName("D5-# vaccinated absent by team (day 5)"), Column("d5AbsentVaccDuring5"), NotNull]
        public Int32? D5AbsentVaccDuring5
        {
            get { return Fields.D5AbsentVaccDuring5[this]; }
            set { Fields.D5AbsentVaccDuring5[this] = value; }
        }

        [DisplayName("D5-# of remaining absent (day 5)"), Column("d5AbsentRemainDuring5"), NotNull]
        public Int32? D5AbsentRemainDuring5
        {
            get { return Fields.D5AbsentRemainDuring5[this]; }
            set { Fields.D5AbsentRemainDuring5[this] = value; }
        }

        [DisplayName("D5-# of recorded absent (day 1-3)"), Column("d5RemainAbsentAfter"), NotNull]
        public Int32? D5RemainAbsentAfter
        {
            get { return Fields.D5RemainAbsentAfter[this]; }
            set { Fields.D5RemainAbsentAfter[this] = value; }
        }

        [DisplayName("D5-# found vaccinated absent (day 5)"), Column("d5AbsentFoundVaccAfter5"), NotNull]
        public Int32? D5AbsentFoundVaccAfter5
        {
            get { return Fields.D5AbsentFoundVaccAfter5[this]; }
            set { Fields.D5AbsentFoundVaccAfter5[this] = value; }
        }

        [DisplayName("D5-# vaccinated by team (day 5)"), Column("d5AbsentVaccAfter5"), NotNull]
        public Int32? D5AbsentVaccAfter5
        {
            get { return Fields.D5AbsentVaccAfter5[this]; }
            set { Fields.D5AbsentVaccAfter5[this] = value; }
        }

        [DisplayName("D5-# of remaining absent (daya 5)"), Column("d5AbsentRemainAfter5"), NotNull]
        public Int32? D5AbsentRemainAfter5
        {
            get { return Fields.D5AbsentRemainAfter5[this]; }
            set { Fields.D5AbsentRemainAfter5[this] = value; }
        }

        [DisplayName("D5-# of recorded NSS (day 1-3)"), Column("d5RemainNSS"), NotNull]
        public Int32? D5RemainNss
        {
            get { return Fields.D5RemainNss[this]; }
            set { Fields.D5RemainNss[this] = value; }
        }

        [DisplayName("D5-# found vaccinated NSS (day 5)"), Column("d5FoundVaccNSS5"), NotNull]
        public Int32? D5FoundVaccNss5
        {
            get { return Fields.D5FoundVaccNss5[this]; }
            set { Fields.D5FoundVaccNss5[this] = value; }
        }

        [DisplayName("D5-# vaccinated by team NSS (day 5)"), Column("d5VaccNSS5"), NotNull]
        public Int32? D5VaccNss5
        {
            get { return Fields.D5VaccNss5[this]; }
            set { Fields.D5VaccNss5[this] = value; }
        }

        [DisplayName("D5-# of remaining NSS (day 5)"), Column("d5RemainNSS5"), NotNull]
        public Int32? D5RemainNss5
        {
            get { return Fields.D5RemainNss5[this]; }
            set { Fields.D5RemainNss5[this] = value; }
        }

        [DisplayName("D5-# of recorded refusal (day 1-3)"), Column("d5RemainRefusal"), NotNull]
        public Int32? D5RemainRefusal
        {
            get { return Fields.D5RemainRefusal[this]; }
            set { Fields.D5RemainRefusal[this] = value; }
        }

        [DisplayName("D5-# found vaccinated refusal (day 5)"), Column("d5FoundVaccRefusal5"), NotNull]
        public Int32? D5FoundVaccRefusal5
        {
            get { return Fields.D5FoundVaccRefusal5[this]; }
            set { Fields.D5FoundVaccRefusal5[this] = value; }
        }

        [DisplayName("D5-# vaccinated by team refusal (day 5)"), Column("d5VaccRefusal5"), NotNull]
        public Int32? D5VaccRefusal5
        {
            get { return Fields.D5VaccRefusal5[this]; }
            set { Fields.D5VaccRefusal5[this] = value; }
        }

        [DisplayName("D5-# of remaining refusal (day 5)"), Column("d5RemainRefusal5"), NotNull]
        public Int32? D5RemainRefusal5
        {
            get { return Fields.D5RemainRefusal5[this]; }
            set { Fields.D5RemainRefusal5[this] = value; }
        }

        [DisplayName("D5-# of children vacc outside of houses"), Column("d5VaccOutofHouse"), NotNull]
        public Int32? D5VaccOutofHouse
        {
            get { return Fields.D5VaccOutofHouse[this]; }
            set { Fields.D5VaccOutofHouse[this] = value; }
        }

        [DisplayName("District Dcode"), Expression("jDistrict.[Dcode]")]
        public String DistrictDcode
        {
            get { return Fields.DistrictDcode[this]; }
            set { Fields.DistrictDcode[this] = value; }
        }

        [DisplayName("Province Id"), Expression("jDistrict.[ProvinceId]")]
        public Int16? DistrictProvinceId
        {
            get { return Fields.DistrictProvinceId[this]; }
            set { Fields.DistrictProvinceId[this] = value; }
        }

        [DisplayName("Round"), Expression("jRound.[RoundName]")]
        public String Round
        {
            get { return Fields.Round[this]; }
            set { Fields.Round[this] = value; }
        }

        [DisplayName("Cluster Name"), Expression("jCluster.[Cname]")]
        public String Cluster
        {
            get { return Fields.Cluster[this]; }
            set { Fields.Cluster[this] = value; }
        }

        [DisplayName("District"), Expression("jDistrict.[Dname]")]
        public String DistrictDname
        {
            get { return Fields.DistrictDname[this]; }
            set { Fields.DistrictDname[this] = value; }
        }

        [Expression("jDistrict.[ProvinceId]"), ForeignKey("Province", "ProvinceId"), LeftJoin("r"), QuickSearch]
        public Int16? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [Expression("r.[Pname]"),LookupInclude]
        public string Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }

        [Expression("(jRound.RoundName + ' (cluster = ' + jCluster.Cname +')')")]
        public string UniqueId
        {
            get { return Fields.UniqueId[this]; }
            set { Fields.UniqueId[this] = value; }
        }

        [DisplayName("Approved By"), NotNull]
        public Int32? ApprovedBy
        {
            get { return Fields.ApprovedBy[this]; }
            set { Fields.ApprovedBy[this] = value; }
        }

        [DisplayName("Approved"), NotNull]
        public Boolean? Approved
        {
            get { return Fields.Approved[this]; }
            set { Fields.Approved[this] = value; }
        }

        [DisplayName("Approval Date"), NotNull]
        public DateTime? ApprovalDate
        {
            get { return Fields.ApprovalDate[this]; }
            set { Fields.ApprovalDate[this] = value; }
        }

        [Insertable(true), Updatable(true)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }
        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.AdminDataId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Cluster; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AdminDataRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field AdminDataId;
            public Int16Field RoundId;
            public Int16Field DistrictId;
            public Int64Field ClusterId;
            public DateTimeField DateOfCampaign;
            public StringField PemtremtManager;
            public StringField TeamNo;
            public Int32Field D1VialsRecieved;
            public Int32Field D1VialsReturned;
            public Int32Field D1VaccByTransit;
            public Int32Field D1NoOfHhsVisited;
            public Int32Field D1Ch05resident;
            public Int32Field D1Ch05guest;
            public Int32Field D1Ch05VaccInHouse;
            public Int32Field D1Ch05VaccOutHouse;
            public Int32Field D1Ch05NomadVacc;
            public Int32Field D1AbsentRecordDuring;
            public Int32Field D1AbsentFoundVaccDuring;
            public Int32Field D1AbsentVaccDuring;
            public Int32Field D1AbsentRemainDuring;
            public Int32Field D1AbsentRecordAfter;
            public Int32Field D1AbsentFoundVaccAfter;
            public Int32Field D1AbsentVaccAfter;
            public Int32Field D1AbsentRemainAfter;
            public Int32Field D1NssRecord;
            public Int32Field D1NssFoundVacc;
            public Int32Field D1NssVaccinated;
            public Int32Field D1NssReamining;
            public Int32Field D1RefusalRecord;
            public Int32Field D1RefusalFoundVacc;
            public Int32Field D1RefusalVacc;
            public Int32Field D1RefusalRemaining;
            public Int32Field D2VialsRecieved;
            public Int32Field D2VialsReturned;
            public Int32Field D2VaccByTransit;
            public Int32Field D2NoOfHhsVisited;
            public Int32Field D2Ch05resident;
            public Int32Field D2Ch05guest;
            public Int32Field D2Ch05VaccInHouse;
            public Int32Field D2Ch05VaccOutHouse;
            public Int32Field D2Ch05NomadVacc;
            public Int32Field D2AbsentRecordDuring;
            public Int32Field D2AbsentFoundVaccDuring;
            public Int32Field D2AbsentVaccDuring;
            public Int32Field D2AbsentRemainDuring;
            public Int32Field D2AbsentRecordAfter;
            public Int32Field D2AbsentFoundVaccAfter;
            public Int32Field D2AbsentVaccAfter;
            public Int32Field D2AbsentRemainAfter;
            public Int32Field D2NssRecord;
            public Int32Field D2NssFoundVacc;
            public Int32Field D2NssVaccinated;
            public Int32Field D2NssReamining;
            public Int32Field D2RefusalRecord;
            public Int32Field D2RefusalFoundVacc;
            public Int32Field D2RefusalVacc;
            public Int32Field D2RefusalRemaining;
            public Int32Field D3VialsRecieved;
            public Int32Field D3VialsReturned;
            public Int32Field D3VaccByTransit;
            public Int32Field D3NoOfHhsVisited;
            public Int32Field D3Ch05resident;
            public Int32Field D3Ch05guest;
            public Int32Field D3Ch05VaccInHouse;
            public Int32Field D3Ch05VaccOutHouse;
            public Int32Field D3Ch05NomadVacc;
            public Int32Field D3AbsentRecordDuring;
            public Int32Field D3AbsentFoundVaccDuring;
            public Int32Field D3AbsentVaccDuring;
            public Int32Field D3AbsentRemainDuring;
            public Int32Field D3AbsentRecordAfter;
            public Int32Field D3AbsentFoundVaccAfter;
            public Int32Field D3AbsentVaccAfter;
            public Int32Field D3AbsentRemainAfter;
            public Int32Field D3NssRecord;
            public Int32Field D3NssFoundVacc;
            public Int32Field D3NssVaccinated;
            public Int32Field D3NssReamining;
            public Int32Field D3RefusalRecord;
            public Int32Field D3RefusalFoundVacc;
            public Int32Field D3RefusalVacc;
            public Int32Field D3RefusalRemaining;
            public Int32Field D5VialsRecieved;
            public Int32Field D5VialsReturned;
            public Int32Field D5RemainAbsentDuring;
            public Int32Field D5AbsentFoundVaccDuring5;
            public Int32Field D5AbsentVaccDuring5;
            public Int32Field D5AbsentRemainDuring5;
            public Int32Field D5RemainAbsentAfter;
            public Int32Field D5AbsentFoundVaccAfter5;
            public Int32Field D5AbsentVaccAfter5;
            public Int32Field D5AbsentRemainAfter5;
            public Int32Field D5RemainNss;
            public Int32Field D5FoundVaccNss5;
            public Int32Field D5VaccNss5;
            public Int32Field D5RemainNss5;
            public Int32Field D5RemainRefusal5;
            public Int32Field D5FoundVaccRefusal5;
            public Int32Field D5VaccRefusal5;
            public Int32Field D5RemainRefusal;
            public Int32Field D5VaccOutofHouse;

            public StringField DistrictDcode;
            public Int16Field DistrictProvinceId;
            public StringField DistrictDname;

            public StringField Round;
            public StringField Cluster;

            public Int16Field ProvinceId;
            public StringField Province;
            public StringField UniqueId;

            public Int32Field TenantId;

            public Int32Field ApprovedBy;
            public BooleanField Approved;
            public DateTimeField ApprovalDate;
            public RowFields()
                : base()
            {
                LocalTextPrefix = "Campaign.AdminData";
            }
        }
    }
}
