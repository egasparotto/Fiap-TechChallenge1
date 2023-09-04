using FiapBlog.Domain.Interfaces.Services.Categories;
using FiapBlog.Domain.Interfaces.Services.Posts;
using FiapBlog.Domain.Services.Categories;
using FiapBlog.Domain.Services.Posts;

namespace FiapBlog.WebAPI.Configuration
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}
