using DesafioTM.Business;
using DesafioTM.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUsers _users;

        public UsersController(IUsers users)
        {
            _users = users;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_users.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var evento = _users.FindById(id);
            
            if (evento == null) return NotFound("Não foi encontrado um usuário com esse código.");
            return Ok(evento);
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var evento = _users.FindByName(name);

            if (evento == null) return NotFound("Não foi encontrado usuários com esse nome.");
            return Ok(evento);
        }

        [HttpGet("type/{type}")]
        public IActionResult GetByType(string type)
        {
            var evento = _users.FindByType(type);

            if (evento == null) return NotFound("Não foi encontrado usuários desse tipo.");
            return Ok(evento);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] UsersDTO users)
        {
            if (users == null) return BadRequest();
            return Ok(_users.Create(users));
        }

        [HttpPut()]
        public IActionResult Update([FromBody] UsersDTO users)
        {
            if (users == null) return BadRequest("Este evento não existe");
            return Ok(_users.Update(users));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _users.Delete(id);
            return NoContent();
        }
    }
}
