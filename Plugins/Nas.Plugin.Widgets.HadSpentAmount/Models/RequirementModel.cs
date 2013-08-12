using Nas.Web.Framework;

namespace Nas.Plugin.DiscountRules.HadSpentAmount.Models
{
    public class RequirementModel
    {
        [NasResourceDisplayName("Plugins.DiscountRules.HadSpentAmount.Fields.Amount")]
        public decimal SpentAmount { get; set; }

        public int DiscountId { get; set; }

        public int RequirementId { get; set; }
    }
}