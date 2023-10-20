using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Entities.Posts;
using FiapBlog.Domain.Interfaces.Repositories.Posts;
using FiapBlog.Domain.Interfaces.Services.Categories;
using FiapBlog.Domain.Interfaces.Services.Posts;
using FiapBlog.Domain.Services.Base;

namespace FiapBlog.Domain.Services.Posts
{
    public class PostService : BaseService<Post, IPostRepository>, IPostService
    {
        protected ICategoryService CategoryService { get; }
        public PostService(IPostRepository repository, ICategoryService categoryService) : base(repository)
        {
            CategoryService = categoryService;
        }

        public override void Insert(Post entity)
        {
            var categories = new List<Category>();

            foreach (var category in entity.Categories)
            {
                categories.Add(CategoryService.GetById(category.Id));
            }
            entity.Categories = categories;

            base.Insert(entity);
        }

        public override void Update(Post entity)
        {
            var categories = new List<Category>();

            foreach (var category in entity.Categories)
            {
                categories.Add(CategoryService.GetById(category.Id));
            }
            entity.Categories = categories;

            base.Update(entity);
        }
    }
}
