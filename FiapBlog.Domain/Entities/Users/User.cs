using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Enums.Users;
using FiapBlog.Domain.Interfaces.Entities.Base;
using FiapBlog.Domain.Utils.Cryptography;

using System.Text.Json.Serialization;

namespace FiapBlog.Domain.Entities.Users
{
    /// <summary>
    /// Usuário do blog
    /// </summary>
    public class User : Entity, IAggregateRoot
    {
        /// <summary>
        /// Id do Usuário
        /// </summary>
        /// <example>2</example>
        public int Id { get; set; }
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
        /// <example>SenhaSuperSecreta</example>
        [JsonIgnore]
        public string Password { get; set; }
        /// <summary>
        /// Tipo do Usuario
        /// </summary>
        /// <example>2</example>
        public UserType Type { get; set; }

        public bool ValidatePassword(string password)
        {
            return PasswordCryptography.Validate(password, Password);
        }
    }
}
