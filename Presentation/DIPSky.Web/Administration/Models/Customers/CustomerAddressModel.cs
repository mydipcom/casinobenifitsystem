using DIPSky.Admin.Models.Common;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Customers
{
    public partial class CustomerAddressModel : BaseDIPSkyModel
    {
        public int CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}