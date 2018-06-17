

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Preparation/InAccessible", typeof(webNEOC.Preparation.Pages.InAccessibleController))]

namespace webNEOC.Preparation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Preparation/InAccessible"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.InAccessibleRow))]
    public class InAccessibleController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Preparation/InAccessible/InAccessibleIndex.cshtml");
        }
    }
}