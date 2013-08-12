using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Directory;

namespace Nas.Data.Mapping.Directory
{
    public partial class MeasureDimensionMap : EntityTypeConfiguration<MeasureDimension>
    {
        public MeasureDimensionMap()
        {
            this.ToTable("MeasureDimension");
            this.HasKey(m => m.Id);
            this.Property(m => m.Name).IsRequired().HasMaxLength(100);
            this.Property(m => m.SystemKeyword).IsRequired().HasMaxLength(100);
            this.Property(m => m.Ratio).HasPrecision(18, 8);
        }
    }
}