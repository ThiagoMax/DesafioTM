using DesafioTM.Business.Tickets;
using DesafioTM.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private ITicket _ticket;

        public TicketController(ITicket ticket)
        {
            _ticket = ticket;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ticket.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var ticket = _ticket.FindById(id);
            
            if (ticket == null) return NotFound("Não foi encontrado um ingresso com esse código.");
            return Ok(ticket);
        }

        [HttpGet("type/{type}")]
        public IActionResult GetByType(string type)
        {
            var ticket = _ticket.FindByTicketType(type);

            if (ticket == null) return NotFound("Não foi encontrado ingressos dessa categoria.");
            return Ok(ticket);
        }

        [HttpGet("purchase_id/{purchase_id}")]
        public IActionResult GetByPurchaseId(long purchase_id)
        {
            var ticket = _ticket.FindByPurchaseId(purchase_id);

            if (ticket == null) return NotFound("Não foi encontrado ingressos desse código de compra.");
            return Ok(ticket);
        }

        [HttpGet("event_id/{event_id}")]
        public IActionResult GetByEventId(long event_id)
        {
            var ticket = _ticket.FindByEventId(event_id);

            if (ticket == null) return NotFound("Não foi encontrado ingressos desse Evento.");
            return Ok(ticket);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] TicketDTO ticket)
        {
            if (ticket == null) return BadRequest();
            return Ok(_ticket.Create(ticket));
        }

        [HttpPut()]
        public IActionResult Update([FromBody] TicketDTO ticket)
        {
            if (ticket == null) return BadRequest("Este ingresso não existe");
            return Ok(_ticket.Update(ticket));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _ticket.Delete(id);
            return NoContent();
        }
    }
}
