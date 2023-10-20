using FiapBlog.Domain.Entities.Users;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FiapBlog.Data.Configuration.Users
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USERS");
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}