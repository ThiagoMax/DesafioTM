using DesafioTM.Model.Base;
using DesafioTM.Model.Perfil;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioTM.Model
{
    [Table("event")]
    public class Event
    {
        [Column("id")]
        public long Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("location")]
        public string Location { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("org_name")]
        public string OrganizerName { get; set; }

        [Column("tickets_qt")]
        public int TicketsQt { get; set; }
    }
}
