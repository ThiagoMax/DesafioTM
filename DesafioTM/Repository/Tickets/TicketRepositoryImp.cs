using DesafioTM.Model;
using DesafioTM.Model.Context;
using DesafioTM.Repository.Generic;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTM.Repository.Tickets
{
    public class TicketRepositoryImp : GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepositoryImp(MySQLContext context) : base(context) {}

        public List<Ticket> FindByEventId(long id)
        {
            var events = _context.Events.SingleOrDefault(e => e.Id.Equals(id));
            var tickets_event = _context.Tickets.Where(t => t.Event_Id.Equals(events.Id)).ToList();
            return tickets_event;
        }

        public List<Ticket> FindByPurchaseId(long id)
        {
            var purchase = _context.Purchases.SingleOrDefault(p => p.Id.Equals(id));
            var tickets_purchase = _context.Tickets.Where(t => t.Purchase_Id.Equals(purchase.Id)).ToList();
            return tickets_purchase;
        }

        public List<Ticket> FindByTicketType(string type)
        {
            var tickets_type = _context.Tickets.Where(t => t.Type.Equals(type)).ToList();
            return tickets_type;
        }
    }
}
