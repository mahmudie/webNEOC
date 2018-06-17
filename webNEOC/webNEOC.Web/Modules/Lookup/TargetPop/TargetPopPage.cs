namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/TargetPop"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TargetPopRow))]
    public class TargetPopController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/TargetPop/TargetPopIndex.cshtml");
        }
    }
}