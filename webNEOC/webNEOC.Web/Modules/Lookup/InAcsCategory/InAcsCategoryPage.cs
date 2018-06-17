

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/InAcsCategory", typeof(webNEOC.Lookup.Pages.InAcsCategoryController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/InAcsCategory"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.InAcsCategoryRow))]
    public class InAcsCategoryController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/InAcsCategory/InAcsCategoryIndex.cshtml");
        }
    }
}