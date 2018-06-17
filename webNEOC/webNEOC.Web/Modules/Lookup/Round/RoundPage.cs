

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/Round", typeof(webNEOC.Lookup.Pages.RoundController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Round"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RoundRow))]
    public class RoundController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Round/RoundIndex.cshtml");
        }
    }
}