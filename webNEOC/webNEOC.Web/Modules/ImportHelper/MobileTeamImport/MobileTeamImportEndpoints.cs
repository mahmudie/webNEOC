
namespace webNEOC.ImportHelper.Endpoints
{
    using Implementation.Entities;
    using OfficeOpenXml;
    using Implementation.Repositories;
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
    using MyRow = Implementation.Entities.MobileTeamRow;

    [RoutePrefix("Services/ImportHelper/MobileTeamImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class MobileTeamImportController : ServiceEndpoint
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

            var m = MobileTeamRow.Fields;
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
                    var provName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    var districtName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (districtName.IsTrimmedEmpty())
                        continue;

                    var mobileteam = uow.Connection.TryFirst<MobileTeamRow>(q => q
                    .Select(m.MobileTeamId)
                    .Where(m.DistrictDcode == districtName & m.RoundName==roundName1 & m.Province ==provName));

                    if (mobileteam == null)
                        mobileteam = new MobileTeamRow
                        {
                            Province =provName,
                            DistrictDcode = districtName,
                            RoundName =roundName1
                        };
                    else
                    {
                        // avoid assignment errors
                        mobileteam.TrackWithChecks = false;
                    }

                    var dName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(dName))
                    {
                        var district = uow.Connection.TryFirst<DistrictRow>(q => q
                            .Select(d.DistrictId)
                            .Where(d.Dcode == dName & d.Pname ==provName));

                        if (district == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                districtName + "' is not found!");
                            continue;
                        }

                        mobileteam.DistrictId = district.DistrictId.Value;
                    }
                    else
                        mobileteam.DistrictId = null;

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

                        mobileteam.RoundId = round.RoundId.Value;
                    }
                    else
                        mobileteam.RoundId = null;

                    mobileteam.Nomads = Convert.ToInt16(worksheet.Cells[row, 5].Value ?? 0);
                    mobileteam.Gypsis = Convert.ToInt16(worksheet.Cells[row, 6].Value ?? 0);
                    mobileteam.BlueMosque = Convert.ToInt16(worksheet.Cells[row, 7].Value ?? 0);
                    mobileteam.IDPs = Convert.ToInt16(worksheet.Cells[row, 8].Value ?? 0);
                    mobileteam.Returnees = Convert.ToInt16(worksheet.Cells[row, 9].Value ?? 0);
                    mobileteam.Kindergarden = Convert.ToInt16(worksheet.Cells[row, 10].Value ?? 0);
                    mobileteam.Madrasa = Convert.ToInt16(worksheet.Cells[row, 11].Value ?? 0);
                    mobileteam.EPICenters = Convert.ToInt16(worksheet.Cells[row, 12].Value ?? 0);
                    mobileteam.BusStation = Convert.ToInt16(worksheet.Cells[row, 13].Value ?? 0);
                    mobileteam.Prison = Convert.ToInt16(worksheet.Cells[row, 14].Value ?? 0);
                    mobileteam.MobileTeams = Convert.ToInt16(worksheet.Cells[row, 15].Value ?? 0);
                    mobileteam.CheckPost = Convert.ToInt16(worksheet.Cells[row, 16].Value ?? 0);
                    mobileteam.PrivateClinics = Convert.ToInt16(worksheet.Cells[row, 17].Value ?? 0);
                    mobileteam.Daramsal = Convert.ToInt16(worksheet.Cells[row, 18].Value ?? 0);
                    mobileteam.HotelGuestHouses = Convert.ToInt16(worksheet.Cells[row, 19].Value ?? 0);
                    mobileteam.Crosborder = Convert.ToInt16(worksheet.Cells[row, 20].Value ?? 0);
                    mobileteam.School = Convert.ToInt16(worksheet.Cells[row, 21].Value ?? 0);
                    mobileteam.Others = Convert.ToInt16(worksheet.Cells[row, 22].Value ?? 0);

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

                        mobileteam.TenantId = Users.TenantId.Value;
                    }
                    else
                        mobileteam.TenantId = null;

                    if (mobileteam.MobileTeamId == null)
                    {
                        new MobileTeamRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = mobileteam
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new MobileTeamRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = mobileteam,
                            EntityId = mobileteam.MobileTeamId.Value
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