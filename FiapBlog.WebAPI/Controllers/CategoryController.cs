using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Services.Categories;
using FiapBlog.WebAPI.Model.Categories;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FiapBlog.WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CategoryController : BaseController<Category, ICategoryService>
    {
        public CategoryController(ICategoryService service) : base(service)
        {
        }

        /// <summary>
        /// Obtém todas as categorias cadastradas
        /// </summary>
        /// <response code="200">Lista com todas as categorias</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Category>), 200)]
        public virtual IActionResult GetAll()
        {
            return Ok(Service.GetAll());
        }

        /// <summary>
        /// Obter as categorias por id
        /// </summary>
        /// <param name="id">Id da categoria</param>
        /// <response code="200">Categoria consultada</response>
        /// <response code="404">Categoria não encontrada</response>
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(Category), 200)]
        [ProducesResponseType(typeof(void), 404)]
        public virtual IActionResult GetById([FromRoute] int id)
        {
            var category = Service.GetById(id);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Insere uma nova categoria
        /// </summary>
        /// <param name="entity">DTO para criação da categoria</param>
        /// <response code="201">Categoria criada com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(Category), 201)]
        [ProducesResponseType(typeof(void), 401)]
        public virtual IActionResult Insert([FromBody] InsertCategoryDTO entity)
        {
            var category = new Category()
            {
                Description = entity.Description
            };

            Service.Insert(category);
            return Created(new Uri($"{Request.Path}/{category.Id}", UriKind.Relative), category);
        }

        /// <summary>
        /// Altera uma categoria existente
        /// </summary>
        /// <param name="entity">DTO para alteração da categoria</param>
        /// <response code="200">Categoria editada com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        /// <response code="404">Categoria não encontrada</response>
        [HttpPut]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(Category), 200)]
        [ProducesResponseType(typeof(void), 404)]
        [ProducesResponseType(typeof(void), 401)]
        public virtual IActionResult Update([FromBody] UpdateCategoryDTO entity)
        {
            var category = Service.GetById(entity.Id);

            if (category == null)
            {
                return NotFound();
            }

            category.Description = entity.Description;
            Service.Update(category);
            return Ok(category);
        }

        /// <summary>
        /// Exclui uma categoria
        /// </summary>
        /// <param name="id">Id da categoria</param>
        /// <response code="200">Categoria excluida com sucesso</response>
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
