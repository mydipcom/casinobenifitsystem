using System.Collections.Generic;
using DIPSky.Core.Domain.Shipping;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Checkout
{
    public partial class CheckoutShippingMethodModel : BaseDIPSkyModel
    {
        public CheckoutShippingMethodModel()
        {
            ShippingMethods = new List<ShippingMethodModel>();
            Warnings = new List<string>();
        }

        public IList<ShippingMethodModel> ShippingMethods { get; set; }

        public IList<string> Warnings { get; set; }

        #region Nested classes

        public partial class ShippingMethodModel : BaseDIPSkyModel
        {
            public string ShippingRateComputationMethodSystemName { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Fee { get; set; }
            public bool Selected { get; set; }

            public ShippingOption ShippingOption { get; set; } 
        }
        #endregion
    }
}