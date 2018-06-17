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

namespace webNEOC.Controllers
{

    public class LQASData
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public string Measure { get; set; }
        public int TargetPop { get; set; }
        public double? NID_201603 { get; set; }
        public double? NID_201605 { get; set; }
        public double? NID_201608 { get; set; }
        public double? NID_201611 { get; set; }
        public double? NID_201703 { get; set; }
        public double? NID_201705 { get; set; }
        public double? NID_201708 { get; set; }
        public double? SNID_201602 { get; set; }
        public double? SNID_201604 { get; set; }
        public double? SNID_201611 { get; set; }
        public double? SNID_201612 { get; set; }
        public double? SNID_201701 { get; set; }
        public double? SNID_201702 { get; set; }
        public double? SNID_201704 { get; set; }
        public double? SNID_201707 { get; set; }
        public string parentId { get; set; }
    }
    [RoutePrefix("LQASChart"), Route("{action=index}")]
    [PageAuthorize()]
    public class LQASChartController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.dataSource = GetLQASData();
            return View();
        }


        public List<LQASData> GetLQASData()
        {
            List<LQASData> list = new List<LQASData>();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Default"].ConnectionString);//connectionString
            con.Open();

            using (con)
            {
                using (var command = con.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM allLQAS";

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfCol1 = reader.GetOrdinal("Id");
                        var indexOfCol2 = reader.GetOrdinal("Location");
                        var indexOfCol3 = reader.GetOrdinal("Measure");
                        var indexOfCol4 = reader.GetOrdinal("TargetPop");
                        var indexOfCol5 = reader.GetOrdinal("NID_201603");
                        var indexOfCol6 = reader.GetOrdinal("NID_201605");
                        var indexOfCol7 = reader.GetOrdinal("NID_201608");
                        var indexOfCol8 = reader.GetOrdinal("NID_201611");
                        var indexOfCol9 = reader.GetOrdinal("NID_201703");
                        var indexOfCol10 = reader.GetOrdinal("NID_201705");
                        var indexOfCol11 = reader.GetOrdinal("NID_201708");

                        var indexOfCol13 = reader.GetOrdinal("SNID_201602");
                        var indexOfCol14 = reader.GetOrdinal("SNID_201604");
                        var indexOfCol15 = reader.GetOrdinal("SNID_201611");
                        var indexOfCol16 = reader.GetOrdinal("SNID_201612");
                        var indexOfCol17 = reader.GetOrdinal("SNID_201701");
                        var indexOfCol18 = reader.GetOrdinal("SNID_201702");
                        var indexOfCol19 = reader.GetOrdinal("SNID_201704");
                        var indexOfCol20 = reader.GetOrdinal("SNID_201707");
                        var indexOfCol21 = reader.GetOrdinal("parentId");

                        while (reader.Read())
                        {
                            LQASData obj = new LQASData();
                            obj.Id = reader.GetValue(indexOfCol1).ToString();
                            obj.Location = reader.GetValue(indexOfCol2).ToString();
                            obj.Measure = reader.GetValue(indexOfCol3).ToString();
                            obj.TargetPop = Convert.ToInt32(reader.GetValue(indexOfCol4));
                            obj.NID_201603 = Convert.ToDouble(reader.GetValue(indexOfCol5));
                            obj.NID_201605 = Convert.ToDouble(reader.GetValue(indexOfCol6));
                            obj.NID_201608 = Convert.ToDouble(reader.GetValue(indexOfCol7));
                            obj.NID_201611 = Convert.ToDouble(reader.GetValue(indexOfCol8));
                            obj.NID_201703 = Convert.ToDouble(reader.GetValue(indexOfCol9));
                            obj.NID_201705 = Convert.ToDouble(reader.GetValue(indexOfCol10));
                            obj.NID_201708 = Convert.ToDouble(reader.GetValue(indexOfCol11));

                            obj.SNID_201602 = Convert.ToDouble(reader.GetValue(indexOfCol13));
                            obj.SNID_201604 = Convert.ToDouble(reader.GetValue(indexOfCol14));
                            obj.SNID_201611 = Convert.ToDouble(reader.GetValue(indexOfCol15));
                            obj.SNID_201612 = Convert.ToDouble(reader.GetValue(indexOfCol16));
                            obj.SNID_201701 = Convert.ToDouble(reader.GetValue(indexOfCol17));
                            obj.SNID_201702 = Convert.ToDouble(reader.GetValue(indexOfCol18));
                            obj.SNID_201704 = Convert.ToDouble(reader.GetValue(indexOfCol19));
                            obj.SNID_201707 = Convert.ToDouble(reader.GetValue(indexOfCol20));
                            //Need to read value from correct column index
                            obj.parentId=(reader.GetValue(indexOfCol21).ToString() == "") ? null : reader.GetValue(indexOfCol21).ToString();
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

            if (data.Column != 1 && data.Column != 2 && data.Column != 3 && data.Column != 4)
            {
                if (float.Parse(data.Value) > 0 & float.Parse(data.Value) < 80.1)
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.LightGreen);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.Red;
                }
                if (float.Parse(data.Value) >= 80.1 && float.Parse(data.Value) < 90)
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.Yellow);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.Red2;
                }
                if (float.Parse(data.Value) >= 90)
                {
                    data.CellStyle.Color = ColorConversion.GetColor(Color.Red);
                    data.CellStyle.PatternColorIndex = ExcelKnownColors.Pink;
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
        public void ExportToExcel(string TreeGridModel)
        {
            ExcelExport exp = new ExcelExport();
            var DataSource = this.GetLQASData();
            TreeGridProperties obj = ConvertTreeGridObject(TreeGridModel);
            obj.ServerExcelQueryCellInfo = queryCellDelegate;
            exp.Export(obj, DataSource, "LQAS_Chart.xlsx", ExcelVersion.Excel2010, new TreeGridExportSettings() { Theme = ExportTheme.FlatSaffron });
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
