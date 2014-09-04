using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Models.Common;

namespace DIPSky.Web.Models.Checkout
{
    public partial class CheckoutBillingAddressModel : BaseDIPSkyModel
    {
        public CheckoutBillingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool NewAddressPreselected { get; set; }
    }
}