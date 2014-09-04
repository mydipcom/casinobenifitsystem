using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Customer
{
    public partial class CustomerAvatarModel : BaseDIPSkyModel
    {
        public string AvatarUrl { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}