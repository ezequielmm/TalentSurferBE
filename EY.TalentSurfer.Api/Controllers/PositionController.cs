using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService _service;

        public PositionController(IPositionService service)
        {
            _service = service;
        }

        // GET: api/Position
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PositionReadDto>>> GetPositions()
        {
            var certainties = await _service.GetAllAsync<PositionReadDto>();
            return Ok(certainties);
        }

        // GET: api/Position/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PositionReadDto>> GetPosition(int id)
        {
            var position = await _service.GetAsync<PositionReadDto>(id);

            if (position == null)
            {
                return NotFound();
            }

            return Ok(position);
        }

        // PUT: api/Position/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPosition(int id, PositionUpdateDto position)
        {
            if (!await PositionExists(id)) return NotFound();

            await _service.UpdateAsync(id, position);

            return NoContent();
        }

        // POST: api/Position
        [HttpPost]
        public async Task<ActionResult<PositionReadDto>> PostPosition(PositionCreateDto position)
        {
            var created = await _service.CreateAsync<PositionReadDto>(position);

            return CreatedAtAction("GetPosition", new { id = created.Id }, position);
        }

        // DELETE: api/Position/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePosition(int id)
        {
            if (!await PositionExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> PositionExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}