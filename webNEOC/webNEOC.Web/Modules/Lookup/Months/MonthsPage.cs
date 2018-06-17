

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/Months", typeof(webNEOC.Lookup.Pages.MonthsController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Months"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MonthsRow))]
    public class MonthsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Months/MonthsIndex.cshtml");
        }
    }
}