using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertaintyController : ControllerBase
    {
        private readonly ICertaintyService _service;

        public CertaintyController(ICertaintyService service)
        {
            _service = service;
        }

        // GET: api/Certainty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetCertainty()
        {
            var certainties = await _service.GetAllAsync<CertaintyReadDto>();
            return Ok(certainties);
        }

        // GET: api/Certainty/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CertaintyReadDto>> GetCertainty(int id)
        {
            var certainty = await _service.GetAsync<CertaintyReadDto>(id);

            if (certainty == null)
            {
                return NotFound();
            }

            return Ok(certainty);
        }

        // PUT: api/Certainty/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutCertainty(int id, CertaintyUpdateDto certainty)
        {
            if (!await CertaintyExists(id)) return NotFound();

            await _service.UpdateAsync(id, certainty);

            return NoContent();
        }

        // POST: api/Certainty
        [HttpPost]
        public async Task<ActionResult<CertaintyReadDto>> PostCertainty(CertaintyCreateDto certainty)
        {
            var created = await _service.CreateAsync<CertaintyReadDto>(certainty);

            return CreatedAtAction("GetCertainty", new { id = created.Id }, certainty);
        }

        // DELETE: api/Certainty/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCertainty(int id)
        {
            if (!await CertaintyExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> CertaintyExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}