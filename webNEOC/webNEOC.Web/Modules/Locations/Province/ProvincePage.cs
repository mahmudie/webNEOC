

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Locations/Province", typeof(webNEOC.Locations.Pages.ProvinceController))]

namespace webNEOC.Locations.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Locations/Province"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProvinceRow))]
    public class ProvinceController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Locations/Province/ProvinceIndex.cshtml");
        }
    }
}