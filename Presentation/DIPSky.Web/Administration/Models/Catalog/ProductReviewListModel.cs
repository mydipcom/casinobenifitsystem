using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Catalog
{
    public partial class ProductReviewListModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchText")]
        [AllowHtml]
        public string SearchText { get; set; }
    }
}