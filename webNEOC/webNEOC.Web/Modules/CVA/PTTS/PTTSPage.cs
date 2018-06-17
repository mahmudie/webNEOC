

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "CVA/PTTS", typeof(webNEOC.CVA.Pages.PTTSController))]

namespace webNEOC.CVA.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("CVA/PTTS"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PTTSRow))]
    public class PTTSController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/CVA/PTTS/PTTSIndex.cshtml");
        }
    }
}