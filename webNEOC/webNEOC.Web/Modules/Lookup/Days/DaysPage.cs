
namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Days"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DaysRow))]
    public class DaysController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Days/DaysIndex.cshtml");
        }
    }
}