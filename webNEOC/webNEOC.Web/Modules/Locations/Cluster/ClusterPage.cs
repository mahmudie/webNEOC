

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Locations/Cluster", typeof(webNEOC.Locations.Pages.ClusterController))]

namespace webNEOC.Locations.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Locations/Cluster"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ClusterRow))]
    public class ClusterController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Locations/Cluster/ClusterIndex.cshtml");
        }
    }
}