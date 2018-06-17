
namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/IcnType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.IcnTypeRow))]
    public class IcnTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/IcnType/IcnTypeIndex.cshtml");
        }
    }
}