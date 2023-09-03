using FiapBlog.Domain.Interfaces.Services.Posts;
using FiapBlog.Domain.Services.Posts;

namespace FiapBlog.WebAPI.Configuration
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();

            return services;
        }
    }
}
