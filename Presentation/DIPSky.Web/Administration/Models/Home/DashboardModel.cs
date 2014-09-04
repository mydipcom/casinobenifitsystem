using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Home
{
    public partial class DashboardModel : BaseDIPSkyModel
    {
        public bool IsLoggedInAsVendor { get; set; }
    }
}