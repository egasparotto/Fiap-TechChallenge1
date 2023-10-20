using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Entities.Base;

namespace FiapBlog.Domain.Entities.Posts
{
    /// <summary>
    /// Post
    /// </summary>
    public class Post : Entity, IAggregateRoot
    {
        /// <summary>
        /// Id do post
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }
        /// <summary>
        /// Titulo do post
        /// </summary>
        /// <example>Veja as novas tendencias de vendas</example>
        public string Title { get; set; }
        /// <summary>
        /// Conteúdo do post
        /// </summary>
        /// <example>Aqui temos o texto do post, espero que goste do nosso post</example>
        public string Content { get; set; }
        /// <summary>
        /// Categorias do post
        /// </summary>
        public IEnumerable<Category> Categories { get; set; }
    }
}
