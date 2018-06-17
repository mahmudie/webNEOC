

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Lookup/Vehicletype", typeof(webNEOC.Lookup.Pages.VehicletypeController))]

namespace webNEOC.Lookup.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Lookup/Vehicletype"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.VehicletypeRow))]
    public class VehicletypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Lookup/Vehicletype/VehicletypeIndex.cshtml");
        }
    }
}