using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeniorityController : ControllerBase
    {
        private readonly ISeniorityService _service;

        public SeniorityController(ISeniorityService service)
        {
            _service = service;
        }

        // GET: api/Seniority
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeniorityReadDto>>> GetSeniority()
        {
            var certainties = await _service.GetAllAsync<SeniorityReadDto>();
            return Ok(certainties);
        }

        // GET: api/Seniority/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SeniorityReadDto>> GetSeniority(int id)
        {
            var seniority = await _service.GetAsync<SeniorityReadDto>(id);

            if (seniority == null)
            {
                return NotFound();
            }

            return Ok(seniority);
        }

        // PUT: api/Seniority/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutSeniority(int id, SeniorityUpdateDto seniority)
        {
            if (!await SeniorityExists(id)) return NotFound();

            await _service.UpdateAsync(id, seniority);

            return NoContent();
        }

        // POST: api/Seniority
        [HttpPost]
        public async Task<ActionResult<SeniorityReadDto>> PostSeniority(SeniorityCreateDto seniority)
        {
            var created = await _service.CreateAsync<SeniorityReadDto>(seniority);

            return CreatedAtAction("GetSeniority", new { id = created.Id }, seniority);
        }

        // DELETE: api/Seniority/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSeniority(int id)
        {
            if (!await SeniorityExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> SeniorityExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}