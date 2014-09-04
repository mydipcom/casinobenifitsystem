using System;
using System.Linq;
using DIPSky.Core;
using DIPSky.Core.Domain.Customers;
using DIPSky.Core.Domain.Orders;
using DIPSky.Core.Plugins;
using DIPSky.Services.Configuration;
using DIPSky.Services.Discounts;
using DIPSky.Services.Localization;
using DIPSky.Services.Orders;

namespace DIPSky.Plugin.DiscountRules.HadSpentAmount
{
    public partial class HadSpentAmountDiscountRequirementRule : BasePlugin, IDiscountRequirementRule
    {
        private readonly ISettingService _settingService;
        private readonly IOrderService _orderService;

        public HadSpentAmountDiscountRequirementRule(ISettingService settingService, 
            IOrderService orderService)
        {
            this._settingService = settingService;
            this._orderService = orderService;
        }

        /// <summary>
        /// Check discount requirement
        /// </summary>
        /// <param name="request">Object that contains all information required to check the requirement (Current customer, discount, etc)</param>
        /// <returns>true - requirement is met; otherwise, false</returns>
        public bool CheckRequirement(CheckDiscountRequirementRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.DiscountRequirement == null)
                throw new DipSkyException("Discount requirement is not set");

            var spentAmountRequirement = _settingService.GetSettingByKey<decimal>(string.Format("DiscountRequirement.HadSpentAmount-{0}", request.DiscountRequirement.Id));

            if (spentAmountRequirement == decimal.Zero)
                return true;

            if (request.Customer == null || request.Customer.IsGuest())
                return false;
            var orders = _orderService.SearchOrders(storeId: request.Store.Id, 
                customerId: request.Customer.Id, 
                os: OrderStatus.Complete);
            decimal spentAmount = orders.Sum(o => o.OrderTotal);
            return spentAmount > spentAmountRequirement;
        }

        /// <summary>
        /// Get URL for rule configuration
        /// </summary>
        /// <param name="discountId">Discount identifier</param>
        /// <param name="discountRequirementId">Discount requirement identifier (if editing)</param>
        /// <returns>URL</returns>
        public string GetConfigurationUrl(int discountId, int? discountRequirementId)
        {
            //configured in RouteProvider.cs
            string result = "Plugins/DiscountRulesHadSpentAmount/Configure/?discountId=" + discountId;
            if (discountRequirementId.HasValue)
                result += string.Format("&discountRequirementId={0}", discountRequirementId.Value);
            return result;
        }

        public override void Install()
        {
            //locales
            this.AddOrUpdatePluginLocaleResource("Plugins.DiscountRules.HadSpentAmount.Fields.Amount", "Required spent amount");
            this.AddOrUpdatePluginLocaleResource("Plugins.DiscountRules.HadSpentAmount.Fields.Amount.Hint", "Discount will be applied if customer has spent/purchased x.xx amount.");
            base.Install();
        }

        public override void Uninstall()
        {
            //locales
            this.DeletePluginLocaleResource("Plugins.DiscountRules.HadSpentAmount.Fields.Amount");
            this.DeletePluginLocaleResource("Plugins.DiscountRules.HadSpentAmount.Fields.Amount.Hint");
            base.Uninstall();
        }
    }
}