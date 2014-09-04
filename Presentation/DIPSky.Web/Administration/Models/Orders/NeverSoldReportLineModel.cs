using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class NeverSoldReportLineModel : BaseDIPSkyModel
    {
        public int ProductId { get; set; }
        [DipSkyResourceDisplayName("Admin.SalesReport.NeverSold.Fields.Name")]
        public string ProductName { get; set; }
    }
}