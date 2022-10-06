using DesafioTM.Model.Base;
using DesafioTM.Model.Perfil;
using System;

namespace DesafioTM.Model
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int TicketsQt { get; set; }
        public string Type { get; set; }
        public Organizer OrganizerName { get; set; }
    }
}
