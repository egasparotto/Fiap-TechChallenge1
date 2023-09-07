using FiapBlog.Data.Context;
using FiapBlog.Data.Repositories.Base;
using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Repositories.Categories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Data.Repositories.Categories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context, ILogger<BaseRepository<Category>> logger) : base(context, logger)
        {
        }
    }
}
