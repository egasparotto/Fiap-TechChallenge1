using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Interfaces.Entities.Base;
using FiapBlog.Domain.Interfaces.Services.Base;

using Microsoft.AspNetCore.Mvc;

namespace FiapBlog.WebAPI.Controllers
{
    [Route("[controller]")]
    public abstract class BaseController<TEntity, TService> : ControllerBase
        where TEntity : Entity, IAggregateRoot
        where TService : IBaseService<TEntity>
    {
        protected TService Service { get; set; }

        protected BaseController(TService service)
        {
            Service = service;
        }
    }
}
