using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Framework.UI.Paging;

namespace DIPSky.Web.Models.Catalog
{
    public partial class SearchPagingFilteringModel : BasePageableModel
    {
        public class CategoryModel : BaseDIPSkyEntityModel
        {
            public string Breadcrumb { get; set; }
        }
    }
}