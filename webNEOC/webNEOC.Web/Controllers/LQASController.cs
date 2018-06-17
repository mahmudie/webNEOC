using Serenity.Web;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation.PivotTables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webNEOC.Models;

namespace webNEOC.Controllers.ExcelCharts
{
    [RoutePrefix("LQAS"), Route("{action=index}")]
    [PageAuthorize()]
    public class LQASController : Controller
    {
        private readonly ContextANL _context = new ContextANL();
        // GET: LQAS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateChart()
        {

            var data = _context.lqasLust.Select
                (x => new
                {
                    Region = x.Region,
                    Province = x.Province,
                    District = x.District,
                    Year = x.Year,
                    Month = x.Month,
                    Round = x.Round,
                    MonthName = x.MonthName,
                    Comments = x.Comments,
                    LotNo = x.LotNo
                }
                ).Where(m => m.Month < 5).ToList();


            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2013;

            IWorkbook templateWorkbook;
            templateWorkbook = application.Workbooks.Open(Server.MapPath("/App_Data/book1.xlsx"));

            IWorksheet sheet = templateWorkbook.Worksheets[0];

            IWorkbook workbook;
            workbook = application.Workbooks.Create(3);
            IWorksheet worksheet = workbook.Worksheets[0];

            if (!data.Any())
            {
                return HttpNotFound();
            }

            sheet.ImportData(data, 1, 1, true);

            sheet.Name = "Data";
            IWorksheet pivotSheet = templateWorkbook.Worksheets[1];
            pivotSheet.Name = "Pivot";

            IPivotCache cash_data = workbook.PivotCaches.Add(sheet[sheet.Range.AddressLocal]);

            //Percentage indicator - Pivot Table (Percentage)
            #region "Percentage Pivot Table"


            IWorksheet pivotTableSheet = templateWorkbook.Worksheets[1];
            IPivotTable pivotTable = pivotTableSheet.PivotTables[0];
            IPivotField pivotField = pivotTable.Fields["MonthName"];
            pivotField.Sort(new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });


            IChartShape pivotChartSheet = templateWorkbook.Worksheets[2].Charts[0];
            //Set the Pivot source for the Pivot Chart.
            pivotChartSheet.PivotSource = pivotTable;

            //Set the Pivot Chart Type.
            pivotChartSheet.PivotChartType = ExcelChartType.Column_Stacked_100;


            pivotChartSheet.Series[0].SerieFormat.CommonSerieOptions.Overlap = 100;
            pivotChartSheet.Series[0].SerieFormat.CommonSerieOptions.GapWidth = 10;


            pivotChartSheet.Series[0].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            pivotChartSheet.Series[1].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            pivotChartSheet.Series[2].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;


            pivotChartSheet.Series[0].SerieFormat.Fill.ForeColorIndex = ExcelKnownColors.LightGreen;
            pivotChartSheet.Series[1].SerieFormat.Fill.ForeColorIndex = ExcelKnownColors.Green;
            pivotChartSheet.Series[2].SerieFormat.Fill.ForeColorIndex = ExcelKnownColors.Red;


            pivotChartSheet.TopRow = 2;
            pivotChartSheet.BottomRow = 30;
            pivotChartSheet.LeftColumn = 1;
            pivotChartSheet.RightColumn = 20;

            pivotChartSheet.ChartTitle = "This is a sample chart";
            pivotChartSheet.ShowAllFieldButtons = false;

            (pivotTable as PivotTableImpl).Cache.SourceRange = sheet.UsedRange;

            pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
            pivotTable.ColumnGrand = false;
            pivotTable.RowGrand = false;
            PivotTableOptions pivotOption = pivotTable.Options as PivotTableOptions;
            pivotOption.ShowGridDropZone = true;
            IPivotTableOptions option = pivotTable.Options;
            option.ErrorString = "NA";

            #endregion


            (pivotTable.Options as PivotTableOptions).ShowGridDropZone = true;
            (pivotTable as PivotTableImpl).Cache.IsRefreshOnLoad = true;

            IWorksheet pivotChart = templateWorkbook.Worksheets[2];
            pivotChart.Name = "Chart";

            pivotChart.Activate();

            string ContentType = "Application/msexcel";
            string filename = "Report_" + "my" + "_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".xlsx";

            MemoryStream ms = new MemoryStream();
            templateWorkbook.SaveAs(ms);
            ms.Position = 0;
            workbook.Close();
            excelEngine.Dispose();
            return File(ms, ContentType, filename);
        }
    }
}