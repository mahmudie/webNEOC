

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Campaign/Campaign", typeof(webNEOC.Campaign.Pages.CampaignController))]

namespace webNEOC.Campaign.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Campaign/Campaign"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CampaignRow))]
    public class CampaignController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Campaign/Campaign/CampaignIndex.cshtml");
        }
    }
}