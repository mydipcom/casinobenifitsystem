using System.Collections.Generic;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Catalog
{
    public partial class BulkEditListModel : BaseDIPSkyModel
    {
        public BulkEditListModel()
        {
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableProductTypes = new List<SelectListItem>();
        }

        [DipSkyResourceDisplayName("Admin.Catalog.BulkEdit.List.SearchProductName")]
        [AllowHtml]
        public string SearchProductName { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.BulkEdit.List.SearchCategory")]
        public int SearchCategoryId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.BulkEdit.List.SearchManufacturer")]
        public int SearchManufacturerId { get; set; }
        [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
        public int SearchProductTypeId { get; set; }
        public IList<SelectListItem> AvailableProductTypes { get; set; }
        

        public IList<SelectListItem> AvailableCategories { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }
    }
}