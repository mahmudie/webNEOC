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
using webNEOC.Controllers.Testkeys;
using Serenity.Data;
using Serenity.Web;
using System.ComponentModel.DataAnnotations.Schema;
using webNEOC.Models;
using System.Linq;

namespace webNEOC.Controllers
{

    public class PreCampData
    {
        public string Id { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string LPDs { get; set; }
        public string Round { get; set; }
        public int Year { get; set; }
        public string StrictCorrdMeeting { get; set; }
        public string MicroPlanUpdated { get; set; }
        public string UpdateDistrictSupMonPlan { get; set; }
        public string SocMobPlanAvail { get; set; }
        public string MultiSectPlan { get; set; }
        public string SIAsSelected { get; set; }
        public double? PercFLWPaid { get; set; }
        public double? PercSocFLWPaid { get; set; }
        public double? PercVolTrained { get; set; }
        public string FLWsPlanUpdated { get; set; }
        public string IECMatDisplayed { get; set; }
        public string OPVRec { get; set; }
        public string ParentId { get; set; }
    }

    [ReadPermission(DashboardPermissionKeys.Dashboard.View)]
    [InsertPermission(DashboardPermissionKeys.Dashboard.Insert)]
    [UpdatePermission(DashboardPermissionKeys.Dashboard.Update)]
    [DeletePermission(DashboardPermissionKeys.Dashboard.Delete)]

    [RoutePrefix("PreCamp"), Route("{action=index}")]
    [PageAuthorize()]
    public class PreCampController : Controller
    {
        private readonly ContextANL _context = new ContextANL();
        private readonly Context _db = new Context();
        [Authorize]
        public ActionResult Index()
        {
            YearDetails yr = new YearDetails();
            //RoundDetails round = new RoundDetails();
           
            //ViewData["RoundList"] = new SelectList(Rounds, "Id","text", "value");

            ViewBag.dataSource = GetLQASData();
            ViewBag.yearSource = yr.GetYearCollection();
            List<Round> Rounds = _context.Rounds.ToList();
            Rounds.Insert(0, new Round { RoundId = 0, ReportRoundName = "All" });
            ViewData["RoundList"] = new SelectList(Rounds, "RoundId", "ReportRoundName");

            List<Models.TreeGrid.Regions> Regions = _db.Regionlist.ToList();
            ViewBag.regionSource = new SelectList(Regions, "RegionName");

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
                yearCollection.Add(new Year() { id = 2, text = "2018", value = "2018" });
                return yearCollection;
            }
        }

        //public class RoundDetails
        //{
        //    public List<Roundx> GetRoundCollection()
        //    {
        //        List<Roundx> roundCollection = new List<Roundx>();
        //        roundCollection.Add(new Roundx() { id = 1, text = "SNID_201711", value = "SNID_201711" });
        //        roundCollection.Add(new Roundx() { id = 2, text = "SNID_201709", value = "SNID_201709" });
        //        roundCollection.Add(new Roundx() { id = 3, text = "NID_201708", value = "NID_201708" });
        //        roundCollection.Add(new Roundx() { id = 4, text = "FCMP_201710", value = "FCMP_201710" });
        //        return roundCollection;
        //    }
        //}

        public List<PreCampData> GetLQASData()
        {
            List<PreCampData> list = new List<PreCampData>();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["DTA"].ConnectionString);//connectionString
            con.Open();

            using (con)
            {
                using (var command = con.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Precampaign ";

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfCol1 = reader.GetOrdinal("Id");
                        var indexOfCol2 = reader.GetOrdinal("Region");
                        var indexOfCol3 = reader.GetOrdinal("Province");
                        var indexOfCol4 = reader.GetOrdinal("District");
                        var indexOfCol5 = reader.GetOrdinal("LPDs");
                        var indexOfCol6 = reader.GetOrdinal("Round");
                        var indexOfCol7 = reader.GetOrdinal("Year");
                        var indexOfCol8 = reader.GetOrdinal("StrictCorrdMeeting");
                        var indexOfCol9 = reader.GetOrdinal("MicroPlanUpdated");
                        var indexOfCol10 = reader.GetOrdinal("UpdateDistrictSupMonPlan");
                        var indexOfCol11 = reader.GetOrdinal("SocMobPlanAvail");
                        var indexOfCol13 = reader.GetOrdinal("MultiSectPlan");                
                        var indexOfCol14 = reader.GetOrdinal("SIAsSelected");

                        var indexOfCol15 = reader.GetOrdinal("PercFLWPaid");
                        var indexOfCol16 = reader.GetOrdinal("PercSocFLWPaid");
                        var indexOfCol17 = reader.GetOrdinal("PercVolTrained");

                        var indexOfCol18 = reader.GetOrdinal("FLWsPlanUpdated");
                        var indexOfCol19 = reader.GetOrdinal("IECMatDisplayed");
                        var indexOfCol20 = reader.GetOrdinal("ParentId");
                        var indexOfCol21 = reader.GetOrdinal("OPVRec");

                        while (reader.Read())
                        {
                            PreCampData obj = new PreCampData();
                            obj.Id = reader.GetValue(indexOfCol1).ToString();
                            obj.Region = reader.GetValue(indexOfCol2).ToString();
                            obj.Province = reader.GetValue(indexOfCol3).ToString();
                            obj.District = reader.GetValue(indexOfCol4).ToString();
                            obj.LPDs = reader.GetValue(indexOfCol5).ToString();
                            obj.Round = reader.GetValue(indexOfCol6).ToString();
                            obj.Year = Convert.ToInt32(reader.GetValue(indexOfCol7));
                            obj.StrictCorrdMeeting = reader.GetValue(indexOfCol8).ToString();
                            obj.MicroPlanUpdated = reader.GetValue(indexOfCol9).ToString();
                            obj.UpdateDistrictSupMonPlan = reader.GetValue(indexOfCol10).ToString();
                            obj.SocMobPlanAvail = reader.GetValue(indexOfCol11).ToString();
                            obj.MultiSectPlan = reader.GetValue(indexOfCol13).ToString();
                            obj.SIAsSelected = reader.GetValue(indexOfCol14).ToString();

                            obj.PercFLWPaid = Convert.ToDouble(reader.GetValue(indexOfCol15));
                            obj.PercSocFLWPaid = Convert.ToDouble(reader.GetValue(indexOfCol16));
                            obj.PercVolTrained = Convert.ToDouble(reader.GetValue(indexOfCol17));

                            obj.FLWsPlanUpdated =reader.GetValue(indexOfCol18).ToString();

                            obj.IECMatDisplayed = reader.GetValue(indexOfCol19).ToString();
                            obj.ParentId = reader.GetValue(indexOfCol20).ToString();
                            obj.OPVRec= reader.GetValue(indexOfCol21).ToString();

                            //Need to read value from correct column index
                            obj.ParentId=(reader.GetValue(indexOfCol20).ToString() == "") ? null : reader.GetValue(indexOfCol20).ToString();
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

            if (data.Column != 1 && data.Column != 2 && data.Column != 3 && data.Column != 4 && data.Column != 5 && data.Column != 6 && data.Column != 7 && data.Column != 8 && data.Column != 9 && data.Column != 10 && data.Column != 11 && data.Column != 12 && data.Column != 16 && data.Column != 17 && data.Column != 18)
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
            if (data.Column != 1 && data.Column != 2 && data.Column != 3 && data.Column != 4 && data.Column != 5 && data.Column != 6 && data.Column != 13 && data.Column != 14 && data.Column != 15)
            {
                if (data.Value=="Yes")
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.LightGreen);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.Black;
                }
                if (data.Value == "No")
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.Red);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.Black;
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
            exp.Export(obj, DataSource, "PreCampaign.xlsx", ExcelVersion.Excel2013, new TreeGridExportSettings() { Theme = ExportTheme.FlatAzure });
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
