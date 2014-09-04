using System;
using System.ComponentModel.DataAnnotations;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class NeverSoldReportModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.SalesReport.NeverSold.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [DipSkyResourceDisplayName("Admin.SalesReport.NeverSold.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }
    }
}