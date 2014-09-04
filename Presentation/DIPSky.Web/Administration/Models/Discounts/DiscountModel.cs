using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Admin.Validators.Discounts;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Discounts
{
    [Validator(typeof(DiscountValidator))]
    public partial class DiscountModel : BaseDIPSkyEntityModel
    {
        public DiscountModel()
        {
            AppliedToCategoryModels = new List<AppliedToCategoryModel>();
            AppliedToProductModels = new List<AppliedToProductModel>();
            AvailableDiscountRequirementRules = new List<SelectListItem>();
            DiscountRequirementMetaInfos = new List<DiscountRequirementMetaInfo>();
        }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.DiscountType")]
        public int DiscountTypeId { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.UsePercentage")]
        public bool UsePercentage { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.DiscountPercentage")]
        public decimal DiscountPercentage { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.DiscountAmount")]
        public decimal DiscountAmount { get; set; }
        public string PrimaryStoreCurrencyCode { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDateUtc { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDateUtc { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.RequiresCouponCode")]
        public bool RequiresCouponCode { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.CouponCode")]
        [AllowHtml]
        public string CouponCode { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.DiscountLimitation")]
        public int DiscountLimitationId { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.LimitationTimes")]
        public int LimitationTimes { get; set; }


        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.AppliedToCategories")]
        public IList<AppliedToCategoryModel> AppliedToCategoryModels { get; set; }

        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Fields.AppliedToProducts")]
        public IList<AppliedToProductModel> AppliedToProductModels { get; set; }


        [DipSkyResourceDisplayName("Admin.Promotions.Discounts.Requirements.DiscountRequirementType")]
        public string AddDiscountRequirement { get; set; }

        public IList<SelectListItem> AvailableDiscountRequirementRules { get; set; }

        public IList<DiscountRequirementMetaInfo> DiscountRequirementMetaInfos { get; set; }
        

        #region Nested classes

        public partial class DiscountRequirementMetaInfo : BaseDIPSkyModel
        {
            public int DiscountRequirementId { get; set; }
            public string RuleName { get; set; }
            public string ConfigurationUrl { get; set; }
        }

        public partial class DiscountUsageHistoryModel : BaseDIPSkyEntityModel
        {
            public int DiscountId { get; set; }

            [DipSkyResourceDisplayName("Admin.Promotions.Discounts.History.Order")]
            public int OrderId { get; set; }

            [DipSkyResourceDisplayName("Admin.Promotions.Discounts.History.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class AppliedToCategoryModel : BaseDIPSkyModel
        {
            public int CategoryId { get; set; }

            public string Name { get; set; }
        }

        public partial class AppliedToProductModel : BaseDIPSkyModel
        {
            public int ProductId { get; set; }

            public string ProductName { get; set; }
        }
        #endregion
    }
}