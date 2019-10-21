using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _service;

        public StatusController(IStatusService service)
        {
            _service = service;
        }

        // GET: api/Status
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusReadDto>>> GetStatus()
        {
            var certainties = await _service.GetAllAsync();
            return Ok(certainties);
        }

        // GET: api/Status/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusReadDto>> GetStatus(int id)
        {
            var status = await _service.GetAsync(id);

            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }

        // PUT: api/Status/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutStatus(int id, StatusUpdateDto status)
        {
            if (!await StatusExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, status);

            return Ok(updated);
        }

        // POST: api/Status
        [HttpPost]
        public async Task<ActionResult<StatusReadDto>> PostStatus(StatusCreateDto status)
        {
            var created = await _service.CreateAsync(status);

            return CreatedAtAction("GetStatus", new { id = created.Id }, status);
        }

        // DELETE: api/Status/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStatus(int id)
        {
            if (!await StatusExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> StatusExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}