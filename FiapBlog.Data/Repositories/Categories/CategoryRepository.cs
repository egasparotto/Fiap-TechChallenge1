using FiapBlog.Data.Context;
using FiapBlog.Data.Repositories.Base;
using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Repositories.Categories;

using Microsoft.Extensions.Logging;

namespace FiapBlog.Data.Repositories.Categories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context, ILogger<BaseRepository<Category>> logger) : base(context, logger)
        {
        }
    }
}
