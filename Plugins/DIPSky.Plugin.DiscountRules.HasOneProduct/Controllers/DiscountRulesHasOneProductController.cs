using System;
using System.Linq;
using System.Web.Mvc;
using DIPSky.Core.Domain.Discounts;
using DIPSky.Plugin.DiscountRules.HasOneProduct.Models;
using DIPSky.Services.Configuration;
using DIPSky.Services.Discounts;
using DIPSky.Services.Security;
using DIPSky.Web.Framework.Controllers;

namespace DIPSky.Plugin.DiscountRules.HasOneProduct.Controllers
{
    [AdminAuthorize]
    public class DiscountRulesHasOneProductController : Controller
    {
        private readonly IDiscountService _discountService;
        private readonly ISettingService _settingService;
        private readonly IPermissionService _permissionService;

        public DiscountRulesHasOneProductController(IDiscountService discountService,
            ISettingService settingService, IPermissionService permissionService)
        {
            this._discountService = discountService;
            this._settingService = settingService;
            this._permissionService = permissionService;
        }

        public ActionResult Configure(int discountId, int? discountRequirementId)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageDiscounts))
                return Content("Access denied");

            var discount = _discountService.GetDiscountById(discountId);
            if (discount == null)
                throw new ArgumentException("Discount could not be loaded");

            DiscountRequirement discountRequirement = null;
            if (discountRequirementId.HasValue)
            {
                discountRequirement = discount.DiscountRequirements.FirstOrDefault(dr => dr.Id == discountRequirementId.Value);
                if (discountRequirement == null)
                    return Content("Failed to load requirement.");
            }

            var restrictedProductIds = _settingService.GetSettingByKey<string>(string.Format("DiscountRequirement.RestrictedProductIds-{0}", discountRequirementId.HasValue ? discountRequirementId.Value : 0));

            var model = new RequirementModel();
            model.RequirementId = discountRequirementId.HasValue ? discountRequirementId.Value : 0;
            model.DiscountId = discountId;
            model.Products = restrictedProductIds;

            //add a prefix
            ViewData.TemplateInfo.HtmlFieldPrefix = string.Format("DiscountRulesHasOneProduct{0}", discountRequirementId.HasValue ? discountRequirementId.Value.ToString() : "0");

            return View("DIPSky.Plugin.DiscountRules.HasOneProduct.Views.DiscountRulesHasOneProduct.Configure", model);
        }

        [HttpPost]
        public ActionResult Configure(int discountId, int? discountRequirementId, string productIds)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageDiscounts))
                return Content("Access denied");

            var discount = _discountService.GetDiscountById(discountId);
            if (discount == null)
                throw new ArgumentException("Discount could not be loaded");

            DiscountRequirement discountRequirement = null;
            if (discountRequirementId.HasValue)
                discountRequirement = discount.DiscountRequirements.FirstOrDefault(dr => dr.Id == discountRequirementId.Value);

            if (discountRequirement != null)
            {
                //update existing rule
                _settingService.SetSetting(string.Format("DiscountRequirement.RestrictedProductIds-{0}", discountRequirement.Id), productIds);
            }
            else
            {
                //save new rule
                discountRequirement = new DiscountRequirement()
                {
                    DiscountRequirementRuleSystemName = "DiscountRequirement.HasOneProduct"
                };
                discount.DiscountRequirements.Add(discountRequirement);
                _discountService.UpdateDiscount(discount);

                _settingService.SetSetting(string.Format("DiscountRequirement.RestrictedProductIds-{0}", discountRequirement.Id), productIds);
            }
            return Json(new { Result = true, NewRequirementId = discountRequirement.Id }, JsonRequestBehavior.AllowGet);
        }
        
    }
}