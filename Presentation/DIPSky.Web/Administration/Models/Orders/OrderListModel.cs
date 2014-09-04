using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class OrderListModel : BaseDIPSkyModel
    {
        public OrderListModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableShippingStatuses = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
        }

        [DipSkyResourceDisplayName("Admin.Orders.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.List.CustomerEmail")]
        [AllowHtml]
        public string CustomerEmail { get; set; }


        [DipSkyResourceDisplayName("Admin.Orders.List.EmployeeId")]
        [AllowHtml]
        public string EmployeeId { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.List.OrderStatus")]
        public int OrderStatusId { get; set; }
        [DipSkyResourceDisplayName("Admin.Orders.List.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [DipSkyResourceDisplayName("Admin.Orders.List.ShippingStatus")]
        public int ShippingStatusId { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.List.Store")]
        public int StoreId { get; set; }
        [DipSkyResourceDisplayName("Admin.Orders.List.Vendor")]
        public int VendorId { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.List.OrderGuid")]
        [AllowHtml]
        public string OrderGuid { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.List.GoDirectlyToNumber")]
        [AllowHtml]
        public int GoDirectlyToNumber { get; set; }

        public bool IsLoggedInAsVendor { get; set; }


        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableShippingStatuses { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }
    }
}