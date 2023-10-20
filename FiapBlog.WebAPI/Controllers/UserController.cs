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
        /// <summary>
        /// Obtém todos os usuários cadastrados
        /// </summary>
        /// <response code="200">Lista com todos os usuários</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<User>), 200)]
        public virtual IActionResult GetAll()
        {
            return Ok(Service.GetAll());
        }

        /// <summary>
        /// Obter os usuários por id
        /// </summary>
        /// <param name="id">Id do usuário</param>
        /// <response code="200">Usuário consultado</response>
        /// <response code="404">Usuário não encontrado</response>
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(typeof(void), 404)]
        public virtual IActionResult GetById([FromRoute] int id)
        {
            return Ok(Service.GetById(id));
        }

        /// <summary>
        /// Insere um novo usuário
        /// </summary>
        /// <param name="entity">DTO para criação do usuário</param>
        /// <response code="201">Usuário criado com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        [HttpPost]
        [ProducesResponseType(typeof(User), 201)]
        [ProducesResponseType(typeof(void), 401)]
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
            return Created(new Uri($"{Request.Path}/{user.Id}", UriKind.Relative), user);
        }

        /// <summary>
        /// Altera um usuário existente
        /// </summary>
        /// <param name="entity">DTO para alteração do usuário</param>
        /// <response code="200">Usuário editado com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        /// <response code="404">Usuário não encontrado</response>
        [HttpPut]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(typeof(void), 404)]
        [ProducesResponseType(typeof(void), 401)]
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
            return Ok(user);
        }

        /// <summary>
        /// Exclui um usuário
        /// </summary>
        /// <param name="id">Id do usuário</param>
        /// <response code="200">Usuário excluido com sucesso</response>
        /// <response code="401">Usuário sem permissão</response>
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(void), 200)]
        [ProducesResponseType(typeof(void), 401)]
        public virtual IActionResult Delete([FromRoute] int id)
        {
            Service.Delete(id);
            return Ok();
        }

    }
}
