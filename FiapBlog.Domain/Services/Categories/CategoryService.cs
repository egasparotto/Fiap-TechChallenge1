using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Repositories.Categories;
using FiapBlog.Domain.Interfaces.Services.Categories;
using FiapBlog.Domain.Services.Base;

namespace FiapBlog.Domain.Services.Categories
{
    public class CategoryService : BaseService<Category, ICategoryRepository>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository) : base(repository)
        {
        }
    }
}
