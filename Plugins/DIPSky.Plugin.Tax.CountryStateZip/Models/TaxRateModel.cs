using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Tax.CountryStateZip.Models
{
    public class TaxRateModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Store")]
        public int StoreId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Store")]
        public string StoreName { get; set; }

        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public int TaxCategoryId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public string TaxCategoryName { get; set; }

        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public int CountryId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public string CountryName { get; set; }

        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public int StateProvinceId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public string StateProvinceName { get; set; }

        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Zip")]
        public string Zip { get; set; }

        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Percentage")]
        public decimal Percentage { get; set; }
    }
}