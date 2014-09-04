using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class BestsellersReportModel : BaseDIPSkyModel
    {
        public BestsellersReportModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
        }

        [DipSkyResourceDisplayName("Admin.SalesReport.Bestsellers.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [DipSkyResourceDisplayName("Admin.SalesReport.Bestsellers.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }


        [DipSkyResourceDisplayName("Admin.SalesReport.Bestsellers.OrderStatus")]
        public int OrderStatusId { get; set; }
        [DipSkyResourceDisplayName("Admin.SalesReport.Bestsellers.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [DipSkyResourceDisplayName("Admin.SalesReport.Bestsellers.Category")]
        public int CategoryId { get; set; }
        [DipSkyResourceDisplayName("Admin.SalesReport.Bestsellers.Manufacturer")]
        public int ManufacturerId { get; set; }
        [DipSkyResourceDisplayName("Admin.SalesReport.Bestsellers.BillingCountry")]
        public int BillingCountryId { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        
        public bool IsLoggedInAsVendor { get; set; }
    }
}