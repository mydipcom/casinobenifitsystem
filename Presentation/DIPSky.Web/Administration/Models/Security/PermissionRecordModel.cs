using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Security
{
    public partial class PermissionRecordModel : BaseDIPSkyModel
    {
        public string Name { get; set; }
        public string SystemName { get; set; }
    }
}