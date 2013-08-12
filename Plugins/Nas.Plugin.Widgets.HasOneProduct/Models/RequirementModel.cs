using Nas.Web.Framework;

namespace Nas.Plugin.DiscountRules.HasOneProduct.Models
{
    public class RequirementModel
    {
        [NasResourceDisplayName("Plugins.DiscountRules.HasOneProduct.Fields.ProductVariants")]
        public string ProductVariants { get; set; }

        public int DiscountId { get; set; }

        public int RequirementId { get; set; }
    }
}