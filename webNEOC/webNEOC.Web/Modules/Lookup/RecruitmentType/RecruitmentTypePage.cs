
namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/RecruitmentType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RecruitmentTypeRow))]
    public class RecruitmentTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/RecruitmentType/RecruitmentTypeIndex.cshtml");
        }
    }
}