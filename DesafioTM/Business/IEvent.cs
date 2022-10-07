using DesafioTM.Model.DTO;
using System.Collections.Generic;

namespace DesafioTM.Business
{
    public interface IEvent
    {
        EventDTO Create(EventDTO evento);
        EventDTO FindById(long id);
        List<EventDTO> FindByName(string type);
        List<EventDTO> FindByType(string type);
        EventDTO Update(EventDTO evento);
        void Delete(long id);
        List<EventDTO> FindAll();

    }
}
