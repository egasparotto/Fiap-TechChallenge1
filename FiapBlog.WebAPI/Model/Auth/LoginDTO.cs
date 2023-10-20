namespace FiapBlog.WebAPI.Model.Auth
{
    public class LoginDTO
    {
        /// <summary>
        /// Usuário
        /// </summary>
        /// <example>Admin</example>
        public string Username { get; set; }
        /// <summary>
        /// Senha
        /// </summary>
        /// <example>Admin</example>
        public string Password { get; set; }
    }
}
