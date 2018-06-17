

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Implementation/IcmTeam", typeof(webNEOC.Implementation.Pages.IcmTeamController))]

namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/IcmTeam"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.IcmTeamRow))]
    public class IcmTeamController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/IcmTeam/IcmTeamIndex.cshtml");
        }
    }
}