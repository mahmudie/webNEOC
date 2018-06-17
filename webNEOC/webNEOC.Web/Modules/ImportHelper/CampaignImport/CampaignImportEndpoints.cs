
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
    using MyRow = ImportGate.Entities.TempCampaignRow;
    using ImportGate.Repositories;
    using System.Data;
    using System.Linq;

    [RoutePrefix("Services/ImportHelper/CampaignImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class CampaignImportController : ServiceEndpoint
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

            var TempCamp = TempCampaignRow.Fields;
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
                    var clusterName = Convert.ToString(worksheet.Cells[row,5].Value ?? "");
                    var provName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var TempC = uow.Connection.TryFirst<TempCampaignRow>(q => q
                    .Select(TempCamp.TempCampaignId)
                    .Where(TempCamp.DistrictName == districtName & TempCamp.RoundName==roundName1 & TempCamp.ClusterName==clusterName & TempCamp.ProvinceName==provName));

                    if (TempC == null)
                        TempC = new TempCampaignRow
                        {
                            DistrictName = districtName,
                            RoundName=roundName1,
                            ClusterName=clusterName,
                            ProvinceName=provName
                        };
                    else
                    {
                        // avoid assignment errors
                        TempC.TrackWithChecks = false;
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

                        TempC.RoundId = round.RoundId.Value;
                    }
                    else
                        TempC.RoundId = null;

                    var Province = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Province))
                    {
                        var round = uow.Connection.TryFirst<ProvinceRow>(q => q
                            .Select(prov.ProvinceId)
                            .Where(prov.Pname == Province));

                        if (TempC == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Province with name '" +
                                Province + "' is not found!");
                            continue;
                        }

                        TempC.ProvinceId = round.ProvinceId.Value;
                    }
                    else
                        TempC.ProvinceId = null;

                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(dName))
                    {
                        var district = uow.Connection.TryFirst<DistrictRow>(q => q
                            .Select(d.DistrictId)
                            .Where(d.Pname ==Province &  d.Dcode == dName));

                        if (dName == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                dName + "' is not found!");
                            continue;
                        }

                        TempC.DistrictId = district.DistrictId.Value;
                    }
                    else
                        TempC.DistrictId = null;


                    var Cluster = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(Cluster))
                    {
                        var round = uow.Connection.TryFirst<ClusterRow>(q => q
                            .Select(clc.ClusterId)
                            .Where(clc.Cname == Cluster & clc.DistrictDcode ==districtName & clc.Province ==Province ));

                        if (Cluster == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Cluster with name '" +
                                Cluster + "' is not found!");
                            continue;
                        }

                        TempC.ClusterId = round.ClusterId.Value;
                    }
                    else
                        TempC.ClusterId = null;

                    TempC.LDPTypes = Convert.ToString(worksheet.Cells[row, 6].Value ?? "");
                    TempC.PemtremtManager= Convert.ToString(worksheet.Cells[row, 7].Value ?? "");
                    TempC.DateOfCampaign= Convert.ToDateTime(worksheet.Cells[row, 8].Value ?? "");
                    TempC.TargetU5Case = Convert.ToInt32(worksheet.Cells[row, 9].Value ?? 0);
                    TempC.TeamNo = Convert.ToString(worksheet.Cells[row, 10].Value ?? "");
                    TempC.HhNo = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0);

                    //Day 1
                    TempC.D1VialDist = Convert.ToInt16(worksheet.Cells[row, 12].Value ?? 0); 
                    TempC.D1VialUse = Convert.ToInt16(worksheet.Cells[row, 13].Value ?? 0);
                    TempC.D1Vac011Months  = Convert.ToInt16(worksheet.Cells[row, 14].Value ?? 0);
                    TempC.D1Vac1259months= Convert.ToInt16(worksheet.Cells[row, 15].Value ?? 0);
                    TempC.D1RecAbsChildren = Convert.ToInt16(worksheet.Cells[row, 16].Value ?? 0);
                    TempC.D1VacAbsChildren = Convert.ToInt16(worksheet.Cells[row, 17].Value ?? 0);
                    TempC.D1RecNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 18].Value ?? 0);
                    TempC.D1VacNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 19].Value ?? 0);
                    TempC.D1RecRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 20].Value ?? 0);
                    TempC.D1RevacRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 21].Value ?? 0);
                    TempC.D1AfpCase = Convert.ToInt16(worksheet.Cells[row, 22].Value ?? 0);

                    //Day 2
                    TempC.D2VialDist = Convert.ToInt16(worksheet.Cells[row, 23].Value ?? 0); 
                    TempC.D2VialUse = Convert.ToInt16(worksheet.Cells[row, 24].Value ?? 0);
                    TempC.D2Vac011Months = Convert.ToInt16(worksheet.Cells[row, 25].Value ?? 0);
                    TempC.D2Vac1259months = Convert.ToInt16(worksheet.Cells[row, 26].Value ?? 0);
                    TempC.D2RecAbsChildren = Convert.ToInt16(worksheet.Cells[row, 27].Value ?? 0);
                    TempC.D2VacAbsChildren = Convert.ToInt16(worksheet.Cells[row, 28].Value ?? 0);
                    TempC.D2RecNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 29].Value ?? 0);
                    TempC.D2VacNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 30].Value ?? 0);
                    TempC.D2RecRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 31].Value ?? 0);
                    TempC.D2RevacRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 32].Value ?? 0);
                    TempC.D2AfpCase = Convert.ToInt16(worksheet.Cells[row, 33].Value ?? 0);

                    //Day 3
                    TempC.D3VialDist = Convert.ToInt16(worksheet.Cells[row, 34].Value ?? 0); 
                    TempC.D3VialUse = Convert.ToInt16(worksheet.Cells[row, 35].Value ?? 0);
                    TempC.D3Vac011Months = Convert.ToInt16(worksheet.Cells[row, 36].Value ?? 0);
                    TempC.D3Vac1259months = Convert.ToInt16(worksheet.Cells[row, 37].Value ?? 0);
                    TempC.D3RecAbsChildren = Convert.ToInt16(worksheet.Cells[row, 38].Value ?? 0);
                    TempC.D3VacAbsChildren = Convert.ToInt16(worksheet.Cells[row, 39].Value ?? 0);
                    TempC.D3RecNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 40].Value ?? 0);
                    TempC.D3VacNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 41].Value ?? 0);
                    TempC.D3RecRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 42].Value ?? 0);
                    TempC.D3RevacRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 43].Value ?? 0);
                    TempC.D3AfpCase = Convert.ToInt16(worksheet.Cells[row, 44].Value ?? 0);
                    
                    //Day 5
                    TempC.D5VialDist = Convert.ToInt16(worksheet.Cells[row, 45].Value ?? 0); 
                    TempC.D5VialUse = Convert.ToInt16(worksheet.Cells[row, 46].Value ?? 0);
                    TempC.D5Vac011Months = Convert.ToInt16(worksheet.Cells[row, 47].Value ?? 0);
                    TempC.D5Vac1259months = Convert.ToInt16(worksheet.Cells[row, 48].Value ?? 0);
                    TempC.D5RecAbsChildren = Convert.ToInt16(worksheet.Cells[row, 49].Value ?? 0);
                    TempC.D5VacAbsChildren = Convert.ToInt16(worksheet.Cells[row, 50].Value ?? 0);
                    TempC.D5RecNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 51].Value ?? 0);
                    TempC.D5VacNewbornSsc = Convert.ToInt16(worksheet.Cells[row, 52].Value ?? 0);
                    TempC.D5RecRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 53].Value ?? 0);
                    TempC.D5RevacRefusedChildren = Convert.ToInt16(worksheet.Cells[row, 54].Value ?? 0);
                    TempC.D5AfpCase = Convert.ToInt16(worksheet.Cells[row, 55].Value ?? 0);

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

                        TempC.TenantId = Users.TenantId.Value;
                    }
                    else
                        TempC.TenantId = null;


                    if (TempC.TempCampaignId == null)
                    {
                        new TempCampaignRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = TempC
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new TempCampaignRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = TempC,
                            EntityId = TempC.TempCampaignId.Value
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

        public void ExecProcedure(IDbConnection connection)
        {
            connection.Execute("InsCampaignDay", commandType: CommandType.StoredProcedure);
            connection.Execute("InsDailyVaccinations", commandType: CommandType.StoredProcedure);
            connection.Execute("DelTempCampaign", commandType: CommandType.StoredProcedure);
        }

        //public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        //{
        //    ListResponse<MyRow> rr = new ListResponse<MyRow>();
        //    //rr.Entities = (List<MyRow>)connection.Query<MyRow>("InsCampaignDay", commandType: CommandType.StoredProcedure);
        //    rr.Entities = connection.Query<MyRow>("InsCampaignDay", commandType: CommandType.StoredProcedure).ToList();
        //    connection.Execute("InsDailyVaccinations", commandType: CommandType.StoredProcedure);
        //    connection.Execute("DelTempCampaign", commandType: CommandType.StoredProcedure);
        //    return rr;
        //}
    }
}