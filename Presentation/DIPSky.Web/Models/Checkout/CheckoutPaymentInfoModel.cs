using System.Web.Routing;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Checkout
{
    public partial class CheckoutPaymentInfoModel : BaseDIPSkyModel
    {
        public string PaymentInfoActionName { get; set; }
        public string PaymentInfoControllerName { get; set; }
        public RouteValueDictionary PaymentInfoRouteValues { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool DisplayOrderTotals { get; set; }
    }
}