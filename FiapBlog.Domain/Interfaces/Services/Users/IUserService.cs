using FiapBlog.Domain.Entities.Users;
using FiapBlog.Domain.Interfaces.Services.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Interfaces.Services.Users
{
    public interface IUserService : IBaseService<User>
    {
    }
}
