using FiapBlog.Domain.Entities.Users;
using FiapBlog.Domain.Interfaces.Services.Users;
using FiapBlog.Domain.Utils.Cryptography;
using FiapBlog.WebAPI.Model.Users;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FiapBlog.WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Administrator")]
    public class UserController : BaseController<User, IUserService>
    {
        public UserController(IUserService service) : base(service)
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
        public virtual IActionResult Insert([FromBody] InsertUserDTO entity)
        {
            var user = new User()
            {
                Name = entity.Name,
                Username = entity.Username,
                Password = PasswordCryptography.Encrypt(entity.Password),
                Type = entity.Type
            };

            Service.Insert(user);
            return Ok();
        }

        [HttpPut]
        public virtual IActionResult Update([FromBody] UpdateUserDTO entity)
        {
            var user = Service.GetById(entity.Id);

            if (user == null)
            {
                return NotFound();
            }

            user.Name = entity.Name;
            user.Username = entity.Username;
            user.Password = PasswordCryptography.Encrypt(entity.Password) ?? user.Password;
            user.Type = entity.Type;

            Service.Update(user);
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
