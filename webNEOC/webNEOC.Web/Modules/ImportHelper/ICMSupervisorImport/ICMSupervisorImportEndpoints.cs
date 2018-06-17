
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
    using MyRow = Implementation.Entities.IcmSupervisorRow;
    using Implementation.Repositories;

    [RoutePrefix("Services/ImportHelper/ICMSupervisorImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class ICMSupervisorImportController : ServiceEndpoint
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

            var Sup = IcmSupervisorRow.Fields;
            var d = DistrictRow.Fields;
            var r = RoundRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;
            var clc = ClusterRow.Fields;
            var vehi = VehicletypeRow.Fields;
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

                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var IcmSupervisor = uow.Connection.TryFirst<IcmSupervisorRow>(q => q
                    .Select(Sup.IcmSupervisorId)
                    .Where(Sup.DistrictDcode == districtName & Sup.RoundName==roundName1 & Sup.Cname==clusterName & Sup.PartPartName==partName));

                    if (IcmSupervisor == null)
                        IcmSupervisor = new IcmSupervisorRow
                        {
                            DistrictDcode = districtName,
                            RoundName=roundName1,
                            Cname=clusterName,
                            PartPartName=partName
                        };
                    else
                    {
                        // avoid assignment errors
                        IcmSupervisor.TrackWithChecks = false;
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

                        IcmSupervisor.RoundId = round.RoundId.Value;
                    }
                    else
                        IcmSupervisor.RoundId = null;


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

                        IcmSupervisor.DistrictId = district.DistrictId.Value;
                    }
                    else
                        IcmSupervisor.DistrictId = null;

                    var partname = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(partname))
                    {
                        var parts = uow.Connection.TryFirst<PartRow>(q => q
                            .Select(part.PartId)
                            .Where(part.PartName == partname));

                        if (dName == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                dName + "' is not found!");
                            continue;
                        }

                        IcmSupervisor.PartId = parts.PartId.Value;
                    }
                    else
                        IcmSupervisor.PartId = null;

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

                        IcmSupervisor.ClusterId = round.ClusterId.Value;
                    }
                    else
                        IcmSupervisor.ClusterId = null;

                    IcmSupervisor.ReportDate = DateTime.Now;
                    IcmSupervisor.Supervisor = Convert.ToString(worksheet.Cells[row, 8].Value ?? "");
                    IcmSupervisor.MonitorName = Convert.ToString(worksheet.Cells[row, 9].Value ?? "");
                    IcmSupervisor.IsSuperResidentOfArea = Convert.ToBoolean(worksheet.Cells[row, 10].Value ?? false);
                    IcmSupervisor.IsSuperTrained = Convert.ToBoolean(worksheet.Cells[row, 11].Value ?? false);
                    IcmSupervisor.IsSuperCarryOpv = Convert.ToBoolean(worksheet.Cells[row, 12].Value ?? false);
                    IcmSupervisor.IsSuperHasClearMap = Convert.ToBoolean(worksheet.Cells[row, 13].Value ?? false);
                    IcmSupervisor.IsSuperFillingHhChecklist = Convert.ToBoolean(worksheet.Cells[row, 14].Value ?? false);
                    IcmSupervisor.IsTransProviddToSuper = Convert.ToBoolean(worksheet.Cells[row, 15].Value ?? false);

                    var vehicle = Convert.ToString(worksheet.Cells[row, 16].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(vehicle))
                    {
                        var round = uow.Connection.TryFirst<VehicletypeRow>(q => q
                            .Select(vehi.VehicletypeId)
                            .Where(vehi.Typename == vehicle));

                        if (vehicle == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Vehicle with name '" +
                                vehicle + "' is not found!");
                            continue;
                        }

                        IcmSupervisor.VehicletypeId = round.VehicletypeId.Value;
                    }
                    else
                        IcmSupervisor.VehicletypeId = null;


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

                        IcmSupervisor.TenantId = Users.TenantId.Value;
                    }
                    else
                        IcmSupervisor.TenantId = null;


                    if (IcmSupervisor.IcmSupervisorId == null)
                    {
                        new IcmSupervisorRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcmSupervisor
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new IcmSupervisorRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = IcmSupervisor,
                            EntityId = IcmSupervisor.IcmSupervisorId.Value
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