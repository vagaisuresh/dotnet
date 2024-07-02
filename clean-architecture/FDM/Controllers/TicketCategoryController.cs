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
    public class TicketCategoryController : ControllerBase
    {
        private readonly ITicketCategoryService _service;
        private readonly IMapper _mapper;

        public TicketCategoryController(ITicketCategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<TicketCategoryDto>> GetAllAsync()
        {
            var categories = await _service.ListAsync();
            var resources = _mapper.Map<IEnumerable<Ticketcategory>, IEnumerable<TicketCategoryDto>>(categories);

            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] TicketCategorySaveDto ticketCategorySaveDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var category = _mapper.Map<TicketCategorySaveDto, Ticketcategory>(ticketCategorySaveDto);
            var result = await _service.SaveAsync(category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResponse = _mapper.Map<Ticketcategory, TicketCategoryDto>(result.Ticketcategory);
            return Ok(categoryResponse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(short id, [FromBody] TicketCategorySaveDto ticketCategorySaveDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var category = _mapper.Map<TicketCategorySaveDto, Ticketcategory>(ticketCategorySaveDto);
            var result = await _service.UpdateAsync(id, category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResponse = _mapper.Map<Ticketcategory, TicketCategoryDto>(result.Ticketcategory);
            return Ok(categoryResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(short id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResponse = _mapper.Map<Ticketcategory, TicketCategoryDto>(result.Ticketcategory);
            return Ok(categoryResponse);
        }
    }
}