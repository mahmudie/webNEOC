using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webNEOC.Models.Dashboard;
using webNEOC.Controllers.Testkeys;
using Serenity.Data;

namespace webNEOC.Controllers
{
    [RoutePrefix("Dash"), Route("{action=index}")]
    [PageAuthorize(typeof(DashboardViewer))]
    public class DashController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\Campaign analysis and sureveillance.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }
        public ActionResult SurvDash()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\Surveillance.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }
        [ReadPermission(DashboardPermissionKeys.Surveillance.View)]
        public ActionResult Surveillance()
        {
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.opv.View)]
        public ActionResult opv()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\Campaign analysis.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        public ActionResult Dash()
        {
            return View();
        }

        public ActionResult VitaminADash()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\Child immunization Vitamin A.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }
        [ReadPermission(DashboardPermissionKeys.VitA.View)]
        public ActionResult VitA()
        {
            return View();
        }
        public ActionResult pcmDash()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\Post Campaign Assessment.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.pcm.View)]
        public ActionResult pcm()
        {
            return View();
        }

        public ActionResult Missedchildren()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\WHO\\\\Missed children.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.mc.View)]
        public ActionResult mc()
        {
            return View();
        }
        public ActionResult fmChildren()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\WHO\\\\Children with finger mark.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.fm.View)]
        public ActionResult fm()
        {
            return View();
        }


        public ActionResult lqasAcceptance()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\WHO\\\\LQAS survey acceptance.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.lqas.View)]
        public ActionResult lqas()
        {
            return View();
        }

        public ActionResult adminCoverage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\WHO\\\\Administrative coverage.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.admin.View)]
        public ActionResult admin()
        {
            return View();
        }

        public ActionResult icnnpage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\ICN Records # stacked chart.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.icnn.View)]
        public ActionResult icnn()
        {
            return View();
        }
        public ActionResult icnppage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\ICN Records % and # stacked chart.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.icnp.View)]
        public ActionResult icnp()
        {
            return View();
        }

        public ActionResult icnrpage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\ICN Records region and period.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.icnr.View)]
        public ActionResult icnr()
        {
            return View();
        }
        public ActionResult icnpppage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\ICN Records province and period.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.icnpp.View)]
        public ActionResult icnpp()
        {
            return View();
        }

        public ActionResult icndpage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\ICN Records district and period.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.icnd.View)]
        public ActionResult icnd()
        {
            return View();
        }

        public ActionResult icncpage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\ICN Records cluster and period.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.icnc.View)]
        public ActionResult icnc()
        {
            return View();
        }

        public ActionResult mediapage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\Communication.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.media.View)]
        public ActionResult media()
        {
            return View();
        }

        public ActionResult recruitmentpage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\UNICEF\\\\ICN Deployment.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.media.View)]
        public ActionResult recruitment()
        {
            return View();
        }

        public ActionResult adminnpage()
        {
            ViewBag.DashboardPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\") + "Dashboards\\\\WHO\\\\Administrative coverage-number.sydx";
            DashboardViewer dashboardViewer = new DashboardViewer();
            ViewBag.ServiceUrl = dashboardViewer.ServiceUrl;
            return View();
        }

        [ReadPermission(DashboardPermissionKeys.media.View)]
        public ActionResult adminn()
        {
            return View();
        }
    }
}