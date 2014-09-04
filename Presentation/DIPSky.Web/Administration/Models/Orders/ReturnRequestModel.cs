using System;
using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Admin.Validators.Orders;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    [Validator(typeof(ReturnRequestValidator))]
    public partial class ReturnRequestModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.ID")]
        public override int Id { get; set; }

        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.Order")]
        public int OrderId { get; set; }

        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public int CustomerId { get; set; }
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public string CustomerInfo { get; set; }

        public int ProductId { get; set; }
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.Product")]
        public string ProductName { get; set; }

        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.Quantity")]
        public int Quantity { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.ReasonForReturn")]
        public string ReasonForReturn { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.RequestedAction")]
        public string RequestedAction { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.CustomerComments")]
        public string CustomerComments { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.StaffNotes")]
        public string StaffNotes { get; set; }

        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public int ReturnRequestStatusId { get; set; }
        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public string ReturnRequestStatusStr { get; set; }

        [DipSkyResourceDisplayName("Admin.ReturnRequests.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}