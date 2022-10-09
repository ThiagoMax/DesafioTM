using DesafioTM.Model;
using DesafioTM.Repository.Generic;
using System.Collections.Generic;

namespace DesafioTM.Repository.Tickets
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        List<Ticket> FindByPurchaseId(long id);
        List<Ticket> FindByEventId(long id);
        List<Ticket> FindByTicketType(string type);
    }
}
