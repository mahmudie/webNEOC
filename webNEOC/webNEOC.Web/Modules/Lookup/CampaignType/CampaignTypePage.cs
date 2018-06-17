

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/CampaignType", typeof(webNEOC.Lookup.Pages.CampaignTypeController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/CampaignType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CampaignTypeRow))]
    public class CampaignTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/CampaignType/CampaignTypeIndex.cshtml");
        }
    }
}