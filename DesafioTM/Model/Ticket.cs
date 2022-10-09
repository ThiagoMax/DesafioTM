using DesafioTM.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioTM.Model
{
    [Table("ticket")]
    public class Ticket : BaseEntity
    {
        [Column("purchase_id")]
        public long Purchase_Id { get; set; }
        
        [Column("event_id")]
        public long Event_Id { get; set; }
        
        [Column("event_name")]
        public string EventName { get; set; }
        
        [Column("event_date")]
        public DateTime EventDate { get; set; }
        
        [Column("event_location")]
        public string EventLocation { get; set; }
        
        [Column("type")]
        public string Type { get; set; }
    }
}
