using AutoMapper;
using FDM.Domain.Models;
using FDM.Domain.Services;
using FDM.DTOs;
using FDM.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace FDM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _service;
        private readonly IMapper _mapper;

        public TicketController(ITicketService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Ticket>> GetAllAsync()
        {
            var tickets = await _service.ListAsync();
            var resources = _mapper.Map<IEnumerable<TicketDto>>(tickets);

            return tickets;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] TicketSaveDto ticketSaveDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var ticket = _mapper.Map<Ticket>(ticketSaveDto);
            var result = await _service.SaveAsync(ticket);

            if (!result.Success)
                return BadRequest(result.Message);

            var ticketResponse = _mapper.Map<Ticket, TicketDto>(result.Ticket);
            return Ok(ticketResponse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] TicketSaveDto ticketSaveDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var ticket = _mapper.Map<TicketSaveDto, Ticket>(ticketSaveDto);
            var result = await _service.UpdateAsync(id, ticket);

            if (!result.Success)
                return BadRequest(result.Message);

            var ticketResponse = _mapper.Map<Ticket, TicketDto>(result.Ticket);
            return Ok(ticketResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var ticketResponse = _mapper.Map<Ticket, TicketDto>(result.Ticket);
            return Ok(ticketResponse);
        }
    }
}