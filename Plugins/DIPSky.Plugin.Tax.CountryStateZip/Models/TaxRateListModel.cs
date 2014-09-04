using System.Collections.Generic;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Tax.CountryStateZip.Models
{
    public class TaxRateListModel : BaseDIPSkyModel
    {
        public TaxRateListModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            AvailableTaxCategories = new List<SelectListItem>();
            TaxRates = new List<TaxRateModel>();
        }

        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Store")]
        public int AddStoreId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public int AddCountryId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public int AddStateProvinceId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Zip")]
        public string AddZip { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public int AddTaxCategoryId { get; set; }
        [DipSkyResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Percentage")]
        public decimal AddPercentage { get; set; }


        public IList<SelectListItem> AvailableStores { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }

        public IList<TaxRateModel> TaxRates { get; set; }
        
    }
}