namespace FiapBlog.WebAPI.Model.Posts
{
    /// <summary>
    /// DTO de inserção de Post 
    /// </summary>
    public class InsertPostDTO
    {
        /// <summary>
        /// Título do post
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
        /// <example>[1,2]</example>
        public int[] Categories { get; set; }
    }
}
