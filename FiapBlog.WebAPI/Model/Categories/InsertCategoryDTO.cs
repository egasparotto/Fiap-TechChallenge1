namespace FiapBlog.WebAPI.Model.Categories
{
    /// <summary>
    /// DTO de inserção de Categoria 
    /// </summary>
    public class InsertCategoryDTO
    {
        /// <summary>
        /// Descrição da categoria
        /// </summary>
        /// <example>Vendas</example>
        public string Description { get; set; }
    }
}
