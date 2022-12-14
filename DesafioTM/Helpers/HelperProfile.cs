using AutoMapper;
using DesafioTM.Model;
using DesafioTM.Model.DTO;

namespace DesafioTM.Helpers
{
    public class HelperProfile : Profile
    {
        public HelperProfile()
        {
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Users, UsersDTO>().ReverseMap();
            CreateMap<Users, GetIdUsersDTO>().ReverseMap();
            CreateMap<Purchase, PurchaseDTO>().ReverseMap();
            CreateMap<Ticket, TicketDTO>().ReverseMap();
        }
    }
}
