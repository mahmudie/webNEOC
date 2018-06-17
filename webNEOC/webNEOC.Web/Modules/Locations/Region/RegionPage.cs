

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Locations/Region", typeof(webNEOC.Locations.Pages.RegionController))]

namespace webNEOC.Locations.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Locations/Region"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RegionRow))]
    public class RegionController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Locations/Region/RegionIndex.cshtml");
        }
    }
}