using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Shipping.ByWeight.Models
{
    public class ShippingByWeightModel : BaseNasEntityModel
    {
        public ShippingByWeightModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            AvailableShippingMethods = new List<SelectListItem>();
        }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.Country")]
        public int CountryId { get; set; }
        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.Country")]
        public string CountryName { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.StateProvince")]
        public int StateProvinceId { get; set; }
        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.StateProvince")]
        public string StateProvinceName { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.Zip")]
        public string Zip { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.ShippingMethod")]
        public int ShippingMethodId { get; set; }
        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.ShippingMethod")]
        public string ShippingMethodName { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.From")]
        public decimal From { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.To")]
        public decimal To { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.AdditionalFixedCost")]
        public decimal AdditionalFixedCost { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.PercentageRateOfSubtotal")]
        public decimal PercentageRateOfSubtotal { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.RatePerWeightUnit")]
        public decimal RatePerWeightUnit { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.LowerWeightLimit")]
        public decimal LowerWeightLimit { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.DataHtml")]
        public string DataHtml { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }
        public string BaseWeightIn { get; set; }


        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        public IList<SelectListItem> AvailableShippingMethods { get; set; }
    }
}