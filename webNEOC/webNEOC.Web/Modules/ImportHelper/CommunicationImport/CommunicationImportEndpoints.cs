
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
    using MyRow = Implementation.Entities.CommunicationRow;
    using Implementation.Repositories;

    [RoutePrefix("Services/ImportHelper/CommunicationImport"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class CommunicationImportController : ServiceEndpoint
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

            var c = CommunicationRow.Fields;
            var lng = Administration.Entities.LanguageRow.Fields;
            var md = MediaRow.Fields;
            var mdt = MediaTypeRow.Fields;
            var part = DayPartRow.Fields;
            var usr = Administration.Entities.UserRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 3; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    var language = Convert.ToString(worksheet.Cells[row, 1].Value ?? "");
                    var mediatype = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    var media = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    var daypart = Convert.ToString(worksheet.Cells[row, 7].Value ?? "");

                    if (language.IsTrimmedEmpty())
                        continue;

                    var COM = uow.Connection.TryFirst<CommunicationRow>(q => q
                    .Select(c.CommunicationId)
                    .Where(c.LanguageLanguageName == language & c.MediaMediaName==media & c.MediaTypeMediaTypeName==mediatype & c.Daypart==daypart));

                    if (COM == null)
                        COM = new CommunicationRow
                        {
                            LanguageLanguageName = language,
                            MediaMediaName=media,
                            MediaTypeMediaTypeName=mediatype,
                            Daypart=daypart
                        };
                    else
                    {
                        // avoid assignment errors
                        COM.TrackWithChecks = false;
                    }

                    if (!string.IsNullOrWhiteSpace(language))
                    {
                        var lang = uow.Connection.TryFirst<Administration.Entities.LanguageRow>(q => q
                            .Select(lng.Id)
                            .Where(lng.LanguageName == language));

                        if (lang == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Round with name '" +
                                language + "' is not found!");
                            continue;
                        }

                        COM.LanguageId = lang.Id.Value;
                    }
                    else
                        COM.LanguageId = null;


                    if (!string.IsNullOrWhiteSpace(media))
                    {
                        var medias = uow.Connection.TryFirst<MediaRow>(q => q
                            .Select(md.MediaId)
                            .Where(md.MediaName == media));

                        if (medias == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Media with name '" +
                                media + "' is not found!");
                            continue;
                        }

                        COM.MediaId = medias.MediaId.Value;
                    }
                    else
                        COM.MediaId = null;

                    if (!string.IsNullOrWhiteSpace(mediatype))
                    {
                        var medias = uow.Connection.TryFirst<MediaTypeRow>(q => q
                            .Select(mdt.MediaTypeId)
                            .Where(mdt.MediaTypeName == mediatype));

                        if (medias == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Media Type with name '" +
                                mediatype + "' is not found!");
                            continue;
                        }

                        COM.MediaTypeId = medias.MediaTypeId.Value;
                    }
                    else
                        COM.MediaTypeId = null;


                    if (!string.IsNullOrWhiteSpace(daypart))
                    {
                        var dayspart = uow.Connection.TryFirst<DayPartRow>(q => q
                            .Select(part.DaypartId)
                            .Where(part.Daypart == daypart));

                        if (dayspart == null)
                        {
                            response.ErrorList.Add("Error On Row " + row + ": District with name '" +
                                daypart + "' is not found!");
                            continue;
                        }

                        COM.DaypartId = dayspart.DaypartId.Value;
                    }
                    else
                        COM.DaypartId = null;


                    object dateField = Convert.ToString(worksheet.Cells[row, 4].Value ?? 0);
                    if(dateField!=null)
                    {
                        if(dateField is double)
                        {
                            COM.BroadCastDate = DateTime.FromOADate((double)dateField);
                        }
                        else
                        {
                            DateTime.TryParse((string)dateField, out DateTime dt);
                        }
                    }

                   

                    String datetimefield = Convert.ToString(worksheet.Cells[row, 5].Value ?? 0);
                    double dtime = double.Parse(datetimefield);

                    //COM.BroadCastTime = TimeSpan.TicksPerMillisecond
                    COM.Duration = Convert.ToInt32(worksheet.Cells[row, 6].Value ?? 0);
                    COM.Source = Convert.ToString(worksheet.Cells[row, 8].Value ?? "");
                    
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

                        COM.TenantId = Users.TenantId.Value;
                    }
                    else
                        COM.TenantId = null;

                    if (COM.CommunicationId == null)
                    {
                        new CommunicationRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = COM
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new CommunicationRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = COM,
                            EntityId = COM.CommunicationId.Value
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