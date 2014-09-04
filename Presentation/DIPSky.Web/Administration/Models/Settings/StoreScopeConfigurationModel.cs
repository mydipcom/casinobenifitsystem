using System.Collections.Generic;
using DIPSky.Admin.Models.Stores;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Settings
{
    public partial class StoreScopeConfigurationModel : BaseDIPSkyModel
    {
        public StoreScopeConfigurationModel()
        {
            Stores = new List<StoreModel>();
        }

        public int StoreId { get; set; }
        public IList<StoreModel> Stores { get; set; }
    }
}