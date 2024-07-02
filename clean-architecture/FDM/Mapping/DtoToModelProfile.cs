using AutoMapper;
using FDM.Domain.Models;
using FDM.DTOs;

namespace FDM.Mapping
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<TicketCategorySaveDto, Ticketcategory>();
        }
    }
}
