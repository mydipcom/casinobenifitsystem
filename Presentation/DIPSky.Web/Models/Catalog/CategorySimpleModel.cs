using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Catalog
{
    public class CategorySimpleModel : BaseDIPSkyEntityModel
    {
        public CategorySimpleModel()
        {
            SubCategories = new List<CategorySimpleModel>();
        }

        public string Name { get; set; }

        public string SeName { get; set; }

        public int? NumberOfProducts { get; set; }

        public List<CategorySimpleModel> SubCategories { get; set; }
    }
}