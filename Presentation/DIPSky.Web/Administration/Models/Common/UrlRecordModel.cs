using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Common
{
    public partial class UrlRecordModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.System.SeNames.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SeNames.EntityId")]
        public int EntityId { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SeNames.Language")]
        public string Language { get; set; }
    }
}