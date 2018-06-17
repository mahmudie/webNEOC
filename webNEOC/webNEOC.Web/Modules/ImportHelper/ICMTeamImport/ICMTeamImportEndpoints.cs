
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
    using MyRow = Implementation.Entities.IcmTeamRow;
    using Implementation.Repositories;
    using System.Globalization;

    [RoutePrefix("Services/ImportHelper/ICMTeamImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class ICMTeamImportController : ServiceEndpoint
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

            var Sup = IcmTeamRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;
            var clc = ClusterRow.Fields;
            var part = PartRow.Fields;

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
                    var monitname = Convert.ToString(worksheet.Cells[row, 7].Value ?? "");
                    var teamMember = Convert.ToString(worksheet.Cells[row, 8].Value ?? "");
                    var teamno = Convert.ToString(worksheet.Cells[row, 9].Value ?? "");
                    var time = Convert.ToString(worksheet.Cells[row, 11].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var IcmTeam = uow.Connection.TryFirst<IcmTeamRow>(q => q
                    .Select(Sup.IcmTeamId)
                    .Where(Sup.DistrictDcode == districtName & Sup.RoundName==roundName1 & Sup.Cname==clusterName & Sup.PartName==partName & Sup.TeamNo ==teamno & Sup.MonitorName==monitname & Sup.MonitVisitTime==time & Sup.TeamMemberName==teamMember));

                    if (IcmTeam == null)
                        IcmTeam = new IcmTeamRow
                        {
                            DistrictDcode = districtName,
                            RoundName=roundName1,
                            Cname=clusterName,
                            PartName=partName,
                            MonitorName =monitname,
                            TeamMemberName =teamMember,
                            TeamNo =teamno,
                            MonitVisitTime =time
                        };
                    else
                    {
                        // avoid assignment errors
                        IcmTeam.TrackWithChecks = false;
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

                        IcmTeam.RoundId = round.RoundId.Value;
                    }
                    else
                        IcmTeam.RoundId = null;


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

                        IcmTeam.DistrictId = district.DistrictId.Value;
                    }
                    else
                        IcmTeam.DistrictId = null;


                    var Cluster = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Cluster))
                    {
                        var round = uow.Connection.TryFirst<ClusterRow>(q => q
                            .Select(clc.ClusterId)
                            .Where(clc.Cname == Cluster & clc.DistrictDcode ==districtName));

                        if (Cluster == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Cluster with name '" +
                                Cluster + "' is not found!");
                            continue;
                        }

                        IcmTeam.ClusterId = round.ClusterId.Value;
                    }
                    else
                        IcmTeam.ClusterId = null;

                    var PartName = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(PartName))
                    {
                        var round = uow.Connection.TryFirst<PartRow>(q => q
                            .Select(part.PartId)
                            .Where(part.PartName == PartName));

                        if (PartName == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Part with name '" +
                                PartName + "' is not found!");
                            continue;
                        }

                        IcmTeam.PartId = round.PartId.Value;
                    }
                    else
                        IcmTeam.PartId = null;

                    IcmTeam.MonitorName = Convert.ToString(worksheet.Cells[row, 7].Value ?? "");
                    IcmTeam.TeamMemberName = Convert.ToString(worksheet.Cells[row, 8].Value ?? "");
                    if(string.IsNullOrEmpty(Convert.ToString(worksheet.Cells[row, 9].Value ?? "")))
                    {
                        IcmTeam.TeamNo = "UN";
                    }
                    else
                    {
                        IcmTeam.TeamNo = Convert.ToString(worksheet.Cells[row, 9].Value ?? "");
                    }

                    string ddate = worksheet.Cells[row, 10].Text;

                    if (string.IsNullOrEmpty(ddate))
                    {
                        IcmTeam.ReportDate = DateTime.Now;
                    }
                    else
                    {
                        //IcmTeam.ReportDate = DateTime.TryParseExact(ddate, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                        IcmTeam.ReportDate = DateTime.Now;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(worksheet.Cells[row, 11].Value ?? "")))
                    {
                        IcmTeam.MonitVisitTime = "UN";
                    }
                    else
                    {
                        IcmTeam.MonitVisitTime = Convert.ToString(worksheet.Cells[row, 11].Value ?? "");
                    }       
                    IcmTeam.IsTeamResident = Convert.ToBoolean(worksheet.Cells[row, 12].Value ?? false);
                    IcmTeam.BothTrained = Convert.ToBoolean(worksheet.Cells[row, 13].Value ?? false);
                    IcmTeam.HaveClearMap = Convert.ToBoolean(worksheet.Cells[row, 14].Value ?? false);
                    IcmTeam.AbleKnowArea = Convert.ToBoolean(worksheet.Cells[row, 15].Value ?? false);
                    IcmTeam.TeamGHtoH = Convert.ToBoolean(worksheet.Cells[row, 16].Value ?? false);
                    IcmTeam.OpvVialsKeptDry = Convert.ToBoolean(worksheet.Cells[row, 17].Value ?? false);
                    IcmTeam.UsingOpvStage3or4 = Convert.ToBoolean(worksheet.Cells[row, 18].Value ?? false);
                    IcmTeam.AskingAbout011C = Convert.ToBoolean(worksheet.Cells[row, 19].Value ?? false);
                    IcmTeam.AskingforGnssc = Convert.ToBoolean(worksheet.Cells[row, 20].Value ?? false);
                    IcmTeam.RecNameOfAbsentRefC = Convert.ToBoolean(worksheet.Cells[row, 21].Value ?? false);
                    IcmTeam.AskingAfpCases = Convert.ToBoolean(worksheet.Cells[row, 22].Value ?? false);

                    IcmTeam.VistedBySupervisor = Convert.ToBoolean(worksheet.Cells[row, 23].Value ?? false);
                    IcmTeam.TeamHasAchw = Convert.ToBoolean(worksheet.Cells[row, 24].Value ?? false);
                    IcmTeam.TeamHasFemale = Convert.ToBoolean(worksheet.Cells[row, 25].Value ?? false);
                    IcmTeam.SocMobAccompanyTeam = Convert.ToBoolean(worksheet.Cells[row, 26].Value ?? false);

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

                        IcmTeam.TenantId = Users.TenantId.Value;
                    }
                    else
                        IcmTeam.TenantId = null;


                    if (IcmTeam.IcmTeamId == null)
                    {
                        new IcmTeamRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcmTeam
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new IcmTeamRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcmTeam,
                            EntityId = IcmTeam.IcmTeamId.Value
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