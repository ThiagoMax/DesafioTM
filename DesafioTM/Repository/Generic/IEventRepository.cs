using DesafioTM.Model;
using DesafioTM.Repository.Generic;
using System;
using System.Collections.Generic;

namespace DesafioTM.Repository
{
    public interface IEventRepository : IRepository<Event>
    {
        List<Event> FindByType(string type);
        List<Event> FindByName(string name);
        List<Event> FindByLocation(string location);
        List<Event> FindByOrganizerName(string name);
        List<Event> FindByEventDate(DateTime date); 
    }
}
