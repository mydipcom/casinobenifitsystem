using System.Web.Mvc;
using DIPSky.Plugin.Shipping.CanadaPost.Models;
using DIPSky.Services.Configuration;
using DIPSky.Web.Framework.Controllers;

namespace DIPSky.Plugin.Shipping.CanadaPost.Controllers
{
    [AdminAuthorize]
    public class ShippingCanadaPostController : Controller
    {
        private readonly CanadaPostSettings _canadaPostSettings;
        private readonly ISettingService _settingService;

        public ShippingCanadaPostController(CanadaPostSettings canadaPostSettings, ISettingService settingService)
        {
            this._canadaPostSettings = canadaPostSettings;
            this._settingService = settingService;
        }

        [ChildActionOnly]
        public ActionResult Configure()
        {
            var model = new CanadaPostShippingModel();
            model.Url = _canadaPostSettings.Url;
            model.Port = _canadaPostSettings.Port;
            model.CustomerId = _canadaPostSettings.CustomerId;
            return View("DIPSky.Plugin.Shipping.CanadaPost.Views.ShippingCanadaPost.Configure", model);
        }

        [HttpPost]
        [ChildActionOnly]
        public ActionResult Configure(CanadaPostShippingModel model)
        {
            if (!ModelState.IsValid)
            {
                return Configure();
            }
            
            //save settings
            _canadaPostSettings.Url = model.Url;
            _canadaPostSettings.Port = model.Port;
            _canadaPostSettings.CustomerId = model.CustomerId;
            _settingService.SaveSetting(_canadaPostSettings);

            return View("DIPSky.Plugin.Shipping.CanadaPost.Views.ShippingCanadaPost.Configure", model);
        }

    }
}
