using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Catalog;

namespace Nas.Data.Mapping.Catalog
{
    public partial class ManufacturerTemplateMap : EntityTypeConfiguration<ManufacturerTemplate>
    {
        public ManufacturerTemplateMap()
        {
            this.ToTable("ManufacturerTemplate");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired().HasMaxLength(400);
            this.Property(p => p.ViewPath).IsRequired().HasMaxLength(400);
        }
    }
}