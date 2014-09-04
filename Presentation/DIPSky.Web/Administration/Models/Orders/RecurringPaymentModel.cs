using System;
using System.Collections.Generic;
using FluentValidation.Attributes;
using DIPSky.Admin.Validators.Orders;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    [Validator(typeof(RecurringPaymentValidator))]
    public partial class RecurringPaymentModel : BaseDIPSkyEntityModel
    {
        public RecurringPaymentModel()
        {
            History = new List<RecurringPaymentHistoryModel>();
        }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.ID")]
        public override int Id { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.CycleLength")]
        public int CycleLength { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.CyclePeriod")]
        public int CyclePeriodId { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.CyclePeriod")]
        public string CyclePeriodStr { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.TotalCycles")]
        public int TotalCycles { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.StartDate")]
        public string StartDate { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.IsActive")]
        public bool IsActive { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.NextPaymentDate")]
        public string NextPaymentDate { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.CyclesRemaining")]
        public int CyclesRemaining { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.InitialOrder")]
        public int InitialOrderId { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.Customer")]
        public int CustomerId { get; set; }
        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.Customer")]
        public string CustomerEmail { get; set; }

        [DipSkyResourceDisplayName("Admin.RecurringPayments.Fields.PaymentType")]
        public string PaymentType { get; set; }
        
        public bool CanCancelRecurringPayment { get; set; }


        public IList<RecurringPaymentHistoryModel> History { get; set; }

        #region Nested classes


        public partial class RecurringPaymentHistoryModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("Admin.RecurringPayments.History.Order")]
            public int OrderId { get; set; }

            public int RecurringPaymentId { get; set; }

            [DipSkyResourceDisplayName("Admin.RecurringPayments.History.OrderStatus")]
            public string OrderStatus { get; set; }

            [DipSkyResourceDisplayName("Admin.RecurringPayments.History.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [DipSkyResourceDisplayName("Admin.RecurringPayments.History.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [DipSkyResourceDisplayName("Admin.RecurringPayments.History.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}