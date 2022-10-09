using System;

namespace DesafioTM.Model.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string OrganizerName { get; set; }
        public int TicketsQt { get; set; }
    }
}
