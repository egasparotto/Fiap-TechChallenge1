using FiapBlog.Domain.Entities.Categories;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FiapBlog.Data.Configuration.Categories
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("CATEGORIES");
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description);
        }
    }
}
