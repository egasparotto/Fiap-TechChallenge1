using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Entities.Posts;
using FiapBlog.Domain.Interfaces.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Entities.Categories
{
    public class Category : Entity, IAggregateRoot
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
