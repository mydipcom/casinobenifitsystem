using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Common
{
    public partial class AdminHeaderLinksModel : BaseDIPSkyModel
    {
        public string ImpersonatedCustomerEmailUsername { get; set; }
        public bool IsCustomerImpersonated { get; set; }
        public bool DisplayAdminLink { get; set; }
    }
}