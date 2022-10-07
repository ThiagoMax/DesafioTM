using AutoMapper;
using DesafioTM.Model;
using DesafioTM.Model.DTO;

namespace DesafioTM.Helpers
{
    public class HelperProfile : Profile
    {
        public HelperProfile()
        {
            CreateMap<Event, EventDTO>();
        }
    }
}
