
namespace webNEOC.Campaign.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Campaign/AdminData"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AdminDataRow))]
    public class AdminDataController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Campaign/AdminData/AdminDataIndex.cshtml");
        }
    }
}