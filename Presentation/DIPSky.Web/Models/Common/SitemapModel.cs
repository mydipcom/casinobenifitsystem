using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Models.Catalog;
using DIPSky.Web.Models.Topics;

namespace DIPSky.Web.Models.Common
{
    public partial class SitemapModel : BaseDIPSkyModel
    {
        public SitemapModel()
        {
            Products = new List<ProductOverviewModel>();
            Categories = new List<CategoryModel>();
            Manufacturers = new List<ManufacturerModel>();
            Topics = new List<TopicModel>();
        }
        public IList<ProductOverviewModel> Products { get; set; }
        public IList<CategoryModel> Categories { get; set; }
        public IList<ManufacturerModel> Manufacturers { get; set; }
        public IList<TopicModel> Topics { get; set; }
    }
}