using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.CurrentCarts.Customer")]
        public int CustomerId { get; set; }
        [DipSkyResourceDisplayName("Admin.CurrentCarts.Customer")]
        public string CustomerEmail { get; set; }

        [DipSkyResourceDisplayName("Admin.CurrentCarts.TotalItems")]
        public int TotalItems { get; set; }
    }
}