using FiapBlog.Data.Repositories.Categories;
using FiapBlog.Data.Repositories.Posts;
using FiapBlog.Data.Repositories.Users;
using FiapBlog.Domain.Interfaces.Repositories.Categories;
using FiapBlog.Domain.Interfaces.Repositories.Posts;
using FiapBlog.Domain.Interfaces.Repositories.Users;

namespace FiapBlog.WebAPI.Configuration
{
    public static class RepositoriesConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
