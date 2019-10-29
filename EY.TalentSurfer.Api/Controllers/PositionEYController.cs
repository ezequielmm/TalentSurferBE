using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionEYController : ControllerBase
    {
        private readonly IPositionEYService _service;

        public PositionEYController(IPositionEYService service)
        {
            _service = service;
        }

        // GET: api/PositionEY
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PositionEYReadDto>>> GetPositionsEY()
        {
            var positionsEY = await _service.GetAllAsync();
            return Ok(positionsEY);
        }

        // GET: api/PositionEY/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PositionEYReadDto>> GetPositionEY([FromRoute] int id)
        {
            var positionEY = await _service.GetAsync(id);

            if (positionEY == null)
            {
                return NotFound();
            }

            return Ok(positionEY);
        }

        // PUT: api/PositionEY/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPositionEY(int id, PositionEYUpdateDto positionEY)
        {
            if (!await _service.ExistsAsync(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, positionEY);

            return Ok(updated);
        }

        // POST: api/PositionEY
        [HttpPost]
        public async Task<ActionResult<PositionEYReadDto>> PostPositionEY([FromBody] PositionEYCreateDto positionEY)
        {
            var created = await _service.CreateAsync(positionEY);

            return CreatedAtAction("GetPositionEY", new { id = created.Id }, created);
        }

        // DELETE: api/PositionEY/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePositionEY([FromRoute] int id)
        {
            if (! await _service.ExistsAsync(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> PositionEYExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}