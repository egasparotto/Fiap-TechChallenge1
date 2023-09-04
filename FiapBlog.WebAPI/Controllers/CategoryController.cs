using FiapBlog.Domain.Entities.Categories;
using FiapBlog.Domain.Interfaces.Services.Categories;
using FiapBlog.WebAPI.Model.Categories;

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
        public virtual IActionResult Insert([FromBody] InsertCategoryDTO entity)
        {
            var category = new Category()
            {
                Description = entity.Description
            };

            Service.Insert(category);
            return Ok();
        }

        [HttpPut]
        public virtual IActionResult Update([FromBody] UpdateCategoryDTO entity)
        {
            var category = Service.GetById(entity.Id);

            if (category == null)
            {
                return NotFound();
            }

            category.Description = entity.Description;
            Service.Update(category);
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
