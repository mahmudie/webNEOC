
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
    using MyRow = Lookup.Entities.TargetPopRow;
    using webNEOC.Lookup.Repositories;

    [RoutePrefix("Services/ImportHelper/TargetImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class TargetImportController : ServiceEndpoint
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

            var d = DistrictRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;
            var target = Lookup.Entities.TargetPopRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var districtId = Convert.ToString(worksheet.Cells[row, 4].Value ?? 0);
                    var year = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? 0);

                    if (districtId.IsTrimmedEmpty())
                        continue;

                    var targ = uow.Connection.TryFirst<TargetPopRow>(q => q
                    .Select(target.TargetId)
                    .Where(target.DistrictDcode == districtId & target.YearId==year));

                    if (targ == null)
                        targ = new TargetPopRow
                        {
                            DistrictDcode = districtId,
                            YearId=year
                        };
                    else
                    {
                        // avoid assignment errors
                        targ.TrackWithChecks = false;
                    }


                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    var Yearm = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? 0);
                    if (!string.IsNullOrEmpty(dName))
                    {
                        var district = uow.Connection.TryFirst<DistrictRow>(q => q
                            .Select(d.DistrictId)
                            .Where(d.Dcode==dName));

                        if (district == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with code '" +
                                dName + "' is not found!");
                            continue;
                        }

                        targ.DistrictId = district.DistrictId.Value;
                    }
                    else
                        targ.DistrictId = null;


                    targ.YearId = Convert.ToInt16(worksheet.Cells[row, 5].Value ?? 0);
                    targ.Target = Convert.ToInt64(worksheet.Cells[row, 6].Value ?? 0);
                    targ.LpDs = Convert.ToString(worksheet.Cells[row, 7].Value ?? "");

                    if (targ.TargetId == null)
                    {
                        new TargetPopRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = targ
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new TargetPopRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = targ,
                            EntityId = targ.TargetId.Value
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