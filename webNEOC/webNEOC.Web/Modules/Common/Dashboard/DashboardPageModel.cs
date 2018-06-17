
namespace webNEOC.Common
{
    public class DashboardPageModel
    {
        public int OpenOrders { get; set; }
        public int ClosedOrderPercent { get; set; }
        public int CustomerCount { get; set; }
        public int ProductCount { get; set; }

        public int Provinces { get; set; }
        public int Districts { get; set; }
        public int Clusters { get; set; }
        public int TotalChildren { get; set; }
    }
}