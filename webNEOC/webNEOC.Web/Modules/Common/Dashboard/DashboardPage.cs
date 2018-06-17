
namespace webNEOC.Common.Pages
{
    using Northwind;
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;
    using Locations;
    using PostCampaign.Entities;

    [RoutePrefix("Dashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        [Authorize, HttpGet, Route("~/")]
        public ActionResult Index()
        {
            var cachedModel = TwoLevelCache.GetLocalStoreOnly("DashboardPageModel", TimeSpan.FromMinutes(5),
             Locations.Entities.ProvinceRow.Fields.GenerationKey, () =>
            {
                var model = new DashboardPageModel();
                var o = Locations.Entities.ProvinceRow.Fields;

                using (var connection = SqlConnections.NewFor<Locations.Entities.ProvinceRow>())
                {
                    //model.OpenOrders = connection.Count<OrderRow>(o.ShippingState == (int)OrderShippingState.NotShipped);
                    //var closedOrders = connection.Count<OrderRow>(o.ShippingState == (int)OrderShippingState.Shipped);
                    //var totalOrders = model.OpenOrders + closedOrders;
                    //model.ClosedOrderPercent = (int)Math.Round(totalOrders == 0 ? 100 :
                    //    ((double)closedOrders / (double)totalOrders * 100));
                    //model.CustomerCount = connection.Count<CustomerRow>();
                    //model.ProductCount = connection.Count<ProductRow>();
                    model.TotalChildren = 234342;

                }

                return model;
            });
            //return View(, cachedModel);
            return RedirectToAction("Index", "PreCamp");
        }

        //public ActionResult GetDashboard()
        //{
        //    return View();
        //}
    }
}
