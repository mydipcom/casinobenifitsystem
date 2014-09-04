using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Customer
{
    public partial class BackInStockSubscriptionModel : BaseDIPSkyEntityModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SeName { get; set; }
    }
}
