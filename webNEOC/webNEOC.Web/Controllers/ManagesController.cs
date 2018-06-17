using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webNEOC.Models;

namespace webNEOC.Controllers
{
    [RoutePrefix("Manages"), Route("{action=Index}")]
    public class ManagesController : Controller
    {
        private readonly Context db = new Context();
        [Authorize()]
        public ActionResult Index()
        {

            return View(db.formSubmission.ToList());
        }

        public ActionResult getData()
        {
            var data = db.formSubmission.Where(b => b.Active == true)
                 .Select(x => new
                 {
                     FormId =x.FormsubmissionId,
                     FormName = x.Form,
                     TotalRecorded = x.TotalRecorded,
                     TotalUnApproved = x.TotalUnapproved,
                     Url = x.Url
                 });
            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }

        [Authorize()]
        public ActionResult RunProcedure()
        {
            //string connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            //SqlConnection connect = new SqlConnection(connection);
            //SqlCommand cmd = new SqlCommand();
            //try
            //{
            //    connect.Open();
            //    cmd = new SqlCommand("[dbo].[execute_ssis_package]", connect);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.ExecuteNonQuery();
            //    //Dictionary<string, SqlParameter> procParameters = new Dictionary<string, SqlParameter>();
            //    //SqlParameter output_execution_id = new SqlParameter
            //    //{
            //    //    ParameterName= "@output_execution_id",
            //    //    Direction=ParameterDirection.Output,
            //    //    DbType=DbType.Int64
            //    //};
            //    //procParameters.Add("@output_execution_id", output_execution_id);
            //    //int rc = ExecSQLProcedure("EOC_v1", "dbo.execute_ssis_package", procParameters);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

            //try

            //{

            //    Application app = new Application();

            //    Package package = null;

            //    package = app.LoadPackage(@"‪C:\Users\EMISDb\Desktop\NEOC\EOC data need\NEOC_ETL\NEOC_ETL\99_Dash_WHO.dtsx", null);
            //    //Excute Package 

            //    Microsoft.SqlServer.Dts.Runtime.DTSExecResult results = package.Execute();

            //    if (results == Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Failure)

            //    {
            //        foreach (Microsoft.SqlServer.Dts.Runtime.DtsError local_DtsError in package.Errors)

            //        {
            //            Console.WriteLine("Package Execution results: {0}", local_DtsError.Description.ToString());

            //            Console.WriteLine();

            //        }

            //    }

            //}

            //catch (DtsException ex)
            //{
            //    throw;
            //}

            return Index();
        }

        //public static int ExecSQLProcedure(string connectionName,string storedProcName,Dictionary<string,SqlParameter> procParameters)
        //{
        //    string connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        //    int rc;
        //    using (SqlConnection connect = new SqlConnection(connection))
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = connect;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = storedProcName;
        //        foreach(var procParameter in procParameters)
        //        {
        //            cmd.Parameters.Add(procParameter.Value);
        //        }
        //        rc = cmd.ExecuteNonQuery();
        //    }
        //    return rc;
        //}
    }
}