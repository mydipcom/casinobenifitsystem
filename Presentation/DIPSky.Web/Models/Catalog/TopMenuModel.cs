using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Catalog
{
    public partial class TopMenuModel : BaseDIPSkyModel
    {
        public TopMenuModel()
        {
            Categories = new List<CategorySimpleModel>();
        }

        public IList<CategorySimpleModel> Categories { get; set; }

        public bool BlogEnabled { get; set; }
        public bool RecentlyAddedProductsEnabled { get; set; }
        public bool ForumEnabled { get; set; }
    }
}