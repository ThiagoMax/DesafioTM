using DesafioTM.Model;
using DesafioTM.Model.Context;
using DesafioTM.Model.DTO;
using DesafioTM.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTM.Repository.Implementation
{
    public class EventRepositoryImp : GenericRepository<Event>, IEventRepository
    {
        public EventRepositoryImp(MySQLContext context) : base(context) {}

        public List<Event> FindByType(string type)
        {
            var events_type = _context.Events.Where(e => e.Type.Contains(type)).ToList();
            return events_type;
        }

        public List<Event> FindByName(string name)
        {
            var events_name = _context.Events.Where(e => e.Name.Contains(name)).ToList();
            return events_name;
        }
    }
}
