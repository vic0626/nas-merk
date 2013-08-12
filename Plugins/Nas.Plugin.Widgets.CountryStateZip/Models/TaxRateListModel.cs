using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Tax.CountryStateZip.Models
{
    public class TaxRateListModel : BaseNasModel
    {
        public TaxRateListModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            AvailableTaxCategories = new List<SelectListItem>();
            TaxRates = new List<TaxRateModel>();
        }

        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public int AddCountryId { get; set; }
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public int AddStateProvinceId { get; set; }
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Zip")]
        public string AddZip { get; set; }
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public int AddTaxCategoryId { get; set; }
        [NasResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Percentage")]
        public decimal AddPercentage { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }

        public IList<TaxRateModel> TaxRates { get; set; }
        
    }
}