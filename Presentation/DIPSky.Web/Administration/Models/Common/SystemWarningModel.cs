using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Common
{
    public partial class SystemWarningModel : BaseDIPSkyModel
    {
        public SystemWarningLevel Level { get; set; }

        public string Text { get; set; }
    }

    public enum SystemWarningLevel
    {
        Pass,
        Warning,
        Fail
    }
}