using System.Collections.Generic;
using DIPSky.Web.Framework;

namespace DIPSky.Plugin.Shipping.USPS.Models
{
    public class USPSShippingModel
    {
        public USPSShippingModel()
        {
            CarrierServicesOfferedDomestic = new List<string>();
            AvailableCarrierServicesDomestic = new List<string>();
            CarrierServicesOfferedInternational = new List<string>();
            AvailableCarrierServicesInternational = new List<string>();
        }

        [DipSkyResourceDisplayName("Plugins.Shipping.USPS.Fields.Url")]
        public string Url { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.USPS.Fields.Username")]
        public string Username { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.USPS.Fields.Password")]
        public string Password { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.USPS.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }
        
        public IList<string> CarrierServicesOfferedDomestic { get; set; }
        [DipSkyResourceDisplayName("Plugins.Shipping.USPS.Fields.AvailableCarrierServicesDomestic")]
        public IList<string> AvailableCarrierServicesDomestic { get; set; }
        public string[] CheckedCarrierServicesDomestic { get; set; }

        public IList<string> CarrierServicesOfferedInternational { get; set; }
        [DipSkyResourceDisplayName("Plugins.Shipping.USPS.Fields.AvailableCarrierServicesInternational")]
        public IList<string> AvailableCarrierServicesInternational { get; set; }
        public string[] CheckedCarrierServicesInternational { get; set; }
    }
}