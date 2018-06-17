

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Implementation/IcmHousehold", typeof(webNEOC.Implementation.Pages.IcmHouseholdController))]

namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/IcmHousehold"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.IcmHouseholdRow))]
    public class IcmHouseholdController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/IcmHousehold/IcmHouseholdIndex.cshtml");
        }
    }
}