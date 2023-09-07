using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Enums.Users;
using FiapBlog.Domain.Interfaces.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Entities.Users
{
    public class User : Entity, IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
    }
}
