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

        public EventDTO Create(Event evento)
        {
            var eventt = _repository.Create(evento);
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

        public EventDTO Update(Event evento)
        {
            var eventt = _repository.Update(evento);
            return _mapper.Map<EventDTO>(eventt);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
