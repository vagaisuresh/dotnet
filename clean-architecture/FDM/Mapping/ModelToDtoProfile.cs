using AutoMapper;
using FDM.Domain.Models;
using FDM.DTOs;

namespace FDM.Mapping
{
    public class ModelToDtoProfile : Profile
    {
        public ModelToDtoProfile()
        {
            CreateMap<Ticketcategory, TicketCategoryDto>();
            CreateMap<Ticket, TicketDto>();
        }
    }
}