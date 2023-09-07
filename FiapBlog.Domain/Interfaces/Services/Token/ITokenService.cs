using FiapBlog.Domain.Entities.Users;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Interfaces.Services.Token
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
