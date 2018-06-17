

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Implementation/VitaminA", typeof(webNEOC.Implementation.Pages.VitaminAController))]

namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/VitaminA"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.VitaminARow))]
    public class VitaminAController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/VitaminA/VitaminAIndex.cshtml");
        }
    }
}