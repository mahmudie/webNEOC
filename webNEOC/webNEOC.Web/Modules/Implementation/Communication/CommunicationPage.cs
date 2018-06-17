
namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/Communication"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CommunicationRow))]
    public class CommunicationController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/Communication/CommunicationIndex.cshtml");
        }
    }
}