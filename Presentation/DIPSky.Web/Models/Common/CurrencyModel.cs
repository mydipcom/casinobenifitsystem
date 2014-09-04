using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Common
{
    public partial class CurrencyModel : BaseDIPSkyEntityModel
    {
        public string Name { get; set; }

        public string CurrencySymbol { get; set; }
    }
}