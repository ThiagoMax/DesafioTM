using System;

namespace DesafioTM.Model.DTO
{
    public class TicketDTO
    {
        public long Id { get; set; }
        public long Purchase_Id { get; set; }
        public long Event_Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string Type { get; set; }
    }
}
