using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Checkout
{
    public partial class CheckoutProgressModel : BaseDIPSkyModel
    {
        public CheckoutProgressStep CheckoutProgressStep { get; set; }
    }

    public enum CheckoutProgressStep
    {
        Cart,
        Address,
        Shipping,
        Payment,
        Confirm,
        Complete
    }
}