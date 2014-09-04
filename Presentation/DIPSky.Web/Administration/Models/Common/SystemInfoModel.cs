using System;
using System.Collections.Generic;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Common
{
    public partial class SystemInfoModel : BaseDIPSkyModel
    {
        public SystemInfoModel()
        {
            this.LoadedAssemblies = new List<LoadedAssembly>();
        }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.ASPNETInfo")]
        public string AspNetInfo { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.IsFullTrust")]
        public string IsFullTrust { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.DIPSkyVersion")]
        public string DIPSkyVersion { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.OperatingSystem")]
        public string OperatingSystem { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.ServerLocalTime")]
        public DateTime ServerLocalTime { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.ServerTimeZone")]
        public string ServerTimeZone { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.UTCTime")]
        public DateTime UtcTime { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.HTTPHOST")]
        public string HttpHost { get; set; }

        [DipSkyResourceDisplayName("Admin.System.SystemInfo.LoadedAssemblies")]
        public IList<LoadedAssembly> LoadedAssemblies { get; set; }

        public partial class LoadedAssembly : BaseDIPSkyModel
        {
            public string FullName { get; set; }
            public string Location { get; set; }
        }

    }
}