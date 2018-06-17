
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
    using MyRow = Implementation.Entities.IcnRow;
    using Implementation.Repositories;

    [RoutePrefix("Services/ImportHelper/ICNImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class ICNImportController : ServiceEndpoint
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

            var Icn = IcnRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;
            var clc = ClusterRow.Fields;


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
                    var clusterName = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");
                    var areaName= Convert.ToString(worksheet.Cells[row, 5].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var IcnRecord = uow.Connection.TryFirst<IcnRow>(q => q
                    .Select(Icn.IcnId)
                    .Where(Icn.DistrictDcode == districtName & Icn.RoundName==roundName1 & Icn.Cname==clusterName  & Icn.Province==provName & Icn.Area ==areaName));

                    if (IcnRecord == null)
                        IcnRecord = new IcnRow
                        {
                            DistrictDcode = districtName,
                            RoundName=roundName1,
                            Cname=clusterName,
                            Province=provName,
                            Area =areaName
                        };
                    else
                    {
                        // avoid assignment errors
                        IcnRecord.TrackWithChecks = false;
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

                        IcnRecord.RoundId = round.RoundId.Value;
                    }
                    else
                        IcnRecord.RoundId = null;


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

                        IcnRecord.DistrictId = district.DistrictId.Value;
                    }
                    else
                        IcnRecord.DistrictId = null;


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

                        IcnRecord.ClusterId = round.ClusterId.Value;
                    }
                    else
                        IcnRecord.ClusterId = null;

                    IcnRecord.Area = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    IcnRecord.RegAbsent = Convert.ToInt16(worksheet.Cells[row, 7].Value ?? 0);
                    IcnRecord.VacAbsent = Convert.ToInt16(worksheet.Cells[row, 8].Value ?? 0);
                    IcnRecord.RegNss = Convert.ToInt16(worksheet.Cells[row, 9].Value ?? 0);
                    IcnRecord.VacNss = Convert.ToInt16(worksheet.Cells[row, 10].Value ?? 0);
                    IcnRecord.RegRefusal = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0);
                    IcnRecord.VacRefusal = Convert.ToInt16(worksheet.Cells[row, 12].Value ?? 0);
                    IcnRecord.RegUnrecorded = Convert.ToInt16(worksheet.Cells[row, 13].Value ?? 0);
                    IcnRecord.VacUnrecorded = Convert.ToInt16(worksheet.Cells[row, 14].Value ?? 0);

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

                        IcnRecord.TenantId = Users.TenantId.Value;
                    }
                    else
                        IcnRecord.TenantId = null;


                    if (IcnRecord.IcnId == null)
                    {
                        new IcnRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcnRecord
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new IcnRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcnRecord,
                            EntityId = IcnRecord.IcnId.Value
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