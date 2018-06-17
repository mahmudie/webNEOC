

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Implementation/IcmSupervisor", typeof(webNEOC.Implementation.Pages.IcmSupervisorController))]

namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/IcmSupervisor"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.IcmSupervisorRow))]
    public class IcmSupervisorController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/IcmSupervisor/IcmSupervisorIndex.cshtml");
        }
    }
}