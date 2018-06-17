

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "ImportGate/TempVitaminA", typeof(webNEOC.ImportGate.Pages.TempVitaminAController))]

namespace webNEOC.ImportGate.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ImportGate/TempVitaminA"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TempVitaminARow))]
    public class TempVitaminAController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ImportGate/TempVitaminA/TempVitaminAIndex.cshtml");
        }
    }
}