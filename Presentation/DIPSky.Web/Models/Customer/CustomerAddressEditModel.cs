using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Models.Common;

namespace DIPSky.Web.Models.Customer
{
    public partial class CustomerAddressEditModel : BaseDIPSkyModel
    {
        public CustomerAddressEditModel()
        {
            this.Address = new AddressModel();
        }
        public AddressModel Address { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}