
namespace webNEOC.ImportHelper.Endpoints
{
    using PostCampaign.Entities;
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
    using MyRow = PostCampaign.Entities.LQASRow;
    using PostCampaign.Repositories;

    [RoutePrefix("Services/ImportHelper/LQASImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class LQASImportController : ServiceEndpoint
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

            var l = LQASRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var roundName1 = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    var districtName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    var provName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    var lotNo = Convert.ToInt16(worksheet.Cells[row, 5].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var LQAS = uow.Connection.TryFirst<LQASRow>(q => q
                    .Select(l.LqasId)
                    .Where(l.DistrictDcode == districtName & l.RoundName==roundName1 & l.Province==provName & l.LotNo==lotNo));

                    if (LQAS == null)
                        LQAS = new LQASRow
                        {
                            DistrictDcode = districtName,
                            RoundName=roundName1,
                            Province=provName,
                            LotNo=lotNo
                        };
                    else
                    {
                        // avoid assignment errors
                        LQAS.TrackWithChecks = false;
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

                        LQAS.RoundId = round.RoundId.Value;
                    }
                    else
                        LQAS.RoundId = null;


                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    var provincename = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
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

                        LQAS.DistrictId = district.DistrictId.Value;
                    }
                    else
                        LQAS.DistrictId = null;


                    LQAS.LotNo = Convert.ToInt16(worksheet.Cells[row, 5].Value ?? 0);
                    LQAS.NoVaccChildren = Convert.ToInt16(worksheet.Cells[row, 6].Value ?? 0);
                    LQAS.Comments = Convert.ToString(worksheet.Cells[row, 7].Value ?? "");

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

                        LQAS.TenantId = Users.TenantId.Value;
                    }
                    else
                        LQAS.TenantId = null;

                    if (LQAS.LqasId == null)
                    {
                        new LQASRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = LQAS
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new LQASRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = LQAS,
                            EntityId = LQAS.LqasId.Value
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