using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Configuration;
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;
using Syncfusion.JavaScript.Models;
using System.Reflection;
using System.Web.Script.Serialization;
using webNEOC.Models;
using System.Drawing;
using Serenity.Web;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace webNEOC.Controllers
{

    public class AdminCoverageData
    {
        [Key]
        public string Id { get; set; }
        [Key]
        public string Region { get; set; }
        public int Year { get; set; }
        public string Round { get; set; }
        public string TypeOfCampaign { get; set; }
        public Int64 TargetPop { get; set; }
        public double? PercVacCoverage { get; set; }
        public Int64? MissedChildren { get; set; }
        public double? PercRecovDay1 { get; set; }
        public double? PercRecovDay2 { get; set; }
        public double? PercRecovDay3 { get; set; }
        public double? PercRecovDay5 { get; set; }
        public double? PercNSSRecovered { get; set; }
        public string ParentId { get; set; }
    }

    [RoutePrefix("Regional"), Route("{action=index}")]
    [PageAuthorize()]
    public class AdminCoverageController : Controller
    {
        private readonly ContextANL _context2 = new ContextANL();
        private readonly Context _db = new Context();
        public ActionResult Index()
        {
            YearDetails yr = new YearDetails();
            RoundDetails round = new RoundDetails();

            ViewBag.dataSource = GetLQASData();
            ViewBag.yearSource = yr.GetYearCollection();
            //ViewBag.roundSource = round.GetRoundCollection();

            List<Round> Rounds = _context2.Rounds.ToList();
            Rounds.Insert(0, new Round { RoundId = 0, ReportRoundName = "All" });
            ViewData["RoundList"] = new SelectList(Rounds, "RoundId", "ReportRoundName");

            List<Models.TreeGrid.Regions> Regions =_db.Regionlist.ToList();
            ViewBag.regionSource = new SelectList(Regions, "RegionName");
            return View();
        }

        public class Stage
        {
            public int id { get; set; }
            public string text { get; set; }
            public string value { get; set; }
        }
        public class Year
        {
            public int id { get; set; }
            public string text { get; set; }
            public string value { get; set; }
        }
        public class YearDetails
        {
            public List<Year> GetYearCollection()
            {
                List<Year> yearCollection = new List<Year>();

                yearCollection.Add(new Year() { id = 1, text = "2016", value = "2016" });
                yearCollection.Add(new Year() { id = 2, text = "2017", value = "2017" });
                return yearCollection;
            }
        }

        //public class Round
        //{
        //    public int id { get; set; }
        //    public string text { get; set; }
        //    public string value { get; set; }
        //}
        public class RoundDetails
        {
            //public List<Round> GetRoundCollection()
            //{
            //    List<Round> roundCollection = new List<Round>();
            //    //roundCollection.Add(new Round() { id = 1, text = "SNID_201709", value = "SNID_201709" });
            //    //roundCollection.Add(new Round() { id = 2, text = "SNID_201707", value = "SNID_201707" });
            //    //roundCollection.Add(new Round() { id = 3, text = "NID_201705", value = "NID_201705" });
            //    //roundCollection.Add(new Round() { id = 4, text = "SNID_201705", value = "SNID_201705" });
            //    //roundCollection.Add(new Round() { id = 5, text = "SNID_201704", value = "SNID_201704" });
            //    //roundCollection.Add(new Round() { id = 6, text = "NID_201704", value = "NID_201704" });
            //    //roundCollection.Add(new Round() { id = 7, text = "NID_201703", value = "NID_201703" });          
            //    //roundCollection.Add(new Round() { id = 8, text = "SNID_201703", value = "SNID_201703" });
            //    //roundCollection.Add(new Round() { id = 9, text = "SNID_201702", value = "SNID_201702" });
            //    //roundCollection.Add(new Round() { id = 19, text = "SNID_201701", value = "SNID_201701" });
            //    //roundCollection.Add(new Round() { id = 12, text = "FCMP_201708", value = "FCMP_201708" });
            //    //roundCollection.Add(new Round() { id = 13, text = "SNID_201612", value = "SNID_201612" });
            //    //roundCollection.Add(new Round() { id = 14, text = "SNID_201611", value = "SNID_201611" });
            //    //roundCollection.Add(new Round() { id = 15, text = "NID_201610", value = "NID_201610" });
            //    //roundCollection.Add(new Round() { id = 16, text = "NID_201609", value = "NID_201609" });
            //    //roundCollection.Add(new Round() { id = 17, text = "NID_201608", value = "NID_201608" });
            //    return roundCollection;
            //}
        }

        public List<AdminCoverageData> GetLQASData()
        {
            List<AdminCoverageData> list = new List<AdminCoverageData>();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["DTA"].ConnectionString);//connectionString
            con.Open();

            using (con)
            {
                using (var command = con.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Coverage_region";

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfCol1 = reader.GetOrdinal("Id");
                        var indexOfCol3 = reader.GetOrdinal("Year");
                        var indexOfCol4 = reader.GetOrdinal("Round");
                        var indexOfCol5 = reader.GetOrdinal("TypeOfCampaign");
                        var indexOfCol6 = reader.GetOrdinal("TargetPop");
                        var indexOfCol7 = reader.GetOrdinal("PercVacCoverage");
                        var indexOfCol8 = reader.GetOrdinal("MissedChildren");
                        var indexOfCol9 = reader.GetOrdinal("PercRecovDay1");
                        var indexOfCol10 = reader.GetOrdinal("PercRecovDay2");
                        var indexOfCol11 = reader.GetOrdinal("PercRecovDay3");

                        var indexOfCol13 = reader.GetOrdinal("PercRecovDay5");
                        var indexOfCol14 = reader.GetOrdinal("PercNSSRecovered");
                        var indexOfCol15 = reader.GetOrdinal("Region");
                        var indexOfCol16 = reader.GetOrdinal("ParentId");

                        while (reader.Read())
                        {
                            AdminCoverageData obj = new AdminCoverageData();
                            obj.Id = reader.GetValue(indexOfCol1).ToString();
                            obj.Year = Convert.ToInt32(reader.GetValue(indexOfCol3));
                            obj.Round = reader.GetValue(indexOfCol4).ToString();
                            obj.TypeOfCampaign = reader.GetValue(indexOfCol5).ToString();
                            obj.TargetPop = Convert.ToInt64(reader.GetValue(indexOfCol6));
                            obj.PercVacCoverage = Convert.ToDouble(reader.GetValue(indexOfCol7));
                            obj.MissedChildren = Convert.ToInt64(reader.GetValue(indexOfCol8));
                            obj.PercRecovDay1 = Convert.ToDouble(reader.GetValue(indexOfCol9));
                            obj.PercRecovDay2 = Convert.ToDouble(reader.GetValue(indexOfCol10));
                            obj.PercRecovDay3 = Convert.ToDouble(reader.GetValue(indexOfCol11));

                            obj.PercRecovDay5 = Convert.ToDouble(reader.GetValue(indexOfCol13));
                            obj.PercNSSRecovered = Convert.ToDouble(reader.GetValue(indexOfCol14));
                            obj.Region = reader.GetValue(indexOfCol15).ToString();
                            obj.ParentId = reader.GetValue(indexOfCol16).ToString();
                            //Need to read value from correct column index
                            obj.ParentId=(reader.GetValue(indexOfCol16).ToString() == "") ? null : reader.GetValue(indexOfCol16).ToString();
                            list.Add(obj);
                        }
                        reader.Close();
                    }
                }
                con.Close();
            }
            return list;
        }



        TreeGridProperties.TreeGridEJExportEventHandler queryCellDelegate = new TreeGridProperties.TreeGridEJExportEventHandler(ExcelQueryEvent);

        public static void ExcelQueryEvent(object sender, object args)
        {
            var data = (IRange)args;

            if (data.Column != 1 && data.Column != 2 && data.Column != 3 && data.Column != 4 && data.Column != 5 && data.Column != 7)
            {
                if (float.Parse(data.Value) >0 & float.Parse(data.Value) < 80)
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.OrangeRed);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.YellowCustom;
                }
                if (float.Parse(data.Value) >= 80 && float.Parse(data.Value) < 90)
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.Yellow);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.Black;
                }
                if (float.Parse(data.Value) >= 90)
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.LightGreen);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.Yellow;
                }
            }
        }
        public void ExportToPdf(string TreeGridModel)
        {
            PdfExport exp = new PdfExport();
            var DataSource = this.GetLQASData();
            TreeGridProperties obj = ConvertTreeGridObject(TreeGridModel);
            exp.Export(obj, DataSource, new TreeGridExportSettings() { Theme = ExportTheme.FlatSaffron }, "Export");
        }
        [HttpPost()]
        [ValidateAntiForgeryToken]
        public void ExportToExcel(string TreeGridModel)
        {
            ExcelExport exp = new ExcelExport();
            var DataSource = this.GetLQASData();
            TreeGridProperties obj = ConvertTreeGridObject(TreeGridModel);
            obj.ServerExcelQueryCellInfo = queryCellDelegate;
            exp.Export(obj, DataSource, "Regional_coverage.xlsx", ExcelVersion.Excel2013, new TreeGridExportSettings() { Theme = ExportTheme.FlatAzure });
        }

        private TreeGridProperties ConvertTreeGridObject(string gridProperty)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            IEnumerable div = (IEnumerable)serializer.Deserialize(gridProperty, typeof(IEnumerable));
            TreeGridProperties gridProp = new TreeGridProperties();
            foreach (KeyValuePair<string, object> ds in div)
            {
                var property = gridProp.GetType().GetProperty(ds.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
                if (property != null)
                {
                    Type type = property.PropertyType;
                    string serialize = serializer.Serialize(ds.Value);
                    object value = serializer.Deserialize(serialize, type);
                    property.SetValue(gridProp, value, null);
                }
            }
            return gridProp;
        }
    }
}
