

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "PostCampaign/OutOfHouseSurvey", typeof(webNEOC.PostCampaign.Pages.OutOfHouseSurveyController))]

namespace webNEOC.PostCampaign.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Post Campaign/OutOfHouseSurvey"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OutOfHouseSurveyRow))]
    public class OutOfHouseSurveyController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/PostCampaign/OutOfHouseSurvey/OutOfHouseSurveyIndex.cshtml");
        }
    }
}