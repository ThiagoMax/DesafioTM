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

        public List<Event> FindByLocation(string location)
        {
            var events_location = _context.Events.Where(e => e.Location.Contains(location)).ToList();
            return events_location;
        }
        
        public List<Event> FindByOrganizerName(string name)
        {
            var events_name = _context.Events.Where(e => e.OrganizerName.Contains(name)).ToList();
            return events_name;
        }

        public List<Event> FindByEventDate(DateTime date)
        {
            var events_date = _context.Events.Where(e => e.Date.Date.Equals(date)).ToList();
            return events_date;
        }
    }
}
