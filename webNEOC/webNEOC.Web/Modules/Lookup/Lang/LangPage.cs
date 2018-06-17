
namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Lang"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.LangRow))]
    public class LangController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Lang/LangIndex.cshtml");
        }
    }
}