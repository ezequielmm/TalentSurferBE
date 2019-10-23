using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceLineController : ControllerBase
    {
        // TODO change repo to service
        private readonly IServiceLineService _service;

        public ServiceLineController(IServiceLineService service)
        {
            _service = service;
        }

        // GET: api/ServiceLine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceLineReadDto>>> GetServiceLines()
        {
            var ServiceLines = await _service.GetAllAsync();
            return Ok(ServiceLines);
        }

        // GET: api/ServiceLine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceLineReadDto>> GetServiceLine(int id)
        {
            var ServiceLine = await _service.GetAsync(id);

            if (ServiceLine == null)
            {
                return NotFound();
            }

            return Ok(ServiceLine);
        }

        // PUT: api/ServiceLine/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutServiceLine(int id, ServiceLineUpdateDto ServiceLine)
        {
            if (!await ServiceLineExists(id)) return NotFound();

            await _service.UpdateAsync(id, ServiceLine);

            return NoContent();
        }

        // POST: api/ServiceLine
        [HttpPost]
        public async Task<ActionResult<ServiceLineReadDto>> PostServiceLine(ServiceLineCreateDto ServiceLine)
        {
            var created = await _service.CreateAsync(ServiceLine);

            return CreatedAtAction("GetServiceLine", new { id = created.Id }, ServiceLine);
        }

        // DELETE: api/ServiceLine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteServiceLine(int id)
        {           
            if (!await ServiceLineExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> ServiceLineExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}