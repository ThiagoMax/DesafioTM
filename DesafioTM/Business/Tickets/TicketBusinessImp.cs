using AutoMapper;
using DesafioTM.Model;
using DesafioTM.Model.DTO;
using DesafioTM.Repository.Tickets;
using System;
using System.Collections.Generic;

namespace DesafioTM.Business.Tickets
{
    public class TicketBusinessImp : ITicket
    {
        private readonly ITicketRepository _repository;
        private readonly IMapper _mapper;

        public TicketBusinessImp(ITicketRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TicketDTO Create(TicketDTO ticket)
        {
            var tick = _repository.Create(_mapper.Map<Ticket>(ticket));
            return _mapper.Map<TicketDTO>(tick);
        }

        public List<TicketDTO> FindAll()
        {
            var tickets = _repository.FindAll();
            return _mapper.Map<List<TicketDTO>>(tickets);
        }

        public List<TicketDTO> FindByEventId(long id)
        {
            var tickets_event = _repository.FindByEventId(id);
            return _mapper.Map<List<TicketDTO>>(tickets_event);
        }

        public TicketDTO FindById(long id)
        {
            var ticket = _repository.FindById(id);
            return _mapper.Map<TicketDTO>(ticket);
        }

        public List<TicketDTO> FindByPurchaseId(long id)
        {
            var tickets = _repository.FindByPurchaseId(id);
            return _mapper.Map<List<TicketDTO>>(tickets);
        }

        public List<TicketDTO> FindByTicketType(string type)
        {
            var tickets_type = _repository.FindByTicketType(type);
            return _mapper.Map<List<TicketDTO>>(tickets_type);
        }

        public TicketDTO Update(TicketDTO ticket)
        {
            var tick = _repository.Update(_mapper.Map<Ticket>(ticket));
            return _mapper.Map<TicketDTO>(tick);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
