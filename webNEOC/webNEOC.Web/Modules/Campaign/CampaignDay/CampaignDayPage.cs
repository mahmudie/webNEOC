

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Campaign/CampaignDay", typeof(webNEOC.Campaign.Pages.CampaignDayController))]

namespace webNEOC.Campaign.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/CampaignDay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CampaignDayRow))]
    public class CampaignDayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Campaign/CampaignDay/CampaignDayIndex.cshtml");
        }
    }
}