using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Misc.FacebookShop.Models
{
    public class CategoryModel : BaseDIPSkyEntityModel
    {
        public CategoryModel()
        {
            SubCategories = new List<CategoryModel>();
            Products = new List<ProductOverviewModel>();
            PagingFilteringContext = new CatalogPagingFilteringModel();
            PictureModel = new PictureModel();
        }

        public string Name { get; set; }
        public string SeName { get; set; }
        public string Description { get; set; }

        public PictureModel PictureModel { get; set; }

        public List<CategoryModel> SubCategories { get; set; }
        public List<ProductOverviewModel> Products { get; set; }
        public CatalogPagingFilteringModel PagingFilteringContext { get; set; }
    }
}
