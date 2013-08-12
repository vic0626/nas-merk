using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Catalog;

namespace Nas.Data.Mapping.Catalog
{
    public partial class RelatedProductMap : EntityTypeConfiguration<RelatedProduct>
    {
        public RelatedProductMap()
        {
            this.ToTable("RelatedProduct");
            this.HasKey(c => c.Id);
        }
    }
}