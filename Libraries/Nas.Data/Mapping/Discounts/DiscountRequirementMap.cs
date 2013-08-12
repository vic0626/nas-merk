using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Discounts;

namespace Nas.Data.Mapping.Discounts
{
    public partial class DiscountRequirementMap : EntityTypeConfiguration<DiscountRequirement>
    {
        public DiscountRequirementMap()
        {
            this.ToTable("DiscountRequirement");
            this.HasKey(dr => dr.Id);
        }
    }
}