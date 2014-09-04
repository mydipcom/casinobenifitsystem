using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Settings
{
    public partial class VendorSettingsModel : BaseDIPSkyModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }


        [DipSkyResourceDisplayName("Admin.Configuration.Settings.Vendor.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }
        public bool AllowCustomersToSelectPageSize_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Settings.Vendor.PageSize")]
        public int PageSize { get; set; }
        public bool PageSize_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Settings.Vendor.PageSizeOptions")]
        public string PageSizeOptions { get; set; }
        public bool PageSizeOptions_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Settings.Vendor.VendorsBlockItemsToDisplay")]
        public int VendorsBlockItemsToDisplay { get; set; }
        public bool VendorsBlockItemsToDisplay_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Settings.Vendor.ShowVendorOnProductDetailsPage")]
        public bool ShowVendorOnProductDetailsPage { get; set; }
        public bool ShowVendorOnProductDetailsPage_OverrideForStore { get; set; }
    }
}