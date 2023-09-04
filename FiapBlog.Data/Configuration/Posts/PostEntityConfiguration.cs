using FiapBlog.Domain.Entities.Posts;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Data.Configuration.Posts
{
    public class PostEntityConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("POSTS");
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title);
            builder.Property(x => x.Content);

            builder.HasMany(x => x.Categories).WithMany().UsingEntity("POSTSCATEGORIES");

        }
    }
}
