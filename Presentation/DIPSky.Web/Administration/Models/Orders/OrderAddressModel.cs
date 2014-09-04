using DIPSky.Admin.Models.Common;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class OrderAddressModel : BaseDIPSkyModel
    {
        public int OrderId { get; set; }

        public AddressModel Address { get; set; }
    }
}