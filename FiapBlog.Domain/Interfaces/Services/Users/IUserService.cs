using FiapBlog.Domain.Entities.Users;
using FiapBlog.Domain.Interfaces.Services.Base;

namespace FiapBlog.Domain.Interfaces.Services.Users
{
    public interface IUserService : IBaseService<User>
    {
        public User GetByUsername(string username);
    }
}
