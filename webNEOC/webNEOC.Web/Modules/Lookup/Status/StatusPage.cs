

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/Status", typeof(webNEOC.Lookup.Pages.StatusController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Status"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.StatusRow))]
    public class StatusController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Status/StatusIndex.cshtml");
        }
    }
}