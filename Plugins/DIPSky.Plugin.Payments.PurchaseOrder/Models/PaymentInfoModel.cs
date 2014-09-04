using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Payments.PurchaseOrder.Models
{
    public class PaymentInfoModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Plugins.Payment.PurchaseOrder.PurchaseOrderNumber")]
        [AllowHtml]
        public string PurchaseOrderNumber { get; set; }
    }
}