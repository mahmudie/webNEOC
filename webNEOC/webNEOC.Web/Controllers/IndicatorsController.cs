using webNEOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.Data.Entity;
using Syncfusion.XlsIO;
using System.IO;
using Serenity.Data;
using webNEOC.Controllers.Testkeys;
using Syncfusion.XlsIO.Implementation.PivotTables;

namespace webNEOC.Controllers
{
    [RoutePrefix("Indicators"), Route("{action=Index}")]
    [Authorize()]
    public class IndicatorsController : Controller
    {
        private readonly ContextANL _context = new ContextANL();

        // GET: IndDistrict
        [Authorize()]
        public ActionResult Index()
        {

            List<Round> Rounds = _context.Rounds.ToList();
            Rounds.Insert(0, new Round { RoundId = 0, ReportRoundName = "All" });
            ViewData["RoundList"] = new SelectList(Rounds, "RoundId", "ReportRoundName");

            List<Region> Regions = _context.Regions.ToList();
            Regions.Insert(0, new Region { RegionId = 0, Rname = "All" });
            ViewData["RegionList"] = new SelectList(Regions, "RegionId", "Rname");

            return View();
        }

        [ReadPermission(DashboardPermissionKeys.IndDistrict.View)]
        public ActionResult DistInd([Bind(Include = "Region,Province,District,Round,Measure")] requestfilter req)
        {
            Int16 Region;
            Int16 Province;
            Int16 District;
            Int16 Round;
            string Measure;

            Region = req.Region;
            Province = req.Province;
            District = req.District;
            Round = req.Round;
            Measure = req.Measure;

            var data = _context.IndDistircts.Select
                (x => new
                {
                    Region = x.Region,
                    Province = x.Province,
                    District = x.District,
                    Year = x.Year,
                    Month = x.Month,
                    Round = x.Round,
                    ShorName = x.ShortName,
                    Indicator = x.Indicator,
                    Measure = x.Measure,
                    Numerator = x.Numerator,
                    Denominator = x.Denominator,
                    RegionId = x.RegionId,
                    ProvinceId = x.ProvinceId,
                    DistrictId = x.DistrictId,
                    RoundId = x.RoundId,
                    CampaignType = x.CampaignType,
                    Form = x.Form

                }
                ).ToList();

            if (!Region.Equals(0) & !Province.Equals(0) & !District.Equals(0))
            {
                data = data.Where(m => m.RegionId.Equals(Region) & m.ProvinceId.Equals(Province) & m.DistrictId.Equals(District)).ToList();
            }

            else if (!Region.Equals(0) & !Province.Equals(0))
            {
                data = data.Where(m => m.RegionId.Equals(Region) & m.ProvinceId.Equals(Province)).ToList();
            }

            else if (!Region.Equals(0))
            {
                data = data.Where(m => m.RegionId.Equals(Region)).ToList();
            }


            if (!Round.Equals(0))
            {
                data = data.Where(m => m.RoundId.Equals(Round)).ToList();
            }


            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2013;

            IWorkbook workbook;
            workbook = application.Workbooks.Create(3);
            IWorksheet sheet = workbook.Worksheets[0];

            if (!data.Any())
            {
                return HttpNotFound();
            }

            sheet.ImportData(data, 1, 1, true);

            sheet.Name = "Data";
            IWorksheet pivotSheet = workbook.Worksheets[1];
            pivotSheet.Name = "Percentage";

            IPivotCache cash_data = workbook.PivotCaches.Add(sheet[sheet.Range.AddressLocal]);
            //Adding calculated fields to cache.
            PivotCacheFieldImpl Result = (cash_data as PivotCacheImpl).CacheFields.AddNewField("Result", "Numerator/Denominator");
            PivotCacheFieldImpl Result2 = (cash_data as PivotCacheImpl).CacheFields.AddNewField("Result2", "Numerator*1");

            //Percentage indicator - Pivot Table (Percentage)
            #region "Percentage Pivot Table"
            IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A5"], cash_data);

            IPivotField field = pivotTable.Fields["Result"];
            pivotTable.DataFields.Add(field, "%", PivotSubtotalTypes.Sum);

            pivotTable.Fields["Region"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Province"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["District"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["CampaignType"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Round"].Axis = PivotAxisTypes.Page;

            pivotTable.Fields["Year"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Month"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Measure"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Form"].Axis = PivotAxisTypes.Page;

            pivotTable.Fields["Indicator"].Axis = PivotAxisTypes.Row;


            IPivotField num = pivotTable.Fields["Numerator"];
            IPivotField denom = pivotTable.Fields["Denominator"];
            if (Measure.Equals("1"))
            {
                pivotTable.Fields["Region"].Axis = PivotAxisTypes.Column;
                pivotSheet["A2"].Text = "Indicators comparison by region";
            }
            else if (Measure.Equals("2"))
            {
                pivotTable.Fields["Province"].Axis = PivotAxisTypes.Column;
                pivotSheet["A2"].Text = "Indicators comparison by province";
            }
            else if (Measure.Equals("3"))
            {
                pivotTable.Fields["District"].Axis = PivotAxisTypes.Column;
                pivotSheet["A2"].Text = "Indicators comparison by district";
            }
            else if (Measure.Equals("4"))
            {
                pivotTable.Fields["Year"].Axis = PivotAxisTypes.Column;
                pivotSheet["A2"].Text = "Indicators comparison by year";
            }
            else if (Measure.Equals("5"))
            {
                pivotTable.Fields["Year"].Axis = PivotAxisTypes.Column;
                pivotTable.Fields["Month"].Axis = PivotAxisTypes.Column;
                pivotSheet["A2"].Text = "Indicators comparison by month";

                IPivotField pivotField = pivotTable.Fields["Month"];
                pivotField.Sort(new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            }

            pivotSheet.Range["A2"].CellStyle.Font.Size = 14f;
            pivotSheet.Range["A2"].CellStyle.Font.Bold = true;
            pivotSheet.Range["A3"].Text = "Date extracted: " + DateTime.Now.ToString(); ;
            pivotSheet.Range["A3"].CellStyle.Font.Size = 10f;
            pivotSheet.Range["A3"].CellStyle.Font.Bold = true;
            pivotSheet.Range["A3"].CellStyle.Font.Italic = true;


            pivotTable.Fields["Measure"].Axis = PivotAxisTypes.Page;
            IPivotField pageField = pivotTable.Fields["Measure"];
            pageField.Items[0].Visible = false;


            pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
            pivotTable.ColumnGrand = false;
            pivotTable.RowGrand = false;
            PivotTableOptions pivotOption = pivotTable.Options as PivotTableOptions;
            pivotOption.ShowGridDropZone = true;
            IPivotTableOptions option = pivotTable.Options;
            option.ErrorString = "NA";
            option.ColumnHeaderCaption = "CompareBy";
            option.RowHeaderCaption = "Indicator";


            #endregion

            //Number indicator - Pivot Table (Numeric)
            #region "Numeric Pivot Table"

            IWorksheet pivotSheet2 = workbook.Worksheets[2];

            pivotSheet2.Name = "Numeric";
            IPivotTable pivotTable2 = pivotSheet2.PivotTables.Add("PivotTable2", pivotSheet["A5"], cash_data);


            IPivotField field2 = pivotTable2.Fields["Result2"];
            pivotTable2.DataFields.Add(field2, "#", PivotSubtotalTypes.Sum);

            pivotTable2.Fields["Region"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["Province"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["District"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["CampaignType"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["Round"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["Year"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["Month"].Axis = PivotAxisTypes.Page;

            pivotTable2.Fields["Form"].Axis = PivotAxisTypes.Page;

            pivotTable2.Fields["Indicator"].Axis = PivotAxisTypes.Row;


            IPivotField num2 = pivotTable2.Fields["Numerator"];
            IPivotField denom2 = pivotTable2.Fields["Denominator"];
            if (Measure.Equals("1"))
            {
                pivotTable2.Fields["Region"].Axis = PivotAxisTypes.Column;
                pivotSheet2["A2"].Text = "Indicators comparison by region";
            }
            else if (Measure.Equals("2"))
            {
                pivotTable2.Fields["Province"].Axis = PivotAxisTypes.Column;
                pivotSheet2["A2"].Text = "Indicators comparison by province";
            }
            else if (Measure.Equals("3"))
            {
                pivotTable2.Fields["District"].Axis = PivotAxisTypes.Column;
                pivotSheet2["A2"].Text = "Indicators comparison by district";
            }
            else if (Measure.Equals("4"))
            {
                pivotTable2.Fields["Year"].Axis = PivotAxisTypes.Column;
                pivotSheet2["A2"].Text = "Indicators comparison by year";
            }
            else if (Measure.Equals("5"))
            {
                pivotTable2.Fields["Year"].Axis = PivotAxisTypes.Column;
                pivotTable2.Fields["Month"].Axis = PivotAxisTypes.Column;
                pivotSheet2["A2"].Text = "Indicators comparison by month";
                IPivotField pivotField = pivotTable2.Fields["Month"];
                pivotField.Sort(new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            }

            pivotSheet2.Range["A2"].CellStyle.Font.Size = 14f;
            pivotSheet2.Range["A2"].CellStyle.Font.Bold = true;
            pivotSheet2.Range["A3"].Text = "Date extracted: " + DateTime.Now.ToString(); ;
            pivotSheet2.Range["A3"].CellStyle.Font.Size = 10f;
            pivotSheet2.Range["A3"].CellStyle.Font.Bold = true;
            pivotSheet2.Range["A3"].CellStyle.Font.Italic = true;

            pivotTable2.Fields["Measure"].Axis = PivotAxisTypes.Page;
            IPivotField pageField2 = pivotTable2.Fields["Measure"];
            pageField2.Items[1].Visible = false;

            pivotTable2.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
            pivotTable2.ColumnGrand = false;
            pivotTable2.RowGrand = false;
            PivotTableOptions pivotOption2 = pivotTable2.Options as PivotTableOptions;
            pivotOption2.ShowGridDropZone = true;
            IPivotTableOptions option2 = pivotTable2.Options;
            option2.ErrorString = "NA";
            option2.ColumnHeaderCaption = "CompareBy";
            option2.RowHeaderCaption = "Indicator";

            pivotTable.Fields["Result"].NumberFormat = "#.0%";
            pivotTable2.Fields["Result2"].NumberFormat = "#";

            (pivotTable.Options as PivotTableOptions).ShowGridDropZone = true;
            (pivotTable2.Options as PivotTableOptions).ShowGridDropZone = true;
            (pivotTable as PivotTableImpl).Cache.IsRefreshOnLoad = true;
            (pivotTable2 as PivotTableImpl).Cache.IsRefreshOnLoad = true;

            pivotSheet2.Range["A5"].Activate();
            pivotSheet2.Activate();
            #endregion

            string ContentType = "Application/msexcel";
            string filename = "Report_" + "donor" + "_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".xlsx";

            MemoryStream ms = new MemoryStream();
            workbook.SaveAs(ms);
            ms.Position = 0;
            workbook.Close();
            excelEngine.Dispose();
            return File(ms, ContentType, filename);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult districts(Int16 ProvinceId)
        {
            List<District> Districts = new List<District>();
            Districts = (from dist in _context.Districts where dist.ProvinceId == ProvinceId select dist).ToList();
            Districts.Insert(0, new District { DistrictId = 0, Dname = "All" });

            return Json(new SelectList(Districts, "DistrictId", "Dname"), JsonRequestBehavior.AllowGet);
        }

        public ActionResult provinces(Int16 RegionId)
        {
            List<Province> Provinces = new List<Province>();
            Provinces = (from dist in _context.Provinces where dist.RegionId == RegionId select dist).ToList();
            Provinces.Insert(0, new Province { ProvinceId = 0, Pname = "All" });

            return Json(new SelectList(Provinces, "ProvinceId", "Pname"), JsonRequestBehavior.AllowGet);
        }

        [Authorize()]
        public ActionResult Typetwo()
        {

            List<Round> Rounds = _context.Rounds.ToList();
            Rounds.Insert(0, new Round { RoundId = 0, ReportRoundName = "All" });
            ViewData["RoundList"] = new SelectList(Rounds, "RoundId", "ReportRoundName");

            List<Region> Regions = _context.Regions.ToList();
            Regions.Insert(0, new Region { RegionId = 0, Rname = "All" });
            ViewData["RegionList"] = new SelectList(Regions, "RegionId", "Rname");

            //List<Province> Povinces = _context.Provinces.ToList();
            //Povinces.Insert(0, new Province { ProvinceId = 0, Pname = "All" });
            //ViewData["ProvList"] = new SelectList(Povinces, "ProvinceId", "Pname");

            return View();
        }

        [ReadPermission(DashboardPermissionKeys.IndDistrict.View)]
        public ActionResult ProvInd([Bind(Include = "Region,Province,District,Round,Measure,Year")] requestfilter req)
        {
            Int16 Region;
            Int16 Province;
            Int16 District;
            Int16 Round;
            string Measure;
            string Year;
            //string Filter;

            Region = req.Region;
            Province = req.Province;
            District = req.District;
            Round = req.Round;
            Measure = req.Measure;
            Year = req.Year;
            //Filter = req.Filter;

            var data = _context.IndDistircts.Select
                (x => new
                {
                    Region = x.Region,
                    Province = x.Province,
                    District = x.District,
                    Year = x.Year,
                    Month = x.Month,
                    Round = x.Round,
                    ShorName = x.ShortName,
                    Indicator = x.Indicator,
                    Measure = x.Measure,
                    Numerator = x.Numerator,
                    Denominator = x.Denominator,
                    RegionId = x.RegionId,
                    ProvinceId = x.ProvinceId,
                    DistrictId = x.DistrictId,
                    RoundId = x.RoundId,
                    CampaignType = x.CampaignType,
                    Form = x.Form

                }
                ).ToList();

            if (!Region.Equals(0) & !Province.Equals(0) & !District.Equals(0))
            {
                data = data.Where(m => m.RegionId.Equals(Region) & m.ProvinceId.Equals(Province) & m.DistrictId.Equals(District)).ToList();
            }

            else if (!Region.Equals(0) & !Province.Equals(0))
            {
                data = data.Where(m => m.RegionId.Equals(Region) & m.ProvinceId.Equals(Province)).ToList();
            }

            else if (!Region.Equals(0))
            {
                data = data.Where(m => m.RegionId.Equals(Region)).ToList();
            }


            if (!Round.Equals(0))
            {
                data = data.Where(m => m.RoundId.Equals(Round)).ToList();
            }


            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2013;

            IWorkbook workbook;
            workbook = application.Workbooks.Create(3);
            IWorksheet sheet = workbook.Worksheets[0];

            if (!data.Any())
            {
                return HttpNotFound();
            }

            sheet.ImportData(data, 1, 1, true);

            sheet.Name = "Data";
            IWorksheet pivotSheet = workbook.Worksheets[1];

            pivotSheet.Name = "Percentage";

            IPivotCache cash_data = workbook.PivotCaches.Add(sheet[sheet.Range.AddressLocal]);

            //Adding calculated fields to cache.
            PivotCacheFieldImpl Result = (cash_data as PivotCacheImpl).CacheFields.AddNewField("Result", "Numerator/Denominator");
            PivotCacheFieldImpl Result2 = (cash_data as PivotCacheImpl).CacheFields.AddNewField("Result2", "Numerator*1");
            //Percentage indicator - Pivot Table - Percentage
            #region "Percentage Pivot Table"

            IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A5"], cash_data);

            IPivotField field = pivotTable.Fields["Result"];
            pivotTable.DataFields.Add(field, "%", PivotSubtotalTypes.Sum);

            pivotTable.Fields["Region"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Province"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["District"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["CampaignType"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Round"].Axis = PivotAxisTypes.Page;
            pivotTable.Fields["Form"].Axis = PivotAxisTypes.Page;

            pivotTable.Fields["Indicator"].Axis = PivotAxisTypes.Page;
            IPivotTableOptions option = pivotTable.Options;

            IPivotField num = pivotTable.Fields["Numerator"];
            IPivotField denom = pivotTable.Fields["Denominator"];
            if (Year.Equals("1"))
            {
                pivotTable.Fields["Year"].Axis = PivotAxisTypes.Column;
            }
            else if (Year.Equals("2"))
            {
                pivotTable.Fields["Year"].Axis = PivotAxisTypes.Column;
                pivotTable.Fields["Month"].Axis = PivotAxisTypes.Column;
                IPivotField pivotField = pivotTable.Fields["Month"];
                pivotField.Sort(new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            }
            if (Measure.Equals("1"))
            {
                pivotTable.Fields["Indicator"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("Year"))
                {
                    pivotSheet["A2"].Text = "Comparison of indicators over year";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "Indicator";
                }
                else
                {
                    pivotSheet["A2"].Text = "Indicators comparison over month";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Indicator";
                }
            }
            else if (Measure.Equals("2"))
            {
                pivotTable.Fields["Region"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("1"))
                {
                    pivotSheet["A2"].Text = "Comparison of region over years";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "Region";
                }
                else
                {
                    pivotSheet["A2"].Text = "Comparison of region over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Region";
                }
            }
            else if (Measure.Equals("3"))
            {
                pivotTable.Fields["Province"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("1"))
                {
                    pivotSheet["A2"].Text = "Comparison of province over years";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "Province";
                }
                else
                {
                    pivotSheet["A2"].Text = "Comparison of province over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Province";
                }
            }
            else if (Measure.Equals("4"))
            {
                pivotTable.Fields["District"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("1"))
                {
                    pivotSheet["A2"].Text = "Comparison of district over years";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "District";
                    pivotTable.Fields["Province"].PivotFilters.Add(PivotFilterType.CaptionEqual, null, "Helmand", null);

                }
                else
                {
                    pivotSheet["A2"].Text = "Comparison of district over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "District";
                }
            }
            pivotTable.Fields["Measure"].Axis = PivotAxisTypes.Page;

            pivotSheet.Range["A2"].CellStyle.Font.Size = 14f;
            pivotSheet.Range["A2"].CellStyle.Font.Bold = true;
            pivotSheet.Range["A3"].Text = "Date extracted: " + DateTime.Now.ToString(); ;
            pivotSheet.Range["A3"].CellStyle.Font.Size = 10f;
            pivotSheet.Range["A3"].CellStyle.Font.Bold = true;
            pivotSheet.Range["A3"].CellStyle.Font.Italic = true;

            //Hide number but show percentage
            IPivotField pageField = pivotTable.Fields["Measure"];
            pageField.Items[0].Visible = false;

            //pivotTable.Layout();

            pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
            pivotTable.ColumnGrand = false;
            pivotTable.RowGrand = false;
            PivotTableOptions pivotOption = pivotTable.Options as PivotTableOptions;
            pivotOption.ShowGridDropZone = true;
            option.ErrorString = "NA";


            // Applying conditional formatting to pivotRange
            //IConditionalFormats cfRange = workbook.Worksheets[1].UsedRange.ConditionalFormats;

            //IConditionalFormat condition = cfRange.AddCondition();
            //condition.FormatType = ExcelCFType.CellValue;

            //condition.Operator = ExcelComparisonOperator.Between;

            //condition.FirstFormula = "0";

            //condition.SecondFormula = "100";
            //condition.BackColor = ExcelKnownColors.Light_orange;

            //pivotSheet2.Activate();
            #endregion

            //Percentage indicator - Pivot Table - Percentage
            #region "Numeric Pivot Table"
            IWorksheet pivotSheet2 = workbook.Worksheets[2];

            pivotSheet2.Name = "Numeric";

            IPivotTable pivotTable2 = pivotSheet2.PivotTables.Add("PivotTable2", pivotSheet2["A5"], cash_data);

            IPivotField field2 = pivotTable2.Fields["Result2"];
            pivotTable2.DataFields.Add(field2, "#", PivotSubtotalTypes.Sum);

            pivotTable2.Fields["Region"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["Province"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["District"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["CampaignType"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["Round"].Axis = PivotAxisTypes.Page;
            pivotTable2.Fields["Form"].Axis = PivotAxisTypes.Page;

            pivotTable2.Fields["Indicator"].Axis = PivotAxisTypes.Page;
            IPivotTableOptions option2 = pivotTable2.Options;

            if (Year.Equals("1"))
            {
                pivotTable2.Fields["Year"].Axis = PivotAxisTypes.Column;
            }
            else if (Year.Equals("2"))
            {
                pivotTable2.Fields["Year"].Axis = PivotAxisTypes.Column;
                pivotTable2.Fields["Month"].Axis = PivotAxisTypes.Column;

                IPivotField pivotField = pivotTable2.Fields["Month"];
                pivotField.Sort(new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            }
            if (Measure.Equals("1"))
            {
                pivotTable2.Fields["Indicator"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("Year"))
                {
                    pivotSheet2["A2"].Text = "Comparison of indicators over year";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "Indicator";
                }
                else
                {
                    pivotSheet2["A2"].Text = "Indicators comparison over month";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Indicator";
                }
            }
            else if (Measure.Equals("2"))
            {
                pivotTable2.Fields["Region"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("1"))
                {
                    pivotSheet2["A2"].Text = "Comparison of region over years";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "Region";
                }
                else
                {
                    pivotSheet2["A2"].Text = "Comparison of region over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Region";
                }
            }
            else if (Measure.Equals("3"))
            {
                pivotTable2.Fields["Province"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("1"))
                {
                    pivotSheet2["A2"].Text = "Comparison of province over years";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "Province";
                }
                else
                {
                    pivotSheet2["A2"].Text = "Comparison of province over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Province";
                }
            }
            else if (Measure.Equals("4"))
            {
                pivotTable2.Fields["District"].Axis = PivotAxisTypes.Row;
                if (Year.Equals("1"))
                {
                    pivotSheet2["A2"].Text = "Comparison of district over years";
                    option.ColumnHeaderCaption = "Year";
                    option.RowHeaderCaption = "District";
                    pivotTable2.Fields["Province"].PivotFilters.Add(PivotFilterType.CaptionEqual, null, "Helmand", null);
                }
                else
                {
                    pivotSheet2["A2"].Text = "Comparison of district over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "District";

                }
            }
            pivotTable2.Fields["Measure"].Axis = PivotAxisTypes.Page;

            pivotSheet2.Range["A2"].CellStyle.Font.Size = 14f;
            pivotSheet2.Range["A2"].CellStyle.Font.Bold = true;
            pivotSheet2.Range["A3"].Text = "Date extracted: " + DateTime.Now.ToString(); ;
            pivotSheet2.Range["A3"].CellStyle.Font.Size = 10f;
            pivotSheet2.Range["A3"].CellStyle.Font.Bold = true;
            pivotSheet2.Range["A3"].CellStyle.Font.Italic = true;

            //Hide number but show percentage
            IPivotField pageField2 = pivotTable2.Fields["Measure"];
            pageField2.Items[1].Visible = false;


            pivotTable2.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
            pivotTable2.ColumnGrand = false;
            pivotTable2.RowGrand = false;
            PivotTableOptions pivotOption2 = pivotTable2.Options as PivotTableOptions;
            pivotOption2.ShowGridDropZone = true;
            pivotOption2.ErrorString = "NA";

            pivotTable.Fields["Result"].NumberFormat = "#.0%";
            pivotTable2.Fields["Result2"].NumberFormat = "#";

            (pivotTable.Options as PivotTableOptions).ShowGridDropZone = true;
            (pivotTable2.Options as PivotTableOptions).ShowGridDropZone = true;
            (pivotTable as PivotTableImpl).Cache.IsRefreshOnLoad = true;
            (pivotTable2 as PivotTableImpl).Cache.IsRefreshOnLoad = true;

            pivotSheet2.Activate();
            #endregion


            string ContentType = "Application/msexcel";
            string filename = "NEOC_" + "Indicators" + "_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".xlsx";

            MemoryStream ms = new MemoryStream();
            workbook.SaveAs(ms);
            ms.Position = 0;
            workbook.Close();
            excelEngine.Dispose();
            return File(ms, ContentType, filename);
        }
    }
}
