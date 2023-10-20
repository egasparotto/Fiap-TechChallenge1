using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Interfaces.Entities.Base;

namespace FiapBlog.Domain.Entities.Categories
{
    /// <summary>
    /// Categoria de um post
    /// </summary>
    public class Category : Entity, IAggregateRoot
    {
        /// <summary>
        /// Id da categoria
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }
        /// <summary>
        /// Descrição da categoria
        /// </summary>
        /// <example>Vendas</example>
        public string Description { get; set; }
    }
}
