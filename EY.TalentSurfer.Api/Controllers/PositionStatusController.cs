using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionStatusController : ControllerBase
    {
        private readonly IPositionStatusService _service;

        public PositionStatusController(IPositionStatusService service)
        {
            _service = service;
        }

        // GET: api/PositionStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PositionStatusReadDto>>> GetPositionStatus()
        {
            var certainties = await _service.GetAllAsync();
            return Ok(certainties);
        }

        // GET: api/PositionStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PositionStatusReadDto>> GetPositionStatus(int id)
        {
            var positionStatus = await _service.GetAsync(id);

            if (positionStatus == null)
            {
                return NotFound();
            }

            return Ok(positionStatus);
        }

        // PUT: api/PositionStatus/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPositionStatus(int id, PositionStatusUpdateDto positionStatus)
        {
            if (!await PositionStatusExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, positionStatus);

            return Ok(updated);
        }

        // POST: api/PositionStatus
        [HttpPost]
        public async Task<ActionResult<PositionStatusReadDto>> PostPositionStatus(PositionStatusCreateDto positionStatus)
        {
            var created = await _service.CreateAsync(positionStatus);

            return CreatedAtAction("GetPositionStatus", new { id = created.Id }, positionStatus);
        }

        // DELETE: api/PositionStatus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePositionStatus(int id)
        {
            if (!await PositionStatusExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> PositionStatusExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}