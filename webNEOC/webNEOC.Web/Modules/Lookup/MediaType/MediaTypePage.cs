
namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/MediaType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MediaTypeRow))]
    public class MediaTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/MediaType/MediaTypeIndex.cshtml");
        }
    }
}