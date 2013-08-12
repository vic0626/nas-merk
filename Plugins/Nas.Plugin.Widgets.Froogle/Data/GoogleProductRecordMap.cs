using System.Data.Entity.ModelConfiguration;
using Nas.Plugin.Feed.Froogle.Domain;

namespace Nas.Plugin.Feed.Froogle.Data
{
    public partial class GoogleProductRecordMap : EntityTypeConfiguration<GoogleProductRecord>
    {
        public GoogleProductRecordMap()
        {
            this.ToTable("GoogleProduct");
            this.HasKey(x => x.Id);
        }
    }
}