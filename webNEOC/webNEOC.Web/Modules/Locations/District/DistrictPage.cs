

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Locations/District", typeof(webNEOC.Locations.Pages.DistrictController))]

namespace webNEOC.Locations.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Locations/District"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DistrictRow))]
    public class DistrictController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Locations/District/DistrictIndex.cshtml");
        }
    }
}