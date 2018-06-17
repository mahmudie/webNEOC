
namespace webNEOC.ImportHelper.Endpoints
{
    using OfficeOpenXml;
    using Locations.Entities;
    using Lookup.Entities;
    using PostCampaign.Entities;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Web.Mvc;
    using MyRow = PostCampaign.Entities.PcmRow;
    using PostCampaign.Repositories;

    [RoutePrefix("Services/ImportHelper/PcmImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class PcmImportController : ServiceEndpoint
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

            var pcm = PcmRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;
            var clc = ClusterRow.Fields;
            var cll = ClusterLevelRow.Fields;
            var cmp = CampaignTypeRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var roundName1 = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    var districtName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    var clusterName = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");
                    var levelName = Convert.ToString(worksheet.Cells[row, 7].Value ?? "");
                    var campType= Convert.ToString(worksheet.Cells[row, 5].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var pcmEnt = uow.Connection.TryFirst<PcmRow>(q => q
                    .Select(pcm.PcmId)
                    .Where(pcm.DistrictDcode == districtName & pcm.RoundName==roundName1 & pcm.ClusterName==clusterName & pcm.LevelName==levelName & pcm.CampaignTypeName==campType));

                    if (pcmEnt == null)
                        pcmEnt = new PcmRow
                        {
                            DistrictDcode = districtName,
                            RoundName=roundName1,
                            ClusterName=clusterName,
                            LevelName=levelName,
                            CampaignTypeName=campType
                        };
                    else
                    {
                        // avoid assignment errors
                        pcmEnt.TrackWithChecks = false;
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

                        pcmEnt.RoundId = round.RoundId.Value;
                    }
                    else
                        pcmEnt.RoundId = null;


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

                        pcmEnt.DistrictId = district.DistrictId.Value;
                    }
                    else
                        pcmEnt.DistrictId = null;


                    var Cluster = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Cluster))
                    {
                        var round = uow.Connection.TryFirst<ClusterRow>(q => q
                            .Select(clc.ClusterId)
                            .Where(clc.DistrictDcode ==districtName &  clc.Cname == Cluster));

                        if (Cluster == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Cluster with name '" +
                                Cluster + "' is not found!");
                            continue;
                        }

                        pcmEnt.ClusterId = round.ClusterId.Value;
                    }
                    else
                        pcmEnt.ClusterId = null;

                    var ClusterLevelName = Convert.ToString(worksheet.Cells[row, 7].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(ClusterLevelName))
                    {
                        var round = uow.Connection.TryFirst<ClusterLevelRow>(q => q
                            .Select(cll.ClusterLevelId)
                            .Where(cll.ClusterName == ClusterLevelName));

                        if (pcmEnt == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Cluster Level with name '" +
                                ClusterLevelName + "' is not found!");
                            continue;
                        }

                        pcmEnt.ClusterLevelId = round.ClusterLevelId.Value;
                    }
                    else
                        pcmEnt.ClusterLevelId = null;

                    var cmpType = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(cmpType))
                    {
                        var round = uow.Connection.TryFirst<CampaignTypeRow>(q => q
                            .Select(cmp.CampaignTypeId)
                            .Where(cmp.CampaignName == cmpType));

                        if (pcmEnt == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Campaign Type Level with name '" +
                                cmpType + "' is not found!");
                            continue;
                        }

                        pcmEnt.CampaignTypeId = round.CampaignTypeId.Value;
                    }
                    else
                        pcmEnt.CampaignTypeId = null;

                    pcmEnt.ClusterCode = Convert.ToString(worksheet.Cells[row, 8].Value ?? "");
                    pcmEnt.Village = Convert.ToString(worksheet.Cells[row, 9].Value ?? "");
                    pcmEnt.VistedHouses = Convert.ToInt16(worksheet.Cells[row, 10].Value ?? 0);
                    pcmEnt.T059m = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0); ;
                    pcmEnt.V059m = Convert.ToInt16(worksheet.Cells[row, 12].Value ?? 0);
                    pcmEnt.T011Seen = Convert.ToInt16(worksheet.Cells[row, 13].Value ?? 0);
                    pcmEnt.Fm011HvFm= Convert.ToInt16(worksheet.Cells[row, 14].Value ?? 0);
                    pcmEnt.T1259Seen = Convert.ToInt16(worksheet.Cells[row, 15].Value ?? 0);
                    pcmEnt.Fm1259HvFm = Convert.ToInt16(worksheet.Cells[row, 16].Value ?? 0);
                    pcmEnt.TChildrenNoFm = Convert.ToInt16(worksheet.Cells[row, 17].Value ?? 0);
                    pcmEnt.R1TeamNoVisit = Convert.ToInt16(worksheet.Cells[row, 18].Value ?? 0);
                    pcmEnt.R21 = Convert.ToInt16(worksheet.Cells[row, 19].Value ?? 0);
                    pcmEnt.R22 = Convert.ToInt16(worksheet.Cells[row, 20].Value ?? 0);
                    pcmEnt.R23 = Convert.ToInt16(worksheet.Cells[row, 21].Value ?? 0);
                    pcmEnt.R24 = Convert.ToInt16(worksheet.Cells[row, 22].Value ?? 0);
                    pcmEnt.R31 = Convert.ToInt16(worksheet.Cells[row, 23].Value ?? 0);
                    pcmEnt.R32= Convert.ToInt16(worksheet.Cells[row, 24].Value ?? 0);
                    pcmEnt.R33 = Convert.ToInt16(worksheet.Cells[row, 25].Value ?? 0);

                    pcmEnt.R4NewBorn= Convert.ToInt16(worksheet.Cells[row, 26].Value ?? 0);
                    pcmEnt.R5Sleep = Convert.ToInt16(worksheet.Cells[row, 27].Value ?? 0);
                    pcmEnt.R6Sick = Convert.ToInt16(worksheet.Cells[row, 28].Value ?? 0);
                    pcmEnt.R7Other = Convert.ToInt16(worksheet.Cells[row, 29].Value ?? 0);
                    pcmEnt.DmCorrect = Convert.ToInt16(worksheet.Cells[row, 30].Value ?? 0);
                    pcmEnt.DmIncorrect = Convert.ToInt16(worksheet.Cells[row, 31].Value ?? 0);
                    pcmEnt.NoDm = Convert.ToInt16(worksheet.Cells[row, 32].Value ?? 0);

                    pcmEnt.FmHeard = Convert.ToInt16(worksheet.Cells[row, 33].Value ?? 0);
                    pcmEnt.FmNotHeard = Convert.ToInt16(worksheet.Cells[row, 34].Value ?? 0);
                    pcmEnt.Radio = Convert.ToInt16(worksheet.Cells[row, 35].Value ?? 0);
                    pcmEnt.Tv = Convert.ToInt16(worksheet.Cells[row, 36].Value ?? 0);
                    pcmEnt.MullahElders = Convert.ToInt16(worksheet.Cells[row, 37].Value ?? 0);

                    pcmEnt.Teacher = Convert.ToInt16(worksheet.Cells[row, 38].Value ?? 0);
                    pcmEnt.Chw = Convert.ToInt16(worksheet.Cells[row, 39].Value ?? 0);
                    pcmEnt.CElders = Convert.ToInt16(worksheet.Cells[row, 40].Value ?? 0);
                    pcmEnt.PbLeaflet = Convert.ToInt16(worksheet.Cells[row, 41].Value ?? 0);
                    pcmEnt.Sm = Convert.ToInt16(worksheet.Cells[row, 42].Value ?? 0);
                    pcmEnt.Other = Convert.ToInt16(worksheet.Cells[row, 43].Value ?? 0);

                    pcmEnt.ChVacByMonitor = Convert.ToInt16(worksheet.Cells[row, 44].Value ?? 0);
                    pcmEnt.RCallCoverage = Convert.ToInt16(worksheet.Cells[row, 45].Value ?? 0);
                    pcmEnt.Fm059Coverage = Convert.ToInt16(worksheet.Cells[row, 46].Value ?? 0);
                    pcmEnt.Fm011Coverage = Convert.ToInt16(worksheet.Cells[row, 47].Value ?? 0);
                    //pcmEnt.InAcesChildren = Convert.ToInt16(worksheet.Cells[row, 48].Value ?? 0);

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

                        pcmEnt.TenantId = Users.TenantId.Value;
                    }
                    else
                        pcmEnt.TenantId = null;


                    if (pcmEnt.PcmId == null)
                    {
                        new PcmRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = pcmEnt
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new PcmRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = pcmEnt,
                            EntityId = pcmEnt.PcmId.Value
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