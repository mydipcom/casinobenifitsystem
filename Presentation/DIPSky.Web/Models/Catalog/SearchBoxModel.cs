using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Catalog
{
    public partial class SearchBoxModel : BaseDIPSkyModel
    {
        public bool AutoCompleteEnabled { get; set; }
        public bool ShowProductImagesInSearchAutoComplete { get; set; }
        public int SearchTermMinimumLength { get; set; }
    }
}