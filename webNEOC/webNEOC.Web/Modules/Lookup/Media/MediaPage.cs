
namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Media"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MediaRow))]
    public class MediaController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Media/MediaIndex.cshtml");
        }
    }
}