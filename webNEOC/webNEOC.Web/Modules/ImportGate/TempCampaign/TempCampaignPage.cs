

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ImportGate/TempCampaign", typeof(webNEOC.ImportGate.Pages.TempCampaignController))]

namespace webNEOC.ImportGate.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ImportGate/TempCampaign"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TempCampaignRow))]
    public class TempCampaignController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ImportGate/TempCampaign/TempCampaignIndex.cshtml");
        }
    }
}