using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Web.Framework;

namespace Nas.Plugin.Shipping.Fedex.Models
{
    public class FedexShippingModel
    {
        public FedexShippingModel()
        {
            CarrierServicesOffered = new List<string>();
            AvailableCarrierServices = new List<string>();
        }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.Url")]
        public string Url { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.Key")]
        public string Key { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.Password")]
        public string Password { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.AccountNumber")]
        public string AccountNumber { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.MeterNumber")]
        public string MeterNumber { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.UseResidentialRates")]
        public bool UseResidentialRates { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.ApplyDiscounts")]
        public bool ApplyDiscounts { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }

        public IList<string> CarrierServicesOffered { get; set; }
        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.CarrierServices")]
        public IList<string> AvailableCarrierServices { get; set; }
        public string[] CheckedCarrierServices { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.Street")]
        public string Street { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.City")]
        public string City { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.StateOrProvinceCode")]
        public string StateOrProvinceCode { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.PostalCode")]
        public string PostalCode { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.CountryCode")]
        public string CountryCode { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.PassDimensions")]
        public bool PassDimensions { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.PackingPackageVolume")]
        public int PackingPackageVolume { get; set; }

        public int PackingType { get; set; }
        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.PackingType")]
        public SelectList PackingTypeValues { get; set; }

        public int DropoffType { get; set; }
        [NasResourceDisplayName("Plugins.Shipping.Fedex.Fields.DropoffType")]
        public SelectList AvailableDropOffTypes { get; set; }
    }
}