using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Models.Common;

namespace DIPSky.Web.Models.Checkout
{
    public partial class CheckoutShippingAddressModel : BaseDIPSkyModel
    {
        public CheckoutShippingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        public bool NewAddressPreselected { get; set; }
    }
}