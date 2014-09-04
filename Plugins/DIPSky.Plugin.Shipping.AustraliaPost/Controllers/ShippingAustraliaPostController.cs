using System.Web.Mvc;
using DIPSky.Plugin.Shipping.AustraliaPost.Models;
using DIPSky.Services.Configuration;
using DIPSky.Web.Framework.Controllers;

namespace DIPSky.Plugin.Shipping.AustraliaPost.Controllers
{
    [AdminAuthorize]
    public class ShippingAustraliaPostController : Controller
    {
        private readonly AustraliaPostSettings _australiaPostSettings;
        private readonly ISettingService _settingService;

        public ShippingAustraliaPostController(AustraliaPostSettings australiaPostSettings, ISettingService settingService)
        {
            this._australiaPostSettings = australiaPostSettings;
            this._settingService = settingService;
        }

        [ChildActionOnly]
        public ActionResult Configure()
        {
            var model = new AustraliaPostShippingModel();
            model.GatewayUrl = _australiaPostSettings.GatewayUrl;
            model.AdditionalHandlingCharge = _australiaPostSettings.AdditionalHandlingCharge;
            return View("DIPSky.Plugin.Shipping.AustraliaPost.Views.ShippingAustraliaPost.Configure", model);
        }

        [HttpPost]
        [ChildActionOnly]
        public ActionResult Configure(AustraliaPostShippingModel model)
        {
            if (!ModelState.IsValid)
            {
                return Configure();
            }
            
            //save settings
            _australiaPostSettings.GatewayUrl = model.GatewayUrl;
            _australiaPostSettings.AdditionalHandlingCharge = model.AdditionalHandlingCharge;
            _settingService.SaveSetting(_australiaPostSettings);

            return View("DIPSky.Plugin.Shipping.AustraliaPost.Views.ShippingAustraliaPost.Configure", model);
        }

    }
}
