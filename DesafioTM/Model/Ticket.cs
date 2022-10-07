using DesafioTM.Model.Base;
using System;

namespace DesafioTM.Model
{
    public class Ticket : BaseEntity
    {
        public Purchase Purchase_Id { get; set; }
        public Event Event_Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
    }
}
