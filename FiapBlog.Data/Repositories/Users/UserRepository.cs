using FiapBlog.Data.Context;
using FiapBlog.Data.Repositories.Base;
using FiapBlog.Domain.Entities.Users;
using FiapBlog.Domain.Interfaces.Repositories.Users;

using Microsoft.Extensions.Logging;

namespace FiapBlog.Data.Repositories.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context, ILogger<BaseRepository<User>> logger) : base(context, logger)
        {
        }
    }
}
