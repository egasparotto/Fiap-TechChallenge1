using FiapBlog.Domain.Enums.Users;

namespace FiapBlog.WebAPI.Model.Users
{
    public class InsertUserDTO
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
    }
}
