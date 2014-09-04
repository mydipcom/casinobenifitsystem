using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Common
{
    public partial class SearchTermReportLineModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("关键字")]
        public string Keyword { get; set; }

        [DipSkyResourceDisplayName("数量")]
        public int Count { get; set; }
    }
}
