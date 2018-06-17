

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/ClusterLevel", typeof(webNEOC.Lookup.Pages.ClusterLevelController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/ClusterLevel"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ClusterLevelRow))]
    public class ClusterLevelController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/ClusterLevel/ClusterLevelIndex.cshtml");
        }
    }
}