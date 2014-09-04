﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Customers
{
    public partial class BestCustomersReportModel : BaseDIPSkyModel
    {
        public BestCustomersReportModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableShippingStatuses = new List<SelectListItem>();
        }

        [DipSkyResourceDisplayName("Admin.Customers.Reports.BestBy.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [DipSkyResourceDisplayName("Admin.Customers.Reports.BestBy.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [DipSkyResourceDisplayName("Admin.Customers.Reports.BestBy.OrderStatus")]
        public int OrderStatusId { get; set; }
        [DipSkyResourceDisplayName("Admin.Customers.Reports.BestBy.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [DipSkyResourceDisplayName("Admin.Customers.Reports.BestBy.ShippingStatus")]
        public int ShippingStatusId { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableShippingStatuses { get; set; }
    }
}