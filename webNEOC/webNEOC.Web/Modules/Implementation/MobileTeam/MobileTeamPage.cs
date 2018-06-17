

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Implementation/MobileTeam", typeof(webNEOC.Implementation.Pages.MobileTeamController))]

namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/MobileTeam"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MobileTeamRow))]
    public class MobileTeamController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/MobileTeam/MobileTeamIndex.cshtml");
        }
    }
}