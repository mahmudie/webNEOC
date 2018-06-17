

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "PostCampaign/LQAS", typeof(webNEOC.PostCampaign.Pages.LQASController))]

namespace webNEOC.PostCampaign.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Post Campaign/LQAS"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.LQASRow))]
    public class LQASController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/PostCampaign/LQAS/LQASIndex.cshtml");
        }
    }
}