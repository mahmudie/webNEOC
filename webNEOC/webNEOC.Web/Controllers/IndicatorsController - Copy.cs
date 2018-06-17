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
        private readonly ContextANL _context =new ContextANL();

        // GET: IndDistrict
        [Authorize()]
        public ActionResult Index()
        {
            //List<District> Districts = _context.Districts.ToList();
            //Districts.Insert(0, new District { DistrictId=0,Dname = "All" });
            //ViewData["DistrictList"] = new SelectList(Districts, "Districtid","Dname");

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
        public ActionResult DistInd([Bind(Include = "Region,Province,District,Round,Measure,Filter")] requestfilter req)
        {
            Int16 Region;
            Int16 Province;
            Int16 District;
            Int16 Round;
            string Measure;
            string Filter;

            Region =req.Region;
            Province = req.Province;
            District = req.District;
            Round = req.Round;
            Measure = req.Measure;
            Filter = req.Filter;

            var data = _context.IndDistircts.Select
                (x => new
                {
                    Region=x.Region,
                    Province=x.Province,
                    District=x.District,
                    Year =x.Year,
                    Month=x.Month,
                    Round=x.Round,
                    ShorName=x.ShortName,
                    Indicator=x.Indicator,
                    Measure=x.Measure,
                    Numerator=x.Numerator,
                    Denominator=x.Denominator,
                    RegionId=x.RegionId,
                    ProvinceId=x.ProvinceId,
                    DistrictId=x.DistrictId,
                    RoundId=x.RoundId,
                    CampaignType=x.CampaignType,
                    Form=x.Form

                }
                ).ToList()/*.Where(m=>m.Measure.Equals(Measure) & m.Denominator>0)*/;

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


            if(!Round.Equals(0))
            {
                data = data.Where(m => m.RoundId.Equals(Round)).ToList();
            }


            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2013;

            IWorkbook workbook;
            workbook = application.Workbooks.Create(2);
            IWorksheet sheet = workbook.Worksheets[0];

            if(!data.Any())
            {
                return HttpNotFound();
            }
          
                sheet.ImportData(data, 1, 1, true);

                sheet.Name = "Data";
                IWorksheet pivotSheet = workbook.Worksheets[1];
                pivotSheet.Name = "Result";


                IPivotCache cash_data = workbook.PivotCaches.Add(sheet[sheet.Range.AddressLocal]);
                //Percentage indicator
                IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A5"], cash_data);

                //IPivotTableOptions options = pivotTable.Options;

                pivotTable.Fields["Region"].Axis = PivotAxisTypes.Page;
                pivotTable.Fields["Province"].Axis = PivotAxisTypes.Page;
                pivotTable.Fields["District"].Axis = PivotAxisTypes.Page;
                pivotTable.Fields["CampaignType"].Axis = PivotAxisTypes.Page;
                pivotTable.Fields["Round"].Axis = PivotAxisTypes.Page;

                pivotTable.Fields["Year"].Axis = PivotAxisTypes.Page;
                pivotTable.Fields["Month"].Axis = PivotAxisTypes.Page;

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
                pivotField.Sort(new string[1] { pivotField.Items[1].Text });
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

            if (Filter == "%")
            {
                IPivotField Result = pivotTable.CalculatedFields.Add("Result", "Numerator/Denominator");
                Result.Name = " Result";
                Result.NumberFormat = "#.0%";
            }
            else if(Filter=="#")
            {
                IPivotField Result = pivotTable.CalculatedFields.Add("Result", "Numerator*1");
                Result.Name = " Result";
                Result.NumberFormat = "#";
            }

                //IPivotField pivotField = pivotTable.Fields[0];
                //pivotField.Sort(new string[1] { pivotField.Items[4].Text });

                pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
                pivotTable.ColumnGrand = false;
                pivotTable.RowGrand = false;
                PivotTableOptions pivotOption = pivotTable.Options as PivotTableOptions;
                pivotOption.ShowGridDropZone = true;
                IPivotTableOptions option = pivotTable.Options;
                option.ErrorString = "NA";
                option.ColumnHeaderCaption = "CompareBy";
                option.RowHeaderCaption = "Indicator";
                pivotSheet.Activate();
            
            //else if (Filter == "#")
            //{
            //    //Number indicator
            //    IWorksheet pivotSheet2 = workbook.Worksheets[1];

            //    pivotSheet2.Name = "Numeric";
            //    IPivotTable pivotTable2 = pivotSheet2.PivotTables.Add("PivotTable2", pivotSheet["A5"], cash_data);

            //    //IPivotTableOptions options2 = pivotTable2.Options;
            //    //options2.ShowFieldList = true;

            //    pivotTable2.Fields["Region"].Axis = PivotAxisTypes.Page;
            //    pivotTable2.Fields["Province"].Axis = PivotAxisTypes.Page;
            //    pivotTable2.Fields["District"].Axis = PivotAxisTypes.Page;
            //    pivotTable2.Fields["CampaignType"].Axis = PivotAxisTypes.Page;
            //    pivotTable2.Fields["Round"].Axis = PivotAxisTypes.Page;

            //    pivotTable2.Fields["Year"].Axis = PivotAxisTypes.Page;
            //    pivotTable2.Fields["Month"].Axis = PivotAxisTypes.Page;

            //    pivotTable2.Fields["Form"].Axis = PivotAxisTypes.Page;

            //    pivotTable2.Fields["Indicator"].Axis = PivotAxisTypes.Row;


            //    IPivotField num2 = pivotTable2.Fields["Numerator"];
            //    IPivotField denom2 = pivotTable2.Fields["Denominator"];
            //    if (Measure.Equals("1"))
            //    {
            //        pivotTable2.Fields["Region"].Axis = PivotAxisTypes.Column;
            //        pivotSheet2["A2"].Text = "Indicators comparison by region";
            //    }
            //    else if (Measure.Equals("2"))
            //    {
            //        pivotTable2.Fields["Province"].Axis = PivotAxisTypes.Page;
            //        pivotSheet2["A2"].Text = "Indicators comparison by province";
            //    }
            //    else if (Measure.Equals("3"))
            //    {
            //        pivotTable2.Fields["District"].Axis = PivotAxisTypes.Page;
            //        pivotSheet2["A2"].Text = "Indicators comparison by district";
            //    }
            //    else if (Measure.Equals("4"))
            //    {
            //        pivotTable2.Fields["Year"].Axis = PivotAxisTypes.Page;
            //        pivotSheet2["A2"].Text = "Indicators comparison by year";
            //    }
            //    else if (Measure.Equals("5"))
            //    {
            //        pivotTable2.Fields["Month"].Axis = PivotAxisTypes.Page;
            //        pivotSheet2["A2"].Text = "Indicators comparison by month";
            //    }

            //    pivotSheet2.Range["A2"].CellStyle.Font.Size = 14f;
            //    pivotSheet2.Range["A2"].CellStyle.Font.Bold = true;
            //    pivotSheet2.Range["A3"].Text = "Date extracted: " + DateTime.Now.ToString(); ;
            //    pivotSheet2.Range["A3"].CellStyle.Font.Size = 10f;
            //    pivotSheet2.Range["A3"].CellStyle.Font.Bold = true;
            //    pivotSheet2.Range["A3"].CellStyle.Font.Italic = true;

            //    IPivotField result2 = pivotTable2.CalculatedFields.Add("Result2", "Numerator*1");
            //    result2.Name = " #";
            //    result2.NumberFormat = "#";

            //    pivotTable2.Fields["Measure"].Axis = PivotAxisTypes.Page;
            //    IPivotField pageField2 = pivotTable2.Fields["Measure"];
            //    pageField2.Items[1].Visible = false;

            //    pivotTable2.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
            //    pivotTable2.ColumnGrand = false;
            //    pivotTable2.RowGrand = false;
            //    PivotTableOptions pivotOption2 = pivotTable2.Options as PivotTableOptions;
            //    pivotOption2.ShowGridDropZone = true;
            //    IPivotTableOptions option2 = pivotTable2.Options;
            //    option2.ErrorString = "NA";
            //    option2.ColumnHeaderCaption = "CompareBy";
            //    option2.RowHeaderCaption = "Indicator";

            //    pivotSheet2.Range["A5"].Activate();
            //    pivotSheet2.Activate();
            //}
            string ContentType = "Application/msexcel";
            string filename = "NEOC_" + "Indicators" + "_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".xlsx";

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
            Provinces = (from dist in _context.Provinces where dist.RegionId== RegionId select dist).ToList();
            Provinces.Insert(0, new Province { ProvinceId = 0, Pname = "All" });

            return Json(new SelectList(Provinces, "ProvinceId", "Pname") , JsonRequestBehavior.AllowGet);
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
        public ActionResult ProvInd([Bind(Include = "Region,Province,District,Round,Measure,Year,Filter")] requestfilter req)
        {
            Int16 Region;
            Int16 Province;
            Int16 District;
            Int16 Round;
            string Measure;
            string Year;
            string Filter;

            Region = req.Region;
            Province = req.Province;
            District = req.District;
            Round = req.Round;
            Measure = req.Measure;
            Year = req.Year;
            Filter = req.Filter;

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
                ).ToList()/*.Where(m=>m.Measure.Equals(Measure) & m.Denominator>0)*/;

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
            //Percentage indicator
            IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A5"], cash_data);

            //IPivotTableOptions options = pivotTable.Options;

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
            if(Year.Equals("1"))
            {
                pivotTable.Fields["Year"].Axis = PivotAxisTypes.Column;
            }
            else if (Year.Equals("2"))
            {
                pivotTable.Fields["Year"].Axis = PivotAxisTypes.Column;
                pivotTable.Fields["Month"].Axis = PivotAxisTypes.Column;
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
                    IPivotField pageField2 = pivotTable.Fields["Indicator"];
                    pageField2.Items[10].Visible = true;
                }
                else
                {
                    pivotSheet["A2"].Text = "Comparison of region over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Region";
                    IPivotField pageField2 = pivotTable.Fields["Indicator"];
                    pageField2.Items[10].Visible = true;
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
                    IPivotField pageField2 = pivotTable.Fields["Indicator"];
                    pageField2.Items[10].Visible = true;
                }
                else
                {
                    pivotSheet["A2"].Text = "Comparison of province over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "Province";
                    IPivotField pageField2 = pivotTable.Fields["Indicator"];
                    pageField2.Items[10].Visible = true;
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
                    pivotTable.Fields["Province"].PivotFilters.Add(PivotFilterType.CaptionEqual,null, "Helmand", null);

                    IPivotField pageField2 = pivotTable.Fields["Indicator"];
                    pageField2.Items[10].Visible = true;
                }
                else
                {
                    pivotSheet["A2"].Text = "Comparison of district over months";
                    option.ColumnHeaderCaption = "Year/Month";
                    option.RowHeaderCaption = "District";

                    IPivotField pageField2 = pivotTable.Fields["Indicator"];
                    pageField2.Items[10].Visible = true;

                    IPivotField pageField3 = pivotTable.Fields["Province"];
                    pageField3.Items[10].Visible = true;
                }
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

            if (Filter == "%")
            {
                IPivotField resultp = pivotTable.CalculatedFields.Add("Result", "Numerator/Denominator");
                resultp.Name = " Result";
                resultp.NumberFormat = "#.0%";
            }
            else if (Filter == "#")
            {
                IPivotField resultp = pivotTable.CalculatedFields.Add("Result", "Numerator*1");
                resultp.Name = " Result";
                resultp.NumberFormat = "#.0%";
            }

            pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleDark7;
            pivotTable.ColumnGrand = false;
            pivotTable.RowGrand = false;
            PivotTableOptions pivotOption = pivotTable.Options as PivotTableOptions;
            pivotOption.ShowGridDropZone = true;
            option.ErrorString = "NA";

            //pivotSheet.Range["A5"].Activate();


            pivotSheet.Activate();
            pivotSheet.Activate();

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
