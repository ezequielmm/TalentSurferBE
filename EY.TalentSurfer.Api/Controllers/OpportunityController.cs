using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportunityController : ControllerBase
    {
        private readonly IOpportunityService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public OpportunityController(IOpportunityService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
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

        // GET: api/Opportunity/Page
        [HttpGet("Page", Name = "GetOpportunityPage")]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetOpportunityPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var opportunitiesPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetOpportunityPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(opportunitiesPage);
        }
    }
}