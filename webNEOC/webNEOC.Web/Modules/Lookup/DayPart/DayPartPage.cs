
namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/DayPart"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DayPartRow))]
    public class DayPartController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/DayPart/DayPartIndex.cshtml");
        }
    }
}