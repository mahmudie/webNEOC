
namespace webNEOC.ImportHelper.Endpoints
{
    using Implementation.Entities;
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
    using MyRow = Implementation.Entities.IcmHouseholdRow;
    using Implementation.Repositories;

    [RoutePrefix("Services/ImportHelper/ICMHouseholdImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class ICMHouseholdImportController : ServiceEndpoint
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

            var Hs = IcmHouseholdRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;
            var par = PartRow.Fields;
            var clc = ClusterRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var roundName1 = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    var districtName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    var partName = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    var clusterName = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");
                    var village =Convert.ToString(worksheet.Cells[row, 8].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var IcmHousehold = uow.Connection.TryFirst<IcmHouseholdRow>(q => q
                    .Select(Hs.IcmHouseholdId)
                    .Where(Hs.DistrictDcode == districtName & Hs.RoundName==roundName1 & Hs.PartPartName==partName & Hs.Cname==clusterName & Hs.Village ==village));

                    if (IcmHousehold == null)
                        IcmHousehold = new IcmHouseholdRow
                        {
                            DistrictDname = districtName,
                            RoundName=roundName1,
                            PartPartName=partName,
                            Cname=clusterName,
                            Village=village
                        };
                    else
                    {
                        // avoid assignment errors
                        IcmHousehold.TrackWithChecks = false;
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

                        IcmHousehold.RoundId = round.RoundId.Value;
                    }
                    else
                        IcmHousehold.RoundId = null;


                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(dName))
                    {
                        var district = uow.Connection.TryFirst<DistrictRow>(q => q
                            .Select(d.DistrictId)
                            .Where(d.Dcode == dName));

                        if (dName == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                dName + "' is not found!");
                            continue;
                        }

                        IcmHousehold.DistrictId = district.DistrictId.Value;
                    }
                    else
                        IcmHousehold.DistrictId = null;

                    var Part = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Part))
                    {
                        var round = uow.Connection.TryFirst<PartRow>(q => q
                            .Select(par.PartId)
                            .Where(par.PartName == Part));

                        if (Part == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Part Name with name '" +
                                Part + "' is not found!");
                            continue;
                        }

                        IcmHousehold.PartId = round.PartId.Value;
                    }
                    else
                        IcmHousehold.PartId = null;

                    var Cluster = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Cluster))
                    {
                        var round = uow.Connection.TryFirst<ClusterRow>(q => q
                            .Select(clc.ClusterId)
                            .Where(clc.Cname == Cluster & clc.DistrictDcode==districtName));

                        if (Cluster == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Cluster with name '" +
                                Cluster + "' is not found!");
                            continue;
                        }

                        IcmHousehold.ClusterId = round.ClusterId.Value;
                    }
                    else
                        IcmHousehold.ClusterId = null;

                    IcmHousehold.ReportDate = DateTime.Now;
                    IcmHousehold.Village = Convert.ToString(worksheet.Cells[row, 8].Value ?? "");
                    IcmHousehold.Supervisor = Convert.ToString(worksheet.Cells[row, 9].Value ?? 0);
                    IcmHousehold.NoHhVisited = Convert.ToInt16(worksheet.Cells[row, 10].Value ?? 0);
                    IcmHousehold.NoChildrenInVisitedHh = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0);
                    IcmHousehold.NoVaccInRecall = Convert.ToInt16(worksheet.Cells[row, 12].Value ?? 0);
                    IcmHousehold.MissedChildren = Convert.ToInt16(worksheet.Cells[row, 13].Value ?? 0);
                    IcmHousehold.TeamNotCome = Convert.ToInt16(worksheet.Cells[row, 14].Value ?? 0);
                    IcmHousehold.ChildrenAbsent = Convert.ToInt16(worksheet.Cells[row, 15].Value ?? 0);
                    IcmHousehold.NewbornSsChildren = Convert.ToInt16(worksheet.Cells[row, 16].Value ?? 0);
                    IcmHousehold.NoRefused = Convert.ToInt16(worksheet.Cells[row, 17].Value ?? 0);
                    IcmHousehold.NoIgnoredbyTeam = Convert.ToInt16(worksheet.Cells[row, 18].Value ?? 0);
                    IcmHousehold.TotUn5SeenByMonit = Convert.ToInt16(worksheet.Cells[row, 19].Value ?? 0);
                    IcmHousehold.NoSeenWithFingerMark = Convert.ToInt16(worksheet.Cells[row, 20].Value ?? 0);
                    IcmHousehold.NoCorrect = Convert.ToInt16(worksheet.Cells[row, 21].Value ?? 0);
                    IcmHousehold.NoIncorrect = Convert.ToInt16(worksheet.Cells[row, 22].Value ?? 0);
                    IcmHousehold.NoNotMarked = Convert.ToInt16(worksheet.Cells[row, 23].Value ?? 0);
                    IcmHousehold.NoChildFoundMissedRecall = Convert.ToInt16(worksheet.Cells[row, 24].Value ?? 0);
                    IcmHousehold.NoChildRecBackOfTally = Convert.ToInt16(worksheet.Cells[row, 25].Value ?? 0);

                    var user = User.Identity.Name;
                    if (!string.IsNullOrWhiteSpace(user))
                    {
                        var Users = uow.Connection.TryFirst<Administration.Entities.UserRow>(q => q
                            .Select(usr.TenantId)
                            .Where(usr.Username==user));

                        if (Users == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": TenantID with name '" +
                                Users + "' is not found!");
                            continue;
                        }

                        IcmHousehold.TenantId = Users.TenantId.Value;
                    }
                    else
                        IcmHousehold.TenantId = null;


                    if (IcmHousehold.IcmHouseholdId == null)
                    {
                        new IcmHouseholdRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcmHousehold
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new IcmHouseholdRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcmHousehold,
                            EntityId = IcmHousehold.IcmHouseholdId.Value
                        });

                        response.Updated = response.Updated + 1;
                    }
                }
                catch (Exception ex)
                {
                    response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                }
            }


            return response;
        }
    }
}