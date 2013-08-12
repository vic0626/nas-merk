using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Tax.CountryStateZip.Models
{
    public class TaxRateModel : BaseNasEntityModel
    {
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public int TaxCategoryId { get; set; }
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public string TaxCategoryName { get; set; }

        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public int CountryId { get; set; }
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public string CountryName { get; set; }

        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public int StateProvinceId { get; set; }
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public string StateProvinceName { get; set; }

        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Zip")]
        public string Zip { get; set; }

        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Percentage")]
        public decimal Percentage { get; set; }
    }
}