namespace FiapBlog.WebAPI.Model.Categories
{
    /// <summary>
    /// DTO de edição de Categoria 
    /// </summary>
    public class UpdateCategoryDTO
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
