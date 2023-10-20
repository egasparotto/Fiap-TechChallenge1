using FiapBlog.Data.Context;
using FiapBlog.Data.Repositories.Base;
using FiapBlog.Domain.Entities.Posts;
using FiapBlog.Domain.Interfaces.Repositories.Posts;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FiapBlog.Data.Repositories.Posts
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext context, ILogger<BaseRepository<Post>> logger) : base(context, logger)
        {
        }

        public override IQueryable<Post> GetAll()
        {
            return base.GetAll()
                       .Include(x => x.Categories);
        }
    }
}
