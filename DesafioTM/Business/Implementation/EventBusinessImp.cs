using AutoMapper;
using DesafioTM.Model;
using DesafioTM.Model.DTO;
using DesafioTM.Repository;
using System.Collections.Generic;

namespace DesafioTM.Business.Implementation
{
    public class EventBusinessImp : IEvent
    {
        private readonly IEventRepository _repository;
        private readonly IMapper _mapper;

        public EventBusinessImp(IEventRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public EventDTO Create(EventDTO evento)
        {
            var eventt = _repository.Create(_mapper.Map<Event>(evento));
            return _mapper.Map<EventDTO>(eventt);
        }

        public List<EventDTO> FindAll()
        {
            var eventos = _repository.FindAll();
            return _mapper.Map<List<EventDTO>>(eventos);
        }

        public EventDTO FindById(long id)
        {
            var evento = _repository.FindById(id);
            return _mapper.Map<EventDTO>(evento);
        }

        public List<EventDTO> FindByName(string name)
        {
            var eventos = _repository.FindByName(name);
            return _mapper.Map<List<EventDTO>>(eventos);
        }

        public List<EventDTO> FindByType(string type)
        {
            var eventos = _repository.FindByType(type);
            return _mapper.Map<List<EventDTO>>(eventos);
        }

        public List<EventDTO> FindByLocation(string location)
        {
            var eventos = _repository.FindByLocation(location);
            return _mapper.Map<List<EventDTO>>(eventos);
        }

        public List<EventDTO> FindByOrganizerName(string name)
        {
            var eventos = _repository.FindByOrganizerName(name);
            return _mapper.Map<List<EventDTO>>(eventos);
        }

        public EventDTO Update(EventDTO evento)
        {
            var eventt = _repository.Update(_mapper.Map<Event>(evento));
            return _mapper.Map<EventDTO>(eventt);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
