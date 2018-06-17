

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Campaign/DailyVaccinations", typeof(webNEOC.Campaign.Pages.DailyVaccinationsController))]

namespace webNEOC.Campaign.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/DailyVaccinations"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DailyVaccinationsRow))]
    public class DailyVaccinationsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Campaign/DailyVaccinations/DailyVaccinationsIndex.cshtml");
        }
    }
}