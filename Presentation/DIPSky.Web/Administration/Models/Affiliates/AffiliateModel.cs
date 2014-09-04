using System;
using FluentValidation.Attributes;
using DIPSky.Admin.Models.Common;
using DIPSky.Admin.Validators.Affiliates;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Affiliates
{
    [Validator(typeof(AffiliateValidator))]
    public partial class AffiliateModel : BaseDIPSkyEntityModel
    {
        public AffiliateModel()
        {
            Address = new AddressModel();
        }

        [DipSkyResourceDisplayName("Admin.Affiliates.Fields.ID")]
        public override int Id { get; set; }

        [DipSkyResourceDisplayName("Admin.Affiliates.Fields.URL")]
        public string Url { get; set; }
        
        [DipSkyResourceDisplayName("Admin.Affiliates.Fields.Active")]
        public bool Active { get; set; }

        public AddressModel Address { get; set; }

        #region Nested classes
        
        public partial class AffiliatedOrderModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("Admin.Affiliates.Orders.Order")]
            public override int Id { get; set; }

            [DipSkyResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
            public string OrderStatus { get; set; }

            [DipSkyResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [DipSkyResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [DipSkyResourceDisplayName("Admin.Affiliates.Orders.OrderTotal")]
            public string OrderTotal { get; set; }

            [DipSkyResourceDisplayName("Admin.Affiliates.Orders.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class AffiliatedCustomerModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("Admin.Affiliates.Customers.Name")]
            public string Name { get; set; }
        }

        #endregion
    }
}