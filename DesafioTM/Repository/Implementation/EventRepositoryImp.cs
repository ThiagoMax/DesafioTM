using DesafioTM.Model;
using DesafioTM.Model.Context;
using DesafioTM.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTM.Repository.Implementation
{
    public class EventRepositoryImp : GenericRepository<Event>, IEventRepository
    {
        public EventRepositoryImp(MySQLContext context) : base(context) {}

        public List<Event> FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
