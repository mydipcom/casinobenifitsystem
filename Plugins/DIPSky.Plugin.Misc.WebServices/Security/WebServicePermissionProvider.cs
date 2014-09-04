using System.Collections.Generic;
using System.Linq;
using DIPSky.Core.Domain.Security;
using DIPSky.Services.Security;

namespace DIPSky.Plugin.Misc.WebServices.Security
{
    public partial class WebServicePermissionProvider : IPermissionProvider
    {
        public static readonly PermissionRecord AccessWebService = new PermissionRecord { Name = "Plugins. Access Web Service", SystemName = "AccessWebService", Category = "Plugin" };
        
        public virtual IEnumerable<PermissionRecord> GetPermissions()
        {
            return new[] 
            {
                AccessWebService,
            };
        }

        public virtual IEnumerable<DefaultPermissionRecord> GetDefaultPermissions()
        {
            return Enumerable.Empty<DefaultPermissionRecord>();

            //uncomment code below in order to give appropriate permissions to admin by default
            //return new[] 
            //{
            //    new DefaultPermissionRecord 
            //    {
            //        CustomerRoleSystemName = SystemCustomerRoleNames.Administrators,
            //        PermissionRecords = new[] 
            //        {
            //            AccessWebService,
            //        }
            //    },
            //};
        }
    }
}