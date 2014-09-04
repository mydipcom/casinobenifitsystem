using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Checkout
{
    public partial class OnePageCheckoutModel : BaseDIPSkyModel
    {
        public bool ShippingRequired { get; set; }
    }
}