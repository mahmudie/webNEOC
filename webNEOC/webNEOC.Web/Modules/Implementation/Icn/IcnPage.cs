

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Implementation/Icn", typeof(webNEOC.Implementation.Pages.IcnController))]

namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/Icn"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.IcnRow))]
    public class IcnController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/Icn/IcnIndex.cshtml");
        }
    }
}