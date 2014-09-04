using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Shipping.ByWeight.Models
{
    public class ShippingByWeightListModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Plugins.Shipping.ByWeight.Fields.LimitMethodsToCreated")]
        public bool LimitMethodsToCreated { get; set; }
        
    }
}