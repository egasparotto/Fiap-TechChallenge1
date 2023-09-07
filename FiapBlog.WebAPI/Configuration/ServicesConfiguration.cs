using FiapBlog.Domain.Interfaces.Services.Categories;
using FiapBlog.Domain.Interfaces.Services.Posts;
using FiapBlog.Domain.Interfaces.Services.Token;
using FiapBlog.Domain.Interfaces.Services.Users;
using FiapBlog.Domain.Services.Categories;
using FiapBlog.Domain.Services.Posts;
using FiapBlog.Domain.Services.Token;
using FiapBlog.Domain.Services.Users;

namespace FiapBlog.WebAPI.Configuration
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
    }
}
