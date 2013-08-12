using Nas.Web.Framework;

namespace Nas.Plugin.DiscountRules.HasAllProducts.Models
{
    public class RequirementModel
    {
        [NasResourceDisplayName("Plugins.DiscountRules.HasAllProducts.Fields.ProductVariants")]
        public string ProductVariants { get; set; }

        public int DiscountId { get; set; }

        public int RequirementId { get; set; }
    }
}