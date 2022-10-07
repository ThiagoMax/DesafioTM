using DesafioTM.Business;
using DesafioTM.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult Get(long id)
        {
            var evento = _event.FindById(id);
            
            if (evento == null) return NotFound("O evento não existe.");
            return Ok(evento);
            
        }

        [HttpPost()]
        public IActionResult Create([FromBody] Event evento)
        {
            if (evento == null) return BadRequest();
            return Ok(_event.Create(evento));
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Event evento)
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
