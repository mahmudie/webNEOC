

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Post Campaign/PCM", typeof(webNEOC.PostCampaign.Pages.PcmController))]

namespace webNEOC.PostCampaign.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Post Campaign/PCM"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PcmRow))]
    public class PcmController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/PostCampaign/Pcm/PcmIndex.cshtml");
        }
    }
}