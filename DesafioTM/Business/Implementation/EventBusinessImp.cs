using DesafioTM.Model;
using DesafioTM.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTM.Business.Implementation
{
    public class EventBusinessImp : IEvent
    {
        private readonly MySQLContext _context;

        public EventBusinessImp(MySQLContext context)
        {
            _context = context;
        }

        public Event Create(Event evento)
        {
            try
            {
                _context.Add(evento);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return evento;
        }

        public List<Event> FindAll()
        {
            return _context.Events.ToList();
        }

        public Event FindById(long id)
        {
            return _context.Events.SingleOrDefault(evento => evento.Id.Equals(id));
        }

        public Event Update(Event evento)
        {
            var exist = _context.Events.SingleOrDefault(e => e.Id.Equals(evento.Id));

            if(exist != null)
            {
                try
                {
                    _context.Entry(exist).CurrentValues.SetValues(evento);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return evento;
        }

        public void Delete(long id)
        {
            var evento = _context.Events.SingleOrDefault(e => e.Id.Equals(id));

            if(evento != null)
            {
                try
                {
                    _context.Events.Remove(evento);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
