

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Implementation/VitaminAVaccinations", typeof(webNEOC.Implementation.Pages.VitaminAVaccinationsController))]

namespace webNEOC.Implementation.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Implementation/VitaminAVaccinations"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.VitaminAVaccinationsRow))]
    public class VitaminAVaccinationsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Implementation/VitaminAVaccinations/VitaminAVaccinationsIndex.cshtml");
        }
    }
}