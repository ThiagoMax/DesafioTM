using DesafioTM.Business;
using DesafioTM.Model;
using DesafioTM.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private IEvent _event;

        public EventController(IEvent eventt)
        {
            _event = eventt;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_event.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var evento = _event.FindById(id);
            
            if (evento == null) return NotFound("Não foi encontrado um evento com esse código.");
            return Ok(evento);
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var evento = _event.FindByName(name);

            if (evento == null) return NotFound("Não foi encontrado eventos com esse nome.");
            return Ok(evento);
        }

        [HttpGet("type/{type}")]
        public IActionResult GetByType(string type)
        {
            var evento = _event.FindByType(type);

            if (evento == null) return NotFound("Não foi encontrado eventos dessa categoria.");
            return Ok(evento);
        }

        [HttpGet("location/{location}")]
        public IActionResult GetByLocation(string location)
        {
            var evento = _event.FindByLocation(location);

            if (evento == null) return NotFound("Não foi encontrado eventos nessa cidade.");
            return Ok(evento);
        }

        [HttpGet("org_name/{org_name}")]
        public IActionResult GetByOrganizerName(string org_name)
        {
            var evento = _event.FindByOrganizerName(org_name);

            if (evento == null) return NotFound("Não foi encontrado eventos nessa cidade.");
            return Ok(evento);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] EventDTO evento)
        {
            if (evento == null) return BadRequest();
            return Ok(_event.Create(evento));
        }

        [HttpPut()]
        public IActionResult Update([FromBody] EventDTO evento)
        {
            if (evento == null) return BadRequest("Este evento não existe");
            return Ok(_event.Update(evento));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _event.Delete(id);
            return NoContent();
        }
    }
}
