using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Blogs;

namespace Nas.Data.Mapping.Blogs
{
    public partial class BlogCommentMap : EntityTypeConfiguration<BlogComment>
    {
        public BlogCommentMap()
        {
            this.ToTable("BlogComment");
            this.HasKey(pr => pr.Id);

            this.HasRequired(bc => bc.BlogPost)
                .WithMany(bp => bp.BlogComments)
                .HasForeignKey(bc => bc.BlogPostId);

            this.HasRequired(cc => cc.Customer)
                .WithMany()
                .HasForeignKey(cc => cc.CustomerId);
        }
    }
}