using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Orders;

namespace Nas.Data.Mapping.Orders
{
    public partial class GiftCardMap : EntityTypeConfiguration<GiftCard>
    {
        public GiftCardMap()
        {
            this.ToTable("GiftCard");
            this.HasKey(gc => gc.Id);

            this.Property(gc => gc.Amount).HasPrecision(18, 4);

            this.Ignore(gc => gc.GiftCardType);

            this.HasOptional(gc => gc.PurchasedWithOrderProductVariant)
                .WithMany(opv => opv.AssociatedGiftCards)
                .HasForeignKey(gc => gc.PurchasedWithOrderProductVariantId);
        }
    }
}