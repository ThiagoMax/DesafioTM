using DesafioTM.Model;
using DesafioTM.Model.DTO;
using System.Collections.Generic;

namespace DesafioTM.Business
{
    public interface IEvent
    {
        EventDTO Create(Event evento);
        EventDTO FindById(long id);
        EventDTO Update(Event evento);
        void Delete(long id);
        List<EventDTO> FindAll();

    }
}
