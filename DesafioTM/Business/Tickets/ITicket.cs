using DesafioTM.Model;
using DesafioTM.Model.DTO;
using System.Collections.Generic;

namespace DesafioTM.Business.Tickets
{
    public interface ITicket
    {
        TicketDTO Create(TicketDTO ticket);
        TicketDTO FindById(long id);
        List<TicketDTO> FindByPurchaseId(long id);
        List<TicketDTO> FindByEventId(long id);
        List<TicketDTO> FindByTicketType(string type);
        List<TicketDTO> FindAll();
        TicketDTO Update(TicketDTO ticket);
        void Delete(long id);
    }
}
