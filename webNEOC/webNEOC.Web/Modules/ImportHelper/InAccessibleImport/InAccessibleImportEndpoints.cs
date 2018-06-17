
namespace webNEOC.ImportHelper.Endpoints
{
    using Preparation.Entities;
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
    using MyRow = Preparation.Entities.InAccessibleRow;
    using Preparation.Repositories;

    [RoutePrefix("Services/ImportHelper/InAccessibleImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class InAccessibleImportController : ServiceEndpoint
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

            var InAc = InAccessibleRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            //var c = CampaignTypeRow.Fields;
            var ac = InAcsCategoryRow.Fields;
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
                    
                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var InAccess = uow.Connection.TryFirst<InAccessibleRow>(q => q
                    .Select(InAc.InAccessibleId)
                    .Where(InAc.DistrictDcode == districtName & InAc.RoundName==roundName1));

                    if (InAccess == null)
                        InAccess = new InAccessibleRow
                        {
                            DistrictDcode = districtName,
                            RoundName=roundName1
                        };
                    else
                    {
                        // avoid assignment errors
                        InAccess.TrackWithChecks = false;
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

                        InAccess.RoundId = round.RoundId.Value;
                    }
                    else
                        InAccess.RoundId = null;


                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
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

                        InAccess.DistrictId = district.DistrictId.Value;
                    }
                    else
                        InAccess.DistrictId = null;


                    InAccess.ReportDate = DateTime.Now;
                    InAccess.Target = Convert.ToInt32(worksheet.Cells[row, 6].Value ?? 0);
                    InAccess.MissedClusters = Convert.ToInt16(worksheet.Cells[row, 7].Value ?? 0);
                    InAccess.MissedChildren = Convert.ToInt32(worksheet.Cells[row, 8].Value ?? 0);
                    InAccess.PartiallyMissed = Convert.ToInt16(worksheet.Cells[row, 9].Value ?? 0);
                    InAccess.PartiallyMissedName = Convert.ToString(worksheet.Cells[row, 10].Value ?? "");
                    InAccess.FullyMissed = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0);
                    InAccess.FullyMissedName = Convert.ToString(worksheet.Cells[row, 12].Value ?? "");

                    var Reason = Convert.ToString(worksheet.Cells[row, 13].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Reason))
                    {
                        var reasonCat = uow.Connection.TryFirst<InAcsCategoryRow>(q => q
                            .Select(ac.InAcsCategoryId)
                            .Where(ac.Description == Reason));

                        if (Reason == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": In Access Category Type with name '" +
                                Reason + "' is not found!");
                            continue;
                        }

                        InAccess.InAcsCategoryId = reasonCat.InAcsCategoryId.Value;
                    }
                    else
                        InAccess.InAcsCategoryId = null;

                    InAccess.PlanToReduce = Convert.ToString(worksheet.Cells[row, 14].Value ?? "");


                    InAccess.Remarks = Convert.ToString(worksheet.Cells[row, 15].Value ?? "");

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

                        InAccess.TenantId = Users.TenantId.Value;
                    }
                    else
                        InAccess.TenantId = null;


                    if (InAccess.InAccessibleId == null)
                    {
                        new InAccessibleRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = InAccess
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new InAccessibleRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = InAccess,
                            EntityId = InAccess.InAccessibleId.Value
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