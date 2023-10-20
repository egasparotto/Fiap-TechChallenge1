using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Entities.Posts;
using FiapBlog.Domain.Interfaces.Services.Posts;
using FiapBlog.WebAPI.Model.Posts;

using Microsoft.AspNetCore.Authorization;
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
        /// <summary>
        /// Obtém todos os posts cadastrados
        /// </summary>
        /// <response code="200">Lista com todos os posts</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Post>), 200)]
        public virtual IActionResult GetAll()
        {
            return Ok(Service.GetAll());
        }

        /// <summary>
        /// Obter os posts por id
        /// </summary>
        /// <param name="id">Id do post</param>
        /// <response code="200">Post consultado</response>
        /// <response code="404">Post não encontrado</response>
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(Post), 200)]
        [ProducesResponseType(typeof(void), 404)]
        public virtual IActionResult GetById([FromRoute] int id)
        {
            return Ok(Service.GetById(id));
        }

        /// <summary>
        /// Insere um novo post
        /// </summary>
        /// <param name="entity">DTO para criação do post</param>
        /// <response code="201">Post criado com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(Post), 201)]
        [ProducesResponseType(typeof(void), 401)]
        public virtual IActionResult Insert([FromBody] InsertPostDTO entity)
        {
            var post = new Post()
            {
                Content = entity.Content,
                Title = entity.Title,
                Categories = entity.Categories.Select(x => new Category() { Id = x })
            };

            Service.Insert(post);
            return Created(new Uri($"{Request.Path}/{post.Id}", UriKind.Relative), post);
        }

        /// <summary>
        /// Altera um post existente
        /// </summary>
        /// <param name="entity">DTO para alteração do post</param>
        /// <response code="200">Post editado com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        /// <response code="404">Post não encontrado</response>
        [HttpPut]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(Post), 200)]
        [ProducesResponseType(typeof(void), 404)]
        [ProducesResponseType(typeof(void), 401)]
        public virtual IActionResult Update([FromBody] UpdatePostDTO entity)
        {
            var post = Service.GetById(entity.Id);

            if (post == null)
            {
                return NotFound();
            }

            post.Title = entity.Title;
            post.Content = entity.Content;
            post.Categories = entity.Categories.Select(x => new Category() { Id = x });

            Service.Update(post);
            return Ok(post);
        }

        /// <summary>
        /// Exclui um post
        /// </summary>
        /// <param name="id">Id do post</param>
        /// <response code="200">Post excluido com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        [HttpDelete]
        [Route("{id:int}")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(void), 200)]
        [ProducesResponseType(typeof(void), 401)]
        public virtual IActionResult Delete([FromRoute] int id)
        {
            Service.Delete(id);
            return Ok();
        }

    }
}
