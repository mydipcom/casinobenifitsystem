using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Checkout
{
    public partial class CheckoutCompletedModel : BaseDIPSkyModel
    {
        public int OrderId { get; set; }
        public bool OnePageCheckoutEnabled { get; set; }
    }
}