using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportunityController : ControllerBase
    {
        private readonly IOpportunityService _service;

        public OpportunityController(IOpportunityService service)
        {
            _service = service;
        }

        // GET: api/Opportunity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OpportunityDisplayDto>>> GetOpportunitys()
        {
            var opportunities = await _service.GetAllAsync();
            return Ok(opportunities);
        }

        // GET: api/Opportunity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OpportunityReadDto>> GetOpportunity(int id)
        {
            var opportunity = await _service.GetAsync(id);

            if (opportunity == null)
            {
                return NotFound();
            }

            return Ok(opportunity);
        }

        // PUT: api/Opportunity/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutOpportunity(int id, OpportunityUpdateDto opportunity)
        {
            if (!await OpportunityExists(id)) return NotFound();

            await _service.UpdateAsync(id, opportunity);

            return NoContent();
        }

        // POST: api/Opportunity
        [HttpPost]
        public async Task<ActionResult<OpportunityReadDto>> PostOpportunity(OpportunityCreateDto opportunity)
        {
            var created = await _service.CreateAsync(opportunity);

            return CreatedAtAction("GetOpportunity", new { id = created.Id }, opportunity);
        }

        // DELETE: api/Opportunity/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOpportunity(int id)
        {
            if (!await OpportunityExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> OpportunityExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}