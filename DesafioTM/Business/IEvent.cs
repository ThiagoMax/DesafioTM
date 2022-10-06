using DesafioTM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTM.Business
{
    public interface IEvent
    {
        Event Create(Event eventt);
        Event FindById(long id);
        Event Update(Event eventt);
        void Delete(long id);
        List<Event> FindAll();

    }
}
