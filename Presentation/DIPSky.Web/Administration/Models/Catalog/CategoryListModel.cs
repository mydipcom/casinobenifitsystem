using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Catalog
{
    public partial class CategoryListModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.Catalog.Categories.List.SearchCategoryName")]
        [AllowHtml]
        public string SearchCategoryName { get; set; }
    }
}