using System.Collections.Generic;
using System.Web.Mvc;
using DIPSky.Web.Framework;

namespace DIPSky.Plugin.DiscountRules.CustomerRoles.Models
{
    public class RequirementModel
    {
        public RequirementModel()
        {
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        [DipSkyResourceDisplayName("Plugins.DiscountRules.CustomerRoles.Fields.CustomerRole")]
        public int CustomerRoleId { get; set; }

        public int DiscountId { get; set; }

        public int RequirementId { get; set; }

        public IList<SelectListItem> AvailableCustomerRoles { get; set; }
    }
}