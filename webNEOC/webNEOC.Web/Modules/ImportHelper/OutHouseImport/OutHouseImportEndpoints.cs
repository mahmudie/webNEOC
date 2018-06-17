
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
    using System.Data;
    using System.IO;
    using System.Web.Mvc;
    using MyRow = PostCampaign.Entities.OutOfHouseSurveyRow;
    using PostCampaign.Repositories;

    [RoutePrefix("Services/ImportHelper/OutHouseImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class OutHouseImportController : ServiceEndpoint
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

            var o = OutOfHouseSurveyRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var c = CampaignTypeRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var roundName1 = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    var provName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    var districtName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");

                  
                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var outHouse = uow.Connection.TryFirst<OutOfHouseSurveyRow>(q => q
                    .Select(o.OutOfHouseSurveyId)
                    .Where(o.DistrictDcode == districtName & o.RoundName==roundName1));

                    if (outHouse == null)
                        outHouse = new OutOfHouseSurveyRow
                        {
                            DistrictDcode = districtName,
                            RoundName=roundName1,
                            Province=provName
                        };
                    else
                    {
                        // avoid assignment errors
                        outHouse.TrackWithChecks = false;
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

                        outHouse.RoundId = round.RoundId.Value;
                    }
                    else
                        outHouse.RoundId = null;


                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(dName))
                    {
                        var district = uow.Connection.TryFirst<DistrictRow>(q => q
                            .Select(d.DistrictId)
                            .Where( d.Dcode == dName ));

                        if (district == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                districtName + "' is not found!");
                            continue;
                        }

                        outHouse.DistrictId = district.DistrictId.Value;
                    }
                    else
                        outHouse.DistrictId = null;


                    outHouse.ReportDate = DateTime.Now;
                    outHouse.T059m = Convert.ToInt16(worksheet.Cells[row, 6].Value ?? 0);
                    outHouse.Vac059m = Convert.ToInt16(worksheet.Cells[row, 7].Value ?? 0);
                    outHouse.FM059m = Convert.ToInt16(worksheet.Cells[row, 8].Value ?? 0);
                    outHouse.T059f = Convert.ToInt16(worksheet.Cells[row, 9].Value ?? 0);
                    outHouse.Vac059f = Convert.ToInt16(worksheet.Cells[row, 10].Value ?? 0);
                    outHouse.FM059f = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0);
                    outHouse.MissTmNotCome = Convert.ToInt16(worksheet.Cells[row, 12].Value ?? 0);
                    outHouse.MissAbsent = Convert.ToInt16(worksheet.Cells[row, 13].Value ?? 0);
                    outHouse.MissRefused = Convert.ToInt16(worksheet.Cells[row, 14].Value ?? 0);
                    outHouse.MissNewBornSick = Convert.ToInt16(worksheet.Cells[row, 15].Value ?? 0);

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

                        outHouse.TenantId = Users.TenantId.Value;
                    }
                    else
                        outHouse.TenantId = null;

                    if (outHouse.OutOfHouseSurveyId == null)
                    {
                        new OutOfHouseSurveyRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = outHouse
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new OutOfHouseSurveyRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = outHouse,
                            EntityId = outHouse.OutOfHouseSurveyId.Value
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