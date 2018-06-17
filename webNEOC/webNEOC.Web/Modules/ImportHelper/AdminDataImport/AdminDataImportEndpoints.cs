
namespace webNEOC.ImportHelper.Endpoints
{
    using Campaign.Entities;
    using OfficeOpenXml;
    using Locations.Entities;
    using Lookup.Entities;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Web.Mvc;
    using MyRow = Campaign.Entities.AdminDataRow;
    using Campaign.Repositories;

    [RoutePrefix("Services/ImportHelper/AdminDataImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class AdminDataImportController : ServiceEndpoint
    {
        [HttpPost]
        public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request)
        {
            request.CheckNotNull();
            Check.NotNullOrWhiteSpace(request.FileName, "filename");

            UploadHelper.CheckFileNameSecurity(request.FileName);

            if (!request.FileName.StartsWith("temporary/"))
                throw new ArgumentOutOfRangeException("filename");

            ExcelPackage ep = new ExcelPackage();
            using (var fs = new FileStream(UploadHelper.DbFilePath(request.FileName), FileMode.Open, FileAccess.Read))
                ep.Load(fs);

            var l = AdminDataRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var c = ClusterRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var roundName1 = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    var districtName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    var cluster = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var AdminDa = uow.Connection.TryFirst<AdminDataRow>(q => q
                    .Select(l.AdminDataId)
                    .Where(l.DistrictDcode == districtName & l.Round == roundName1 & l.Cluster == cluster ));

                    if (AdminDa == null)
                        AdminDa = new AdminDataRow
                        {
                            DistrictDcode = districtName,
                            Round = roundName1,
                            Cluster = cluster
                        };
                    else
                    {
                        // avoid assignment errors
                        AdminDa.TrackWithChecks = false;
                    }

                    var roundName = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(roundName))
                    {
                        var round = uow.Connection.TryFirst<RoundRow>(q => q
                            .Select(r.RoundId)
                            .Where(r.RoundName == roundName));

                        if (round == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Round with name '" +
                                roundName + "' is not found!");
                            continue;
                        }

                        AdminDa.RoundId = round.RoundId.Value;
                    }
                    else
                        AdminDa.RoundId = null;


                    var dName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(dName))
                    {
                        var district = uow.Connection.TryFirst<DistrictRow>(q => q
                            .Select(d.DistrictId)
                            .Where(d.Dcode == dName));

                        if (district == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                districtName + "' is not found!");
                            continue;
                        }

                        AdminDa.DistrictId = district.DistrictId.Value;
                    }
                    else
                        AdminDa.DistrictId = null;

                    var ClusterName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(ClusterName))
                    {
                        var clusters = uow.Connection.TryFirst<ClusterRow>(q => q
                            .Select(c.ClusterId)
                            .Where(c.Cname == ClusterName & c.DistrictDcode==districtName));

                        if (clusters == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                ClusterName + "' is not found!");
                            continue;
                        }

                        AdminDa.ClusterId = clusters.ClusterId.Value;
                    }
                    else
                        AdminDa.ClusterId = null;

                    AdminDa.DateOfCampaign = DateTime.Now;
                    AdminDa.PemtremtManager = Convert.ToString(worksheet.Cells[row, 5].Value ?? 0);
                    AdminDa.TeamNo = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");

                    //Day 1
                    AdminDa.D1VialsRecieved = Convert.ToInt32(worksheet.Cells[row, 7].Value ?? 0);
                    AdminDa.D1VialsReturned = Convert.ToInt32(worksheet.Cells[row, 8].Value ?? 0);
                    AdminDa.D1VaccByTransit = Convert.ToInt32(worksheet.Cells[row, 9].Value ?? 0);
                    AdminDa.D1NoOfHhsVisited = Convert.ToInt32(worksheet.Cells[row, 10].Value ?? 0);
                    AdminDa.D1Ch05resident = Convert.ToInt32(worksheet.Cells[row, 11].Value ?? 0);
                    AdminDa.D1Ch05guest = Convert.ToInt32(worksheet.Cells[row, 12].Value ?? 0);
                    AdminDa.D1Ch05VaccInHouse = Convert.ToInt32(worksheet.Cells[row, 13].Value ?? 0);
                    AdminDa.D1Ch05VaccOutHouse = Convert.ToInt32(worksheet.Cells[row, 14].Value ?? 0);
                    AdminDa.D1Ch05NomadVacc = Convert.ToInt32(worksheet.Cells[row, 15].Value ?? 0);
                    AdminDa.D1AbsentRecordDuring = Convert.ToInt32(worksheet.Cells[row, 16].Value ?? 0);
                    AdminDa.D1AbsentFoundVaccDuring= Convert.ToInt32(worksheet.Cells[row, 17].Value ?? 0);
                    AdminDa.D1AbsentVaccDuring= Convert.ToInt32(worksheet.Cells[row, 18].Value ?? 0);
                    AdminDa.D1AbsentRemainDuring = Convert.ToInt32(worksheet.Cells[row, 19].Value ?? 0);
                    AdminDa.D1AbsentRecordAfter = Convert.ToInt32(worksheet.Cells[row, 20].Value ?? 0);
                    AdminDa.D1AbsentFoundVaccAfter = Convert.ToInt32(worksheet.Cells[row, 21].Value ?? 0);
                    AdminDa.D1AbsentVaccAfter = Convert.ToInt32(worksheet.Cells[row, 22].Value ?? 0);
                    AdminDa.D1AbsentRemainAfter= Convert.ToInt32(worksheet.Cells[row, 23].Value ?? 0);
                    AdminDa.D1NssRecord= Convert.ToInt32(worksheet.Cells[row, 24].Value ?? 0);
                    AdminDa.D1NssFoundVacc = Convert.ToInt32(worksheet.Cells[row, 25].Value ?? 0);
                    AdminDa.D1NssVaccinated = Convert.ToInt32(worksheet.Cells[row, 26].Value ?? 0);
                    AdminDa.D1NssReamining = Convert.ToInt32(worksheet.Cells[row, 27].Value ?? 0);
                    AdminDa.D1RefusalRecord= Convert.ToInt32(worksheet.Cells[row, 28].Value ?? 0);
                    AdminDa.D1RefusalFoundVacc = Convert.ToInt32(worksheet.Cells[row, 29].Value ?? 0);
                    AdminDa.D1RefusalVacc = Convert.ToInt32(worksheet.Cells[row,30].Value ?? 0);
                    AdminDa.D1RefusalRemaining = Convert.ToInt32(worksheet.Cells[row, 31].Value ?? 0);

                    //Day 2
                    AdminDa.D2VialsRecieved = Convert.ToInt32(worksheet.Cells[row, 32].Value ?? 0);
                    AdminDa.D2VialsReturned = Convert.ToInt32(worksheet.Cells[row, 33].Value ?? 0);
                    AdminDa.D2VaccByTransit = Convert.ToInt32(worksheet.Cells[row, 34].Value ?? 0);
                    AdminDa.D2NoOfHhsVisited = Convert.ToInt32(worksheet.Cells[row, 35].Value ?? 0);
                    AdminDa.D2Ch05resident = Convert.ToInt32(worksheet.Cells[row, 36].Value ?? 0);
                    AdminDa.D2Ch05guest = Convert.ToInt32(worksheet.Cells[row, 37].Value ?? 0);
                    AdminDa.D2Ch05VaccInHouse = Convert.ToInt32(worksheet.Cells[row, 38].Value ?? 0);
                    AdminDa.D2Ch05VaccOutHouse = Convert.ToInt32(worksheet.Cells[row, 39].Value ?? 0);
                    AdminDa.D2Ch05NomadVacc = Convert.ToInt32(worksheet.Cells[row, 40].Value ?? 0);
                    AdminDa.D2AbsentRecordDuring = Convert.ToInt32(worksheet.Cells[row, 41].Value ?? 0);
                    AdminDa.D2AbsentFoundVaccDuring = Convert.ToInt32(worksheet.Cells[row, 42].Value ?? 0);
                    AdminDa.D2AbsentVaccDuring = Convert.ToInt32(worksheet.Cells[row, 43].Value ?? 0);
                    AdminDa.D2AbsentRemainDuring = Convert.ToInt32(worksheet.Cells[row, 44].Value ?? 0);
                    AdminDa.D2AbsentRecordAfter = Convert.ToInt32(worksheet.Cells[row, 45].Value ?? 0);
                    AdminDa.D2AbsentFoundVaccAfter = Convert.ToInt32(worksheet.Cells[row, 46].Value ?? 0);
                    AdminDa.D2AbsentVaccAfter = Convert.ToInt32(worksheet.Cells[row, 47].Value ?? 0);
                    AdminDa.D2AbsentRemainAfter = Convert.ToInt32(worksheet.Cells[row, 48].Value ?? 0);
                    AdminDa.D2NssRecord = Convert.ToInt32(worksheet.Cells[row, 49].Value ?? 0);
                    AdminDa.D2NssFoundVacc = Convert.ToInt32(worksheet.Cells[row, 50].Value ?? 0);
                    AdminDa.D2NssVaccinated = Convert.ToInt32(worksheet.Cells[row, 51].Value ?? 0);
                    AdminDa.D2NssReamining = Convert.ToInt32(worksheet.Cells[row, 52].Value ?? 0);
                    AdminDa.D2RefusalRecord = Convert.ToInt32(worksheet.Cells[row, 53].Value ?? 0);
                    AdminDa.D2RefusalFoundVacc = Convert.ToInt32(worksheet.Cells[row, 54].Value ?? 0);
                    AdminDa.D2RefusalVacc = Convert.ToInt32(worksheet.Cells[row, 55].Value ?? 0);
                    AdminDa.D2RefusalRemaining = Convert.ToInt32(worksheet.Cells[row, 56].Value ?? 0);

                    //Day 3
                    AdminDa.D3VialsRecieved = Convert.ToInt32(worksheet.Cells[row, 57].Value ?? 0);
                    AdminDa.D3VialsReturned = Convert.ToInt32(worksheet.Cells[row, 58].Value ?? 0);
                    AdminDa.D3VaccByTransit = Convert.ToInt32(worksheet.Cells[row, 59].Value ?? 0);
                    AdminDa.D3NoOfHhsVisited = Convert.ToInt32(worksheet.Cells[row, 60].Value ?? 0);
                    AdminDa.D3Ch05resident = Convert.ToInt32(worksheet.Cells[row, 61].Value ?? 0);
                    AdminDa.D3Ch05guest = Convert.ToInt32(worksheet.Cells[row, 62].Value ?? 0);
                    AdminDa.D3Ch05VaccInHouse = Convert.ToInt32(worksheet.Cells[row, 63].Value ?? 0);
                    AdminDa.D3Ch05VaccOutHouse = Convert.ToInt32(worksheet.Cells[row, 64].Value ?? 0);
                    AdminDa.D3Ch05NomadVacc = Convert.ToInt32(worksheet.Cells[row, 65].Value ?? 0);
                    AdminDa.D3AbsentRecordDuring = Convert.ToInt32(worksheet.Cells[row, 66].Value ?? 0);
                    AdminDa.D3AbsentFoundVaccDuring = Convert.ToInt32(worksheet.Cells[row, 67].Value ?? 0);
                    AdminDa.D3AbsentVaccDuring = Convert.ToInt32(worksheet.Cells[row, 68].Value ?? 0);
                    AdminDa.D3AbsentRemainDuring = Convert.ToInt32(worksheet.Cells[row, 69].Value ?? 0);
                    AdminDa.D3AbsentRecordAfter = Convert.ToInt32(worksheet.Cells[row, 70].Value ?? 0);
                    AdminDa.D3AbsentFoundVaccAfter = Convert.ToInt32(worksheet.Cells[row, 71].Value ?? 0);
                    AdminDa.D3AbsentVaccAfter = Convert.ToInt32(worksheet.Cells[row, 72].Value ?? 0);
                    AdminDa.D3AbsentRemainAfter = Convert.ToInt32(worksheet.Cells[row, 73].Value ?? 0);
                    AdminDa.D3NssRecord = Convert.ToInt32(worksheet.Cells[row, 74].Value ?? 0);
                    AdminDa.D3NssFoundVacc = Convert.ToInt32(worksheet.Cells[row, 75].Value ?? 0);
                    AdminDa.D3NssVaccinated = Convert.ToInt32(worksheet.Cells[row, 76].Value ?? 0);
                    AdminDa.D3NssReamining = Convert.ToInt32(worksheet.Cells[row, 77].Value ?? 0);
                    AdminDa.D3RefusalRecord = Convert.ToInt32(worksheet.Cells[row, 78].Value ?? 0);
                    AdminDa.D3RefusalFoundVacc = Convert.ToInt32(worksheet.Cells[row, 79].Value ?? 0);
                    AdminDa.D3RefusalVacc = Convert.ToInt32(worksheet.Cells[row, 80].Value ?? 0);
                    AdminDa.D3RefusalRemaining = Convert.ToInt32(worksheet.Cells[row, 81].Value ?? 0);

                    //Day 5
                    AdminDa.D5VialsRecieved = Convert.ToInt32(worksheet.Cells[row, 82].Value ?? 0);
                    AdminDa.D5VialsReturned = Convert.ToInt32(worksheet.Cells[row, 83].Value ?? 0);
                    AdminDa.D5RemainAbsentDuring = Convert.ToInt32(worksheet.Cells[row, 84].Value ?? 0);
                    AdminDa.D5AbsentFoundVaccDuring5 = Convert.ToInt32(worksheet.Cells[row, 85].Value ?? 0);
                    AdminDa.D5AbsentVaccDuring5 = Convert.ToInt32(worksheet.Cells[row, 86].Value ?? 0);
                    AdminDa.D5AbsentRemainDuring5 = Convert.ToInt32(worksheet.Cells[row, 87].Value ?? 0);
                    AdminDa.D5RemainAbsentAfter = Convert.ToInt32(worksheet.Cells[row, 88].Value ?? 0);
                    AdminDa.D5AbsentFoundVaccAfter5 = Convert.ToInt32(worksheet.Cells[row, 89].Value ?? 0);
                    AdminDa.D5AbsentVaccAfter5 = Convert.ToInt32(worksheet.Cells[row, 90].Value ?? 0);
                    AdminDa.D5AbsentRemainAfter5 = Convert.ToInt32(worksheet.Cells[row, 91].Value ?? 0);
                    AdminDa.D5RemainNss = Convert.ToInt32(worksheet.Cells[row, 92].Value ?? 0);
                    AdminDa.D5FoundVaccNss5 = Convert.ToInt32(worksheet.Cells[row, 93].Value ?? 0);
                    AdminDa.D5VaccNss5 = Convert.ToInt32(worksheet.Cells[row, 94].Value ?? 0);
                    AdminDa.D5RemainNss5 = Convert.ToInt32(worksheet.Cells[row, 95].Value ?? 0);
                    AdminDa.D5RemainRefusal = Convert.ToInt32(worksheet.Cells[row, 96].Value ?? 0);
                    AdminDa.D5FoundVaccRefusal5 = Convert.ToInt32(worksheet.Cells[row, 97].Value ?? 0);
                    AdminDa.D5VaccRefusal5  = Convert.ToInt32(worksheet.Cells[row, 98].Value ?? 0);
                    AdminDa.D5RemainRefusal5 = Convert.ToInt32(worksheet.Cells[row, 99].Value ?? 0);
                    AdminDa.D5VaccOutofHouse = Convert.ToInt32(worksheet.Cells[row, 100].Value ?? 0);

                    var user = User.Identity.Name;
                    if (!string.IsNullOrWhiteSpace(user))
                    {
                        var Users = uow.Connection.TryFirst<Administration.Entities.UserRow>(q => q
                            .Select(usr.TenantId)
                            .Where(usr.Username == user));

                        if (Users == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": TenantID with name '" +
                                Users + "' is not found!");
                            continue;
                        }

                        AdminDa.TenantId = Users.TenantId.Value;
                    }
                    else
                        AdminDa.TenantId = null;

                    if (AdminDa.AdminDataId == null)
                    {
                        new AdminDataRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = AdminDa
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new AdminDataRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = AdminDa,
                            EntityId = AdminDa.AdminDataId.Value
                        });

                        response.Updated = response.Updated + 1;
                    }
                }
                catch (Exception ex)
                {
                    response.ErrorList.Add("Exception on Row " + row + ": " + ex.StackTrace);
                }
            }


            return response;
        }
    }
}