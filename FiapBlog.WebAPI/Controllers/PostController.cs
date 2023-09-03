using FiapBlog.Domain.Entities.Posts;
using FiapBlog.Domain.Interfaces.Services.Posts;
using FiapBlog.WebAPI.Model.Posts;

using Microsoft.AspNetCore.Mvc;

namespace FiapBlog.WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PostController : BaseController<Post, IPostService>
    {
        public PostController(IPostService service) : base(service)
        {
        }

        [HttpGet]
        public virtual IActionResult GetAll()
        {
            return Ok(Service.GetAll());
        }

        [HttpGet]
        [Route("{id:int}")]
        public virtual IActionResult GetById([FromRoute] int id)
        {
            return Ok(Service.GetById(id));
        }

        [HttpPost]
        public virtual IActionResult Insert([FromBody] InsertPostDTO entity)
        {
            var post = new Post()
            {
                Content = entity.Content,
                Title = entity.Title
            };

            Service.Insert(post);
            return Ok();
        }

        [HttpPut]
        public virtual IActionResult Update([FromBody] UpdatePostDTO entity)
        {
            var post = new Post()
            {
                Id = entity.Id,
                Content = entity.Content,
                Title = entity.Title
            };

            Service.Update(post);
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public virtual IActionResult Delete([FromRoute] int id)
        {
            Service.Delete(id);
            return Ok();
        }

    }
}
