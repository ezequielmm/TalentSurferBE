using EY.TalentSurfer.Dto.SOW;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SowController : ControllerBase
    {
        private readonly ISowService _service;

        public SowController(ISowService service)
        {
            _service = service;
        }

        // GET: api/SOW
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SowReadDto>>> GetSOW()
        {
            var sow = await _service.GetAllAsync();
            return Ok(sow);
        }

        // GET: api/SOW/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SowReadDto>> GetSOW(int id)
        {
            var status = await _service.GetAsync(id);

            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }

        // PUT: api/SOW/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutSOW(int id, SowUpdateDto sow)
        {
            if (!await SOWExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, sow);

            return Ok(updated);
        }

        // POST: api/SOW
        [HttpPost]
        public async Task<ActionResult<SowReadDto>> PostSOW(SowCreateDto sow)
        {
            var created = await _service.CreateAsync(sow);

            return CreatedAtAction("GetSOW", new { id = created.Id }, sow);
        }

        // DELETE: api/SOW/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSOW(int id)
        {
            if (!await SOWExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> SOWExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}