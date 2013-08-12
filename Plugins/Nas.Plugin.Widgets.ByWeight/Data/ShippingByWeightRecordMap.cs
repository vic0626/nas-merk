using System.Data.Entity.ModelConfiguration;
using Nas.Plugin.Shipping.ByWeight.Domain;

namespace Nas.Plugin.Shipping.ByWeight.Data
{
    public partial class ShippingByWeightRecordMap : EntityTypeConfiguration<ShippingByWeightRecord>
    {
        public ShippingByWeightRecordMap()
        {
            this.ToTable("ShippingByWeight");
            this.HasKey(x => x.Id);

            this.Property(x => x.Zip).HasMaxLength(400);
        }
    }
}