using DesafioTM.Model;
using DesafioTM.Repository.Generic;
using System.Collections.Generic;

namespace DesafioTM.Repository
{
    public interface IEventRepository : IRepository<Event>
    {
        List<Event> FindByType(string type);
        List<Event> FindByName(string name);
    }
}
