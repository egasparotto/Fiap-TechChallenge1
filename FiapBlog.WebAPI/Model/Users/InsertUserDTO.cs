using FiapBlog.Domain.Enums.Users;

namespace FiapBlog.WebAPI.Model.Users
{
    /// <summary>
    /// DTO de inserção de Usuário 
    /// </summary>
    public class InsertUserDTO
    {
        /// <summary>
        /// Nome do usuário
        /// </summary>
        /// <example>Joao da Silva</example>
        public string Name { get; set; }
        /// <summary>
        /// Login do usuário
        /// </summary>
        /// <example>joao</example>
        public string Username { get; set; }
        /// <summary>
        /// Senha do usuário
        /// </summary>
        /// <example>Senha Super Secreta</example>
        public string Password { get; set; }
        /// <summary>
        /// Tipo do Usuario
        /// </summary>
        /// <example>2</example>
        public UserType Type { get; set; }
    }
}
