using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Repositories.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Interfaces.Repositories.Categories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
    }
}
