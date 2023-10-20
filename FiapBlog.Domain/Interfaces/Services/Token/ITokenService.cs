using FiapBlog.Domain.Entities.Users;

namespace FiapBlog.Domain.Interfaces.Services.Token
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
