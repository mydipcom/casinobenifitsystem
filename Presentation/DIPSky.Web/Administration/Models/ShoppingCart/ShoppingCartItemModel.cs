using System;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartItemModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.CurrentCarts.Store")]
        public string Store { get; set; }
        [DipSkyResourceDisplayName("Admin.CurrentCarts.Product")]
        public int ProductId { get; set; }
        [DipSkyResourceDisplayName("Admin.CurrentCarts.Product")]
        public string ProductName { get; set; }

        [DipSkyResourceDisplayName("Admin.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }
        [DipSkyResourceDisplayName("Admin.CurrentCarts.Quantity")]
        public int Quantity { get; set; }
        [DipSkyResourceDisplayName("Admin.CurrentCarts.Total")]
        public string Total { get; set; }
        [DipSkyResourceDisplayName("Admin.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }
    }
}