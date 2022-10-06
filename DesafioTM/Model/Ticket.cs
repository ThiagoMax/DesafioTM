using DesafioTM.Model.Base;
using System;

namespace DesafioTM.Model
{
    public class Ticket : BaseEntity
    {
        public Purchase Compra_Id { get; set; }
        public Event Evento_Id { get; set; }
        public string NomeEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public string LocalEvento { get; set; }
    }
}
