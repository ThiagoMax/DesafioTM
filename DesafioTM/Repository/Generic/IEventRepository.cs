using DesafioTM.Model;
using DesafioTM.Repository.Generic;
using System.Collections.Generic;

namespace DesafioTM.Repository
{
    public interface IEventRepository : IRepository<Event>
    {
        List<Event> FindByName(string name);
    }
}
