using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Entities.Posts
{
    public class Post : Entity, IAggregateRoot
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
