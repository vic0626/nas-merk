using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Web.Framework;

namespace Nas.Plugin.Shipping.UPS.Models
{
    public class UPSShippingModel
    {
        public UPSShippingModel()
        {
            CarrierServicesOffered = new List<string>();
            AvailableCarrierServices = new List<string>();
            AvailableCustomerClassifications = new List<SelectListItem>();
            AvailablePickupTypes = new List<SelectListItem>();
            AvailablePackagingTypes = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
        }
        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.Url")]
        public string Url { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.AccessKey")]
        public string AccessKey { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.Username")]
        public string Username { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.Password")]
        public string Password { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.InsurePackage")]
        public bool InsurePackage { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.CustomerClassification")]
        public string CustomerClassification { get; set; }
        public IList<SelectListItem> AvailableCustomerClassifications { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.PickupType")]
        public string PickupType { get; set; }
        public IList<SelectListItem> AvailablePickupTypes { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.PackagingType")]
        public string PackagingType { get; set; }
        public IList<SelectListItem> AvailablePackagingTypes { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.DefaultShippedFromCountry")]
        public int DefaultShippedFromCountryId { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.DefaultShippedFromZipPostalCode")]
        public string DefaultShippedFromZipPostalCode { get; set; }


        public IList<string> CarrierServicesOffered { get; set; }
        [NasResourceDisplayName("Plugins.Shipping.UPS.Fields.AvailableCarrierServices")]
        public IList<string> AvailableCarrierServices { get; set; }
        public string[] CheckedCarrierServices { get; set; }
    }
}