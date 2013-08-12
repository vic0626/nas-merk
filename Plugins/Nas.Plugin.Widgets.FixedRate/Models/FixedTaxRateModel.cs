using Nas.Web.Framework;

namespace Nas.Plugin.Tax.FixedRate.Models
{
    public class FixedTaxRateModel
    {
        public int TaxCategoryId { get; set; }

        [NasResourceDisplayName("Plugins.Tax.FixedRate.Fields.TaxCategoryName")]
        public string TaxCategoryName { get; set; }

        [NasResourceDisplayName("Plugins.Tax.FixedRate.Fields.Rate")]
        public decimal Rate { get; set; }
    }
}