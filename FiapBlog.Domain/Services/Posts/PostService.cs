using FiapBlog.Domain.Entities.Posts;
using FiapBlog.Domain.Interfaces.Repositories.Posts;
using FiapBlog.Domain.Interfaces.Services.Base;
using FiapBlog.Domain.Interfaces.Services.Posts;
using FiapBlog.Domain.Services.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Services.Posts
{
    public class PostService : BaseService<Post, IPostRepository>, IPostService
    {
        public PostService(IPostRepository repository) : base(repository)
        {
        }
    }
}
