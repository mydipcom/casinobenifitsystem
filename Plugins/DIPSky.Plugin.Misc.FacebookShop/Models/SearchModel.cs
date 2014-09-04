using System.Collections.Generic;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Misc.FacebookShop.Models
{
    //just a simplified copy of \DIPSky.Web\Models\Catalog\SearchModel.cs
    public partial class SearchModel : BaseDIPSkyModel
    {
        public SearchModel()
        {
            PagingFilteringContext = new SearchPagingFilteringModel();
            Products = new List<ProductOverviewModel>();
        }

        public string Warning { get; set; }

        public bool NoResults { get; set; }

        /// <summary>
        /// Query string
        /// </summary>
        [DipSkyResourceDisplayName("Search.SearchTerm")]
        [AllowHtml]
        public string Q { get; set; }


        public SearchPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<ProductOverviewModel> Products { get; set; }
    }
}