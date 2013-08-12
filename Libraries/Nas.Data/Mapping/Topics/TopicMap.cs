using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Topics;

namespace Nas.Data.Mapping.Topics
{
    public class TopicMap : EntityTypeConfiguration<Topic>
    {
        public TopicMap()
        {
            this.ToTable("Topic");
            this.HasKey(t => t.Id);
        }
    }
}
