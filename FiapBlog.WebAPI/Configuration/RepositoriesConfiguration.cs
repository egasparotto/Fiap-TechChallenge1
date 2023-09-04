using FiapBlog.Data.Repositories.Categories;
using FiapBlog.Data.Repositories.Posts;
using FiapBlog.Domain.Interfaces.Repositories.Categories;
using FiapBlog.Domain.Interfaces.Repositories.Posts;

namespace FiapBlog.WebAPI.Configuration
{
    public static class RepositoriesConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}
