

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Preparation/Microplan", typeof(webNEOC.Preparation.Pages.MicroplanController))]

namespace webNEOC.Preparation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Preparation/Microplan"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MicroplanRow))]
    public class MicroplanController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Preparation/Microplan/MicroplanIndex.cshtml");
        }
    }
}