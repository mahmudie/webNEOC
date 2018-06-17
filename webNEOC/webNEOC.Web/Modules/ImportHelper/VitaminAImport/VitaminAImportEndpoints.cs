
namespace webNEOC.ImportHelper.Endpoints
{
    using OfficeOpenXml;
    using Locations.Entities;
    using Lookup.Entities;
    using ImportGate.Entities;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Web.Mvc;
    using MyRow = ImportGate.Entities.TempVitaminARow;
    using ImportGate.Repositories;

    [RoutePrefix("Services/ImportHelper/VitaminAImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class VitaminAImportController : ServiceEndpoint
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

            var TempVitA = TempVitaminARow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;
            var clc = ClusterRow.Fields;
            var prov = ProvinceRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var roundName1 = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    var districtName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    var clusterName = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    var provName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var TempA = uow.Connection.TryFirst<TempVitaminARow>(q => q
                    .Select(TempVitA.TempVitaminAId)
                    .Where(TempVitA.DistrictName == districtName & TempVitA.RoundName==roundName1 & TempVitA.ClusterName==clusterName & TempVitA.ProvinceName==provName));

                    if (TempA == null)
                        TempA = new TempVitaminARow
                        {
                            DistrictName = districtName,
                            RoundName=roundName1,
                            ClusterName=clusterName,
                            ProvinceName=provName
                        };
                    else
                    {
                        // avoid assignment errors
                        TempA.TrackWithChecks = false;
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

                        TempA.RoundId = round.RoundId.Value;
                    }
                    else
                        TempA.RoundId = null;


                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(dName))
                    {
                        var district = uow.Connection.TryFirst<DistrictRow>(q => q
                            .Select(d.DistrictId)
                            .Where(d.Dcode == dName & d.Pname==provName));

                        if (dName == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                dName + "' is not found!");
                            continue;
                        }

                        TempA.DistrictId = district.DistrictId.Value;
                    }
                    else
                        TempA.DistrictId = null;


                    var Cluster = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
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

                        TempA.ClusterId = round.ClusterId.Value;
                    }
                    else
                        TempA.ClusterId = null;

                    var Province = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Province))
                    {
                        var round = uow.Connection.TryFirst<ProvinceRow>(q => q
                            .Select(prov.ProvinceId)
                            .Where(prov.Pname == Province));

                        if (TempA == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Province with name '" +
                                Province + "' is not found!");
                            continue;
                        }

                        TempA.ProvinceId = round.ProvinceId.Value;
                    }
                    else
                        TempA.ProvinceId = null;

                    TempA.TargetU5Cases = Convert.ToInt16(worksheet.Cells[row, 6].Value ?? 0);
                    TempA.D1VitADist = Convert.ToInt16(worksheet.Cells[row, 7].Value ?? 0);
                    TempA.D1VitAUse = Convert.ToInt16(worksheet.Cells[row, 8].Value ?? 0);
                    TempA.D1C611Months = Convert.ToInt16(worksheet.Cells[row, 9].Value ?? 0); ;
                    TempA.D1C1259Months = Convert.ToInt16(worksheet.Cells[row, 10].Value ?? 0);
                    TempA.D2VitADist = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0);
                    TempA.D2VitAUse= Convert.ToInt16(worksheet.Cells[row, 12].Value ?? 0);
                    TempA.D2C611Months = Convert.ToInt16(worksheet.Cells[row, 13].Value ?? 0);
                    TempA.D2C1259Months = Convert.ToInt16(worksheet.Cells[row, 14].Value ?? 0);
                    TempA.D3VitADist = Convert.ToInt16(worksheet.Cells[row, 15].Value ?? 0);
                    TempA.D3VitAUse = Convert.ToInt16(worksheet.Cells[row, 16].Value ?? 0);
                    TempA.D3C611Months = Convert.ToInt16(worksheet.Cells[row, 17].Value ?? 0);
                    TempA.D3C1259Months = Convert.ToInt16(worksheet.Cells[row, 18].Value ?? 0);
                    TempA.D5VitADist = Convert.ToInt16(worksheet.Cells[row, 19].Value ?? 0);
                    TempA.D5VitAUse = Convert.ToInt16(worksheet.Cells[row, 20].Value ?? 0);
                    TempA.D5C611Months = Convert.ToInt16(worksheet.Cells[row, 21].Value ?? 0);
                    TempA.D5C1259Months= Convert.ToInt16(worksheet.Cells[row, 22].Value ?? 0);
                    TempA.PemtremtManager= Convert.ToString(worksheet.Cells[row, 23].Value ?? "");

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

                        TempA.TenantId = Users.TenantId.Value;
                    }
                    else
                        TempA.TenantId = null;


                    if (TempA.TempVitaminAId == null)
                    {
                        new TempVitaminARepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = TempA
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new TempVitaminARepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = TempA,
                            EntityId = TempA.TempVitaminAId.Value
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