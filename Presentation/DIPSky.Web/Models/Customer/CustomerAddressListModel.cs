using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Models.Common;

namespace DIPSky.Web.Models.Customer
{
    public partial class CustomerAddressListModel : BaseDIPSkyModel
    {
        public CustomerAddressListModel()
        {
            Addresses = new List<AddressModel>();
        }

        public IList<AddressModel> Addresses { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}