﻿using FiapBlog.Domain.Entities.Users;
using FiapBlog.Domain.Interfaces.Repositories.Users;
using FiapBlog.Domain.Interfaces.Services.Users;
using FiapBlog.Domain.Services.Base;

namespace FiapBlog.Domain.Services.Users
{
    public class UserService : BaseService<User, IUserRepository>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }
    }
}
