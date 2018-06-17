
namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/IcnDeployment"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.IcnDeploymentRow))]
    public class IcnDeploymentController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/IcnDeployment/IcnDeploymentIndex.cshtml");
        }
    }
}