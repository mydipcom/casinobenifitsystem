using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class OrderIncompleteReportLineModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.SalesReport.Incomplete.Item")]
        public string Item { get; set; }

        [DipSkyResourceDisplayName("Admin.SalesReport.Incomplete.Total")]
        public string Total { get; set; }

        [DipSkyResourceDisplayName("Admin.SalesReport.Incomplete.Count")]
        public int Count { get; set; }
    }
}
