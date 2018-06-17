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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Serenity.Web;
using Serenity.Data;
using webNEOC.Controllers.Testkeys;

namespace webNEOC.Controllers
{

    public class IntraCampData
    {
        public string Id { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string LPDs { get; set; }
        public string Round { get; set; }
        public int Year { get; set; }
        public double? percVacTrainedPreCamp { get; set; }
        public double? percResident { get; set; }
        public double? flwwith1CWH { get; set; }
        public double? vacBySupervisor { get; set; }
        public double? teamwithFemale { get; set; }
        public string ParentId { get; set; }
    }

    [ReadPermission(DashboardPermissionKeys.Dashboard.View)]
    [InsertPermission(DashboardPermissionKeys.Dashboard.Insert)]
    [UpdatePermission(DashboardPermissionKeys.Dashboard.Update)]
    [DeletePermission(DashboardPermissionKeys.Dashboard.Delete)]
    [RoutePrefix("IntraCamp"), Route("{action=index}")]
    [PageAuthorize()]
    public class IntraCampController : Controller
    {
        public ActionResult Index()
        {
            //YearDetails yr = new YearDetails();
            //RoundDetails round = new RoundDetails();

            ViewBag.dataSource = GetLQASData();
           // ViewBag.yearSource = yr.GetYearCollection();
            //ViewBag.roundSource = round.GetRoundCollection();
            return View();
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

        public class Round
        {
            public int id { get; set; }
            public string text { get; set; }
            public string value { get; set; }
        }
        public class RoundDetails
        {
            public List<Round> GetRoundCollection()
            {
                List<Round> roundCollection = new List<Round>();
                roundCollection.Add(new Round() { id = 1, text = "SNID_201708", value = "SNID_201708" });
                roundCollection.Add(new Round() { id = 2, text = "SNID_201707", value = "SNID_201707" });
                roundCollection.Add(new Round() { id = 3, text = "SNID_201705", value = "SNID_201705" });
                roundCollection.Add(new Round() { id = 4, text = "SNID_201704", value = "SNID_201704" });
                roundCollection.Add(new Round() { id = 5, text = "SNID_201703", value = "SNID_201703" });
                roundCollection.Add(new Round() { id = 6, text = "SNID_201702", value = "SNID_201702" });          
                roundCollection.Add(new Round() { id = 7, text = "SNID_201701", value = "SNID_201701" });
                return roundCollection;
            }
        }

        public List<IntraCampData> GetLQASData()
        {
            List<IntraCampData> list = new List<IntraCampData>();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["DTA"].ConnectionString);//connectionString
            con.Open();

            using (con)
            {
                using (var command = con.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM IntraCampaign";

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfCol1 = reader.GetOrdinal("Id");
                        var indexOfCol2 = reader.GetOrdinal("Region");
                        var indexOfCol3 = reader.GetOrdinal("Province");
                        var indexOfCol4 = reader.GetOrdinal("District");
                        var indexOfCol5 = reader.GetOrdinal("LPDs");
                        var indexOfCol6 = reader.GetOrdinal("Round");
                        var indexOfCol7 = reader.GetOrdinal("Year");
                        var indexOfCol8 = reader.GetOrdinal("percVacTrainedPreCamp");
                        var indexOfCol9 = reader.GetOrdinal("percResident");
                        var indexOfCol10 = reader.GetOrdinal("flwwith1CWH");
                        var indexOfCol11 = reader.GetOrdinal("vacBySupervisor");

                        var indexOfCol13 = reader.GetOrdinal("teamwithFemale");
                        var indexOfCol14 = reader.GetOrdinal("ParentId");

                        while (reader.Read())
                        {
                            IntraCampData obj = new IntraCampData();
                            obj.Id = reader.GetValue(indexOfCol1).ToString();
                            obj.Region = reader.GetValue(indexOfCol2).ToString();
                            obj.Province = reader.GetValue(indexOfCol3).ToString();
                            obj.District = reader.GetValue(indexOfCol4).ToString();
                            obj.LPDs = reader.GetValue(indexOfCol5).ToString();
                            obj.Round = reader.GetValue(indexOfCol6).ToString();
                            obj.Year = Convert.ToInt32(reader.GetValue(indexOfCol7));
                            obj.percVacTrainedPreCamp = Convert.ToDouble(reader.GetValue(indexOfCol8));
                            obj.percResident = Convert.ToDouble(reader.GetValue(indexOfCol9));
                            obj.flwwith1CWH = Convert.ToDouble(reader.GetValue(indexOfCol10));
                            obj.vacBySupervisor = Convert.ToDouble(reader.GetValue(indexOfCol11));
                            obj.teamwithFemale = Convert.ToDouble(reader.GetValue(indexOfCol13));
                            obj.ParentId = reader.GetValue(indexOfCol14).ToString();

        //Need to read value from correct column index
        obj.ParentId=(reader.GetValue(indexOfCol14).ToString() == "") ? null : reader.GetValue(indexOfCol14).ToString();
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

            if (data.Column != 1 && data.Column != 2 && data.Column != 3 && data.Column != 4 && data.Column != 5 && data.Column != 6)
            {
                if (float.Parse(data.Value) > 0 & float.Parse(data.Value) < 80)
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
            exp.Export(obj, DataSource, "IntraCampaign.xlsx", ExcelVersion.Excel2010, new TreeGridExportSettings() { Theme = ExportTheme.None });
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
