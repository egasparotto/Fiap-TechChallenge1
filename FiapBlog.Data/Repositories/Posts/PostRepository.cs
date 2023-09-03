using FiapBlog.Data.Context;
using FiapBlog.Data.Repositories.Base;
using FiapBlog.Domain.Entities.Posts;
using FiapBlog.Domain.Interfaces.Repositories.Posts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Data.Repositories.Posts
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
