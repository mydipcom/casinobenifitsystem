using System;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class GiftCardModel: BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.GiftCardType")]
        public int GiftCardTypeId { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.Order")]
        public int? PurchasedWithOrderId { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.Amount")]
        public decimal Amount { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.Amount")]
        public string AmountStr { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.RemainingAmount")]
        public string RemainingAmountStr { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.IsGiftCardActivated")]
        public bool IsGiftCardActivated { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.GiftCardCouponCode")]
        [AllowHtml]
        public string GiftCardCouponCode { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.RecipientName")]
        [AllowHtml]
        public string RecipientName { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.RecipientEmail")]
        [AllowHtml]
        public string RecipientEmail { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.SenderName")]
        [AllowHtml]
        public string SenderName { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.SenderEmail")]
        [AllowHtml]
        public string SenderEmail { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.Message")]
        [AllowHtml]
        public string Message { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.IsRecipientNotified")]
        public bool IsRecipientNotified { get; set; }

        [DipSkyResourceDisplayName("Admin.GiftCards.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }

        #region Nested classes

        public partial class GiftCardUsageHistoryModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("Admin.GiftCards.History.UsedValue")]
            public string UsedValue { get; set; }

            [DipSkyResourceDisplayName("Admin.GiftCards.History.Order")]
            public int OrderId { get; set; }

            [DipSkyResourceDisplayName("Admin.GiftCards.History.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}