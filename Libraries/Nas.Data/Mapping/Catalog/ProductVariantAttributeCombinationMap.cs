using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Catalog;

namespace Nas.Data.Mapping.Catalog
{
    public partial class ProductVariantAttributeCombinationMap : EntityTypeConfiguration<ProductVariantAttributeCombination>
    {
        public ProductVariantAttributeCombinationMap()
        {
            this.ToTable("ProductVariantAttributeCombination");
            this.HasKey(pvac => pvac.Id);

            this.Property(pv => pv.Sku).HasMaxLength(400);
            this.Property(pv => pv.ManufacturerPartNumber).HasMaxLength(400);
            this.Property(pv => pv.Gtin).HasMaxLength(400);

            this.HasRequired(pvac => pvac.ProductVariant)
                .WithMany(pv => pv.ProductVariantAttributeCombinations)
                .HasForeignKey(pvac => pvac.ProductVariantId);
        }
    }
}