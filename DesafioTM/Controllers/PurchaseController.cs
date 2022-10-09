using DesafioTM.Business;
using DesafioTM.Business.Purchases;
using DesafioTM.Model;
using DesafioTM.Model.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace DesafioTM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseController : ControllerBase
    {
        private IPurchase _purchase;

        public PurchaseController(IPurchase purchase)
        {
            _purchase = purchase;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_purchase.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var purchase = _purchase.FindById(id);
            
            if (purchase == null) return NotFound("Não foi encontrado uma compra com esse código.");
            return Ok(purchase);
        }

        [HttpGet("user/{id}")]
        public IActionResult GetByUserId(long id)
        {
            var purchase = _purchase.FindByUserId(id);

            if (purchase == null) return NotFound("Não foi encontrado compras desse usuário.");
            return Ok(purchase);
        }

        [HttpGet("date/{purchase_date}")]
        public IActionResult GetByEventDate(string purchase_date)
        {
            var evento = _purchase.FindByPurchaseDate(purchase_date);

            if (evento == null) return NotFound("Não foi encontrado compras nessa data.");
            return Ok(evento);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] PurchaseDTO purchase)
        {
            if (purchase == null) return BadRequest();
            return Ok(_purchase.Create(purchase));
        }

        [HttpPut()]
        public IActionResult Update([FromBody] PurchaseDTO purchase)
        {
            if (purchase == null) return BadRequest("Esta compra não existe");
            return Ok(_purchase.Update(purchase));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _purchase.Delete(id);
            return NoContent();
        }
    }
}
