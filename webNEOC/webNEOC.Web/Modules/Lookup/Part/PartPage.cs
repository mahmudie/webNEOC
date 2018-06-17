

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/Part", typeof(webNEOC.Lookup.Pages.PartController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Part"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PartRow))]
    public class PartController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Part/PartIndex.cshtml");
        }
    }
}